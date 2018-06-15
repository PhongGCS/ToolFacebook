using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInfoGroupMember_DoKhacPhong
{
    class User
    {
        private string id, name, phone, mail;

        public User(string id="", string name="", string phone="", string mail="")
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.mail = mail;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
