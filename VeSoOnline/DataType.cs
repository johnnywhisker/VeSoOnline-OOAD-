using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VeSoOnline
{
    public class Users {
        private string userName = "";
        private string password = "";
        public string userID = "";
        private string name = "";
        private string socialSecurityNumber = "";
        public bool isManager = false;

        public Users(string userName, string password, string userID, string name, string socialSecurityNumber, bool isManager) {
            this.userName = userName;
            this.password = password;
            this.userID = userID;
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
            this.isManager = isManager;
        }
        public string validateLogin(string userName, string password) {
            if (this.userName.Equals(userName) && (this.password.Equals(password)))
                return userID;
            else
                return null;
        }
        public Dictionary<string, string> getInfo() {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("name", name);
            info.Add("socialSecurityNumber", socialSecurityNumber);
            info.Add("userID", userID);
            info.Add("isManager", isManager.ToString());
            return info;
        }
        public bool isMe(string input) {
            if (userName.Contains(input) || userID.Contains(input) || name.Contains(input) || socialSecurityNumber.Contains(input)) {
                return true;
            }
            return false;
        }
    }

    public class Ticket {
        private string numbers = "";
        private DateTime createdDay = DateTime.Now;
        private DateTime endDay = new DateTime();
        private string ticketID = "";
        private string[] buyBy = { };
        private string price = "";
        private bool winningStatus = false;

        public Dictionary<string,Object> getInfo()
        {
            Dictionary<string, Object> info = new Dictionary<string, Object>();
            info.Add("createdDay", createdDay);
            info.Add("endDay", endDay);
            info.Add("ticketID", ticketID);
            info.Add("listBuyer", buyBy);
            info.Add("price", price);
            info.Add("status", winningStatus);
            return info;
        }

        public bool isMe(string input) {

            Regex rgx = new Regex(@"\d{2}-\d{2}-\d{4}");
            Match mat = rgx.Match(input);
            if (mat.ToString() != "")
            {
                DateTime timeInput = DateTime.Parse(mat.ToString());
                if (createdDay.Date == timeInput || endDay.Date == timeInput)
                {                    
                    return true; ;
                }
            }
            else
            {
                if (ticketID.Contains(input) || price.Contains(input)|| numbers.Contains(input))
                    Console.Write(true);
                return true;
            }           
            return false;
        }
    }


        
}
