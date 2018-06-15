using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using static FindInfoGroupMember_DoKhacPhong.User;
using System.Collections.Generic;
using CsvFile;
using System.IO;
using System.Text.RegularExpressions;

namespace FindInfoGroupMember_DoKhacPhong
{
    public partial class Form1 : Form
    {
        bool Is_stop = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_group_Click(object sender, EventArgs e)
        {
            var id_group = txt_ID.Text;
            get_Member_Group(id_group);
        }
        private void get_Member_Group(string id_group)
        {
            List<User> listUserGroup = new List<User>();

            // WebRequest request = WebRequest.Create("https://graph.facebook.com/v2.8/" + id_group + "/members?access_token=EAAAAAYsX7TsBAG7sap0a9nxlufvSQKuMA888RaBTXnubsjjGTyV35fB8WVJsHa4mexGWvrlNJ4hxqfdlztZCwINFrqUchBZC5toOj6CCrlgun7mA4ZBKtf9NKZBrKAz9SxWEnRHZBeIdAXf2DKmZBB3Kp8hQbPk8lNZA15Cw7wJTQPLRRdarE1kpM8ZBza6bsZA3Y5Nrlo36ZBZBoHcSfBWnHjy&pretty=1&limit=300&after=QVFIUjAyMXltMHlpZAFRTdXc3VEZAJNnhSMW1GOVZAZAaXJ4aENSdF9qU29Idi1LY0FjZAWlrMk9Pem1zRDJrZAHR3UmU2RXowYmx3UkRGbXZA2VkhnZAEsyRFkyYTZAn");
            // request.Method = "GET";
            var next_page = "";
            int count = 0;
            WebClient wc = new WebClient();
            var json = "";
            try
            {
                json = wc.DownloadString("https://graph.facebook.com/v2.8/" + id_group + "/members?access_token=EAAAAAYsX7TsBAG7sap0a9nxlufvSQKuMA888RaBTXnubsjjGTyV35fB8WVJsHa4mexGWvrlNJ4hxqfdlztZCwINFrqUchBZC5toOj6CCrlgun7mA4ZBKtf9NKZBrKAz9SxWEnRHZBeIdAXf2DKmZBB3Kp8hQbPk8lNZA15Cw7wJTQPLRRdarE1kpM8ZBza6bsZA3Y5Nrlo36ZBZBoHcSfBWnHjy&pretty=1&limit=300");
            }
            catch (Exception)
            {
                MessageBox.Show("Nhap ID Group | KIểm Tra Internet | Sai Token");
                return;
            }
            var data = JObject.Parse(json);

            DateTime now = DateTime.Now;

            string filename = "Group-"+id_group+"-" + now.Day +"-"+ now.Month +"-"+ now.Hour+"-"+now.Second+ ".csv";

            do
            {
                
                foreach (var item in data["data"])
                {
                    string id = item["id"].ToString();
                    string name = item["name"].ToString();
                    User temp = new User(id, name);
                    string link_user = "https://graph.facebook.com/"+temp.Id+"?fields=mobile_phone,email&access_token=EAAAAAYsX7TsBAG7sap0a9nxlufvSQKuMA888RaBTXnubsjjGTyV35fB8WVJsHa4mexGWvrlNJ4hxqfdlztZCwINFrqUchBZC5toOj6CCrlgun7mA4ZBKtf9NKZBrKAz9SxWEnRHZBeIdAXf2DKmZBB3Kp8hQbPk8lNZA15Cw7wJTQPLRRdarE1kpM8ZBza6bsZA3Y5Nrlo36ZBZBoHcSfBWnHjy";
                    var json_user = wc.DownloadString(link_user);
                    var data_user = JObject.Parse(json_user);
                    try
                    {
                        temp.Phone = data_user["phone"].ToString();
                    }
                    catch (Exception)
                    {
                        temp.Phone = "";
                    }
                    try
                    {
                        temp.Mail = data_user["email"].ToString();
                    }
                    catch (Exception)
                    {
                        temp.Mail = "";
                    }

                    List<string> columns = new List<string>();


                    if (cb_id.Checked)
                    {
                        columns.Add(temp.Id);
                    }
                    if (cb_Name.Checked)
                    {
                        columns.Add(temp.Name);
                    }
                    if (cb_phone.Checked)
                    {
                        columns.Add(temp.Phone);
                    }
                    if (cb_Email.Checked)
                    {
                        columns.Add(temp.Mail);
                    }

                    if(cb_Email.Checked && temp.Mail != "" || cb_phone.Checked && temp.Phone != "" || cb_Name.Checked && temp.Name != "" || cb_id.Checked && temp.Id != "")
                    {
                        using (var writer = new CsvFileWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename, true, System.Text.Encoding.UTF8))
                        {
                            writer.WriteRow(columns);
                        }
                        count++;

                        lb_count_data.Text = "Đã Lấy Được " + count + " Người.";
                    }

                    if (Is_stop)
                    {
                        MessageBox.Show("Tìm Kiếm " + count + " Kết Quả");
                        return;
                    }


                }
                try
                {
                    next_page = data["paging"]["next"].ToString();
                    json = wc.DownloadString(next_page);
                    data = JObject.Parse(json);
                }
                catch (Exception)
                {
                    Console.WriteLine("Duyet Xong");
                    next_page = null;
                }



            } while (next_page != null);

