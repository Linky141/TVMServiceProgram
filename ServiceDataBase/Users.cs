using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataBase
{
    public class Users
    {
        public Users(string _login, string _password, bool _u1, bool _u2, bool _u3, bool _u4)
        {
            login = _login;
            password = _password;
            u1 = _u1;
            u2 = _u2;
            u3 = _u3;
            u4 = _u4;
        }

        //podstawowe dane logowania
        string login;
        string password;

        //uprawnienia
        bool u1;
        bool u2;
        bool u3;
        bool u4;

        //gettery i settery
        public void setLogin(string val) { login = val; }
        public void setPassword(string val) { password = val; }

        public string getLogin() { return login; }
        public string getPassword() { return password; }

        public void setU1(bool val) { u1 = val; }
        public bool getU1() { return u1; }

        public void setU2(bool val) { u2 = val; }
        public bool getU2() { return u2; }

        public void setU3(bool val) { u3 = val; }
        public bool getU3() { return u3; }

        public void setU4(bool val) { u4 = val; }
        public bool getU4() { return u4; }
    }
}
