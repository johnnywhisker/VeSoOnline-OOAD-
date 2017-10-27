using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSoOnline
{
    class Database
    {
        private List<Users> users = new List<Users>();
        private List<Ticket> tickets = new List<Ticket>();
        public Database() {
            users.Add(new Users("John Whisker", "Hoilamgi123", "123", "Dang Khoi Nguyen", "123456789", true));
        }
        public Dictionary<string,string> giveUserInfo(string username)
        {
            foreach(Users user in users)
            {
                if (user.isMe(username)) {
                    Dictionary<string, string> retInfo = user.getInfo();
                    retInfo.Add("index", users.IndexOf(user).ToString());
                    return retInfo;
                }               
            }
            return null;
        }

        public string validateLogin(string username, string password, int index) {
            if (index == -1) {
                return "";
            }
            return users[index].validateLogin(username, password);
        }
        public static List<Ticket> GetAllTickets() {
            List<Ticket> tickets = new List<Ticket>();

            return tickets;
        }
        public static List<Ticket> GetAllBroughtTicket(string userID) {
            List<Ticket> tickets = new List<Ticket>();

            return tickets;
        }
    }
}
