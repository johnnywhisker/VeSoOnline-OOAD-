using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSoOnline
{
    public class Users {
        public string userName = "";
        public string password = "";
        public void Clear() {
            userName = "";
            password = "";
        }
        public bool isLogin() {
            if (userName != "" && password != "")
                return true;
            return false;
        }
    }

    public class Ticket {

    }
        
}
