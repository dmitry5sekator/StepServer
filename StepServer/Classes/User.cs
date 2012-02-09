using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepServer.Classes
{
    class User
    {
        private int id;
        private String nick;
        private String password;
        private String info;
        public User()
        { }

        public User(Dictionary<String, String> dict)
        {

            this.info = dict.;
            this.password = dict.get("password");
            this.nick = dict.get("nick");
        }

        public void setNick(String nick)
        { this.nick = nick; }
        public void setPass(String password)
        { this.password = password; }
        public void setInfo(String info)
        { this.info = info; }

        public int getId()
        { return id; }
        public String getNick()
        { return nick; }
        public String getPass()
        { return password; }
        public String getInfo()
        { return info; }

        public Dictionary<String, String> toMap()
        {
            Dictionary<String, String> temp = new Dictionary<String, String>();
            temp.Add("nick", this.nick);
            temp.Add("password", this.password);
            temp.Add("info", this.info);
            return temp;
        }
    }
}
