namespace FindInfoGroupMember_DoKhacPhong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Group = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_stop = new System.Windows.Forms.Button();
            this.cb_id = new System.Windows.Forms.CheckBox();
            this.cb_Email = new System.Windows.Forms.CheckBox();
            this.cb_phone = new System.Windows.Forms.CheckBox();
            this.cb_Name = new System.Windows.Forms.CheckBox();
            this.lb_count_data = new System.Windows.Forms.Label();
            this.btn_submit_group = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idpost = new System.Windows.Forms.TextBox();
            this.btn_get_email = new System.Windows.Forms.Button();
            this.lb_comment = new System.Windows.Forms.Label();
            this.Group.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group
            // 
            this.Group.Controls.Add(this.tabPage1);
            this.Group.Controls.Add(this.tabPage2);
            this.Group.Location = new System.Drawing.Point(-1, 0);
            this.Group.Name = "Group";
            this.Group.SelectedIndex = 0;
            this.Group.Size = new System.Drawing.Size(691, 312);
            this.Group.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_stop);
            this.tabPage1.Controls.Add(this.cb_id);
            this.tabPage1.Controls.Add(this.cb_Email);
            this.tabPage1.Controls.Add(this.cb_phone);
            this.tabPage1.Controls.Add(this.cb_Name);
            this.tabPage1.Controls.Add(this.lb_count_data);
            this.tabPage1.Controls.Add(this.btn_submit_group);
            this.tabPage1.Controls.Add(this.txt_ID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(683, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Group";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(283, 190);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 38);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // cb_id
            // 
            this.cb_id.AutoSize = true;
            this.cb_id.Location = new System.Drawing.Point(46, 190);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(58, 17);
            this.cb_id.TabIndex = 7;
            this.cb_id.Text = "Lưu ID";
            this.cb_id.UseVisualStyleBackColor = true;
            // 
            // cb_Email
            // 
            this.cb_Email.AutoSize = true;
            this.cb_Email.Checked = true;
            this.cb_Email.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Email.Location = new System.Drawing.Point(46, 167);
            this.cb_Email.Name = "cb_Email";
            this.cb_Email.Size = new System.Drawing.Size(72, 17);
            this.cb_Email.TabIndex = 6;
            this.cb_Email.Text = "Lưu Email";
            this.cb_Email.UseVisualStyleBackColor = true;
            // 
            // cb_phone
            // 
            this.cb_phone.AutoSize = true;
            this.cb_phone.Checked = true;
            this.cb_phone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_phone.Location = new System.Drawing.Point(46, 146);
            this.cb_phone.Name = "cb_phone";
            this.cb_phone.Size = new System.Drawing.Size(69, 17);
            this.cb_phone.TabIndex = 5;
            this.cb_phone.Text = "Lưu SĐT";
            this.cb_phone.UseVisualStyleBackColor = true;
            // 
            // cb_Name
            // 
            this.cb_Name.AutoSize = true;
            this.cb_Name.Location = new System.Drawing.Point(46, 123);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(66, 17);
            this.cb_Name.TabIndex = 4;
            this.cb_Name.Text = "Lưu Tên";
            this.cb_Name.UseVisualStyleBackColor = true;
            // 
            // lb_count_data
            // 
            this.lb_count_data.AutoSize = true;
            this.lb_count_data.Location = new System.Drawing.Point(168, 190);
            this.lb_count_data.Name = "lb_count_data";
            this.lb_count_data.Size = new System.Drawing.Size(0, 13);
            this.lb_count_data.TabIndex = 3;
            // 
            // btn_submit_group
            // 
            this.btn_submit_group.Location = new System.Drawing.Point(283, 123);
            this.btn_submit_group.Name = "btn_submit_group";
            this.btn_submit_group.Size = new System.Drawing.Size(100, 38);
            this.btn_submit_group.TabIndex = 2;
            this.btn_submit_group.Text = "Tìm Kiếm";
            this.btn_submit_group.UseVisualStyleBackColor = true;
            this.btn_submit_group.Click += new System.EventHandler(this.btn_submit_group_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(160, 77);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(349, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm thông tin thành viên trong Group";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_comment);
            this.tabPage2.Controls.Add(this.btn_get_email);
            this.tabPage2.Controls.Add(this.txt_idpost);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(683, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bài Viết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lấy Email Khi Khách Hàng Comment";
            // 
            // txt_idpost
            // 
            this.txt_idpost.Location = new System.Drawing.Point(157, 68);
            this.txt_idpost.Name = "txt_idpost";
            this.txt_idpost.Size = new System.Drawing.Size(355, 20);
            this.txt_idpost.TabIndex = 2;
            // 
            // btn_get_email
            // 
            this.btn_get_email.Location = new System.Drawing.Point(259, 110);
            this.btn_get_email.Name = "btn_get_email";
            this.btn_get_email.Size = new System.Drawing.Size(122, 43);
            this.btn_get_email.TabIndex = 3;
            this.btn_get_email.Text = "Lấy Email";
            this.btn_get_email.UseVisualStyleBackColor = true;
            this.btn_get_email.Click += new System.EventHandler(this.btn_get_email_Click);
            // 
            // lb_comment
            // 
            this.lb_comment.AutoSize = true;
            this.lb_comment.Location = new System.Drawing.Point(259, 188);
            this.lb_comment.Name = "lb_comment";
            this.lb_comment.Size = new System.Drawing.Size(0, 13);
            this.lb_comment.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 314);
            this.Controls.Add(this.Group);
            this.Name = "Form1";
            this.Text = "DoKhacPhong - Tool";
            this.Group.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Group;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_submit_group;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_count_data;
        private System.Windows.Forms.CheckBox cb_id;
        private System.Windows.Forms.CheckBox cb_Email;
        private System.Windows.Forms.CheckBox cb_phone;
        private System.Windows.Forms.CheckBox cb_Name;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_get_email;
        private System.Windows.Forms.TextBox txt_idpost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_comment;
    }
}

