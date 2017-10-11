using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Users currentUser = new Users();
            Begin:
            Console.OutputEncoding = Encoding.UTF8;
            switch (Interface.PrintMainMenu(currentUser)) {
                case 1:
                    Interface.PrintAllTickets();
                    break;
                case 2:
                    if (currentUser.isLogin())
                    {
                        Interface.PrintAllBroughtTickets(currentUser);
                    }
                    else {
                        Interface.ShowError("Bạn phải đăng nhập để xài chức năng này.");
                    }
                    break;
                case 3:
                Case3:
                    if (!currentUser.isLogin()) {
                        Interface.ShowLogin(ref currentUser);
                    }
                    else {
                        if (Interface.ShowLogout(ref currentUser) == -1) {
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