            MessageBox.Show("Tìm Kiếm "+ count +" Kết Quả");

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Is_stop = true;
            Console.WriteLine("Tat Chuong trinh");
        }

        private void btn_get_email_Click(object sender, EventArgs e)
        {
            var id_post = txt_idpost.Text;
            get_Email_Comment(id_post);
        }
        public void get_Email_Comment(string id_post)
        {
            List<string> columns = new List<string>();
            WebClient wc = new WebClient();
            var json_post = "";
            try
            {
                json_post = wc.DownloadString("https://graph.facebook.com/v2.8/" + id_post + "/comments/?access_token=EAAAAAYsX7TsBAG7sap0a9nxlufvSQKuMA888RaBTXnubsjjGTyV35fB8WVJsHa4mexGWvrlNJ4hxqfdlztZCwINFrqUchBZC5toOj6CCrlgun7mA4ZBKtf9NKZBrKAz9SxWEnRHZBeIdAXf2DKmZBB3Kp8hQbPk8lNZA15Cw7wJTQPLRRdarE1kpM8ZBza6bsZA3Y5Nrlo36ZBZBoHcSfBWnHjy&pretty=1&limit=36000");

            }catch (Exception)
            {
                MessageBox.Show("Sai Nhap ID Group | Không có Internet | Sai Token");
                return;
            }
            var data_post = JObject.Parse(json_post);
            DateTime now = DateTime.Now;

            string filename = "Post-Comment" + id_post + "-" + now.Day + "-" + now.Month + "-" + now.Hour + "-" + now.Second + ".csv";
            int count_email_comment = 0;
            foreach (var item in data_post["data"])
            {
                Get_Filter_Email(item["message"].ToString(), filename);
                count_email_comment++;
                lb_comment.Text = "Đã Lấy Được " + count_email_comment + "Email";
            }

            MessageBox.Show("Get Xong "+count_email_comment+ " Email");
        }
        public static void Get_Filter_Email(string text,string filename)
        {
            const string MatchEmailPattern =
           @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Find matches.
            MatchCollection matches = rx.Matches(text);
            // Report the number of matches found.
            int noOfMatches = matches.Count;
            // Report on each match.
            foreach (Match match in matches)
            {
                using (var writer = new CsvFileWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename, true, System.Text.Encoding.UTF8))
                {
                    List<string> temp = new List<string>();
                    temp.Add(match.Value.ToString());
                    writer.WriteRow(temp);
                }
                //Console.WriteLine(match.Value.ToString());
                //return match.Value.ToString();
            }
        }
    }
}
