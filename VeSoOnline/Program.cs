using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSoOnline
{
    class Program
    {
        private Dictionary<string, string> seasionInfo = new Dictionary<string, string>();
        private Database database = new Database();
        static void Main(string[] args)
        {
            Program thiss = new Program();
            Begin:
            Console.OutputEncoding = Encoding.UTF8;
            switch (Interface.PrintMainMenu((thiss.seasionInfo.ContainsKey("name")?thiss.seasionInfo["name"]:""))) {
                case 1:
                    Interface.PrintAllTickets();
                    break;
                case 2:
                    if (thiss.seasionInfo.ContainsKey("userID"))
                    {
                        
                            Interface.PrintAllBroughtTickets(thiss.seasionInfo["userID"]);                                               
                            
                    }
                    else {
                        
                        Interface.ShowError("Bạn phải đăng nhập để xài chức năng này.");
                    }
                    break;
                case 3:
                Case3:
                    if (!thiss.seasionInfo.ContainsKey("userID")) {
                        Interface.ShowLogin(ref thiss.seasionInfo,thiss.database);
                    }
                    else {
                        if (Interface.ShowLogout(ref thiss.seasionInfo) == -1) {
                            Console.Clear();
                            goto Case3;
                        } 
                    }
                    break;
                default:
                    Environment.Exit(69);
                    break;
            }
            Console.Clear();
            goto Begin;
        }
    }
}
