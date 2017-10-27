using System;
using System.Collections.Generic;

namespace VeSoOnline
{
    class Interface
    {
        public static int PrintMainMenu(string userName) {
        BeginMenu:            
            if (userName == "")
            {
                Console.WriteLine("****Mua ve so online****{0,30}", "Khách lai vãng");                
                Console.WriteLine("1.Xem tất cả dãy số đang được bán. \n2.Xem các dãy số đã mua \n3.Đăng nhập \n0.Thoát\n");
            }
            else {
                Console.WriteLine("****Mua ve so online****{0,30}", userName);
                Console.WriteLine("1.Xem tất cả dãy số đang được bán. \n2.Xem các dãy số đã mua \n3.Đăng xuất \n0.Thoát\n");
            }
            Console.WriteLine("---------------------------------------------------------");
            int choice = IO.PromptOption("Nhập vào lựa chọn của mình: ", 3);
            if (choice > -1) {
                return choice;
            } else {
                Console.Clear();
                goto BeginMenu;
            }
        }
        public static void PrintAllTickets() {
            Console.Clear();
            Database.GetAllTickets();
            //Console.WriteLine("Không có dãy số này đang được mở bán.");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,10}", "Dãy số", "Ngày xổ", "Số người mua", "Giá tiền");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "123456", "11-10-2017", "20", "10,000VNĐ");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "654321", "10-10-2017", "113", "10,000VNĐ");
            IO.PromptOption("trở về màn hình chính", -2);
            
        }
        public static void PrintAllBroughtTickets(string userID) {
            Console.Clear();
            Database.GetAllBroughtTicket(userID);
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "Dãy số", "Ngày xổ", "Ngày mua", "Giá tiền");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "123456", "11-10-2017", "11-10-2017", "10,000VNĐ");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "654321", "10-10-2017", "10-10-2017", "10,000VNĐ");
            IO.PromptOption("trở về màn hình chính", -2);
        }
        public static void ShowLogin(ref Dictionary<string,string> info,Database database) {
            Console.Clear();
            Console.Write("Nhập vào tên đăng nhập: ");
            string tempUsername = Console.ReadLine();
            Dictionary<string,string> processInfo = database.giveUserInfo(tempUsername);
            int index;
            if (processInfo == null)
            {
                index = -1;
            }
            else {
                index = int.Parse(processInfo["index"]);
            }
            Console.Write("Nhập vào mật khẩu: ");
            string userID = database.validateLogin(tempUsername, IO.Returnpassword(), index);
            if(userID == "" || userID == null)
            {
                Console.WriteLine("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin và thử lại.");
                IO.PromptOption("trở về màn hình chính", -2);
                return;
            } 
            info["name"] = processInfo["name"];
            info["index"] = processInfo["index"];
            info["isManager"] = processInfo["isManager"];
            info["userID"] = userID;            
            Console.WriteLine("Đăng nhập thành công");
            IO.PromptOption("trở về màn hình chính", -2);
        }
        public static int ShowLogout(ref Dictionary<string,string> info) {
            Console.Clear();
            Console.WriteLine("Bạn có chắc chắn muốn đăng xuất ?\n1.Tôi chắc\n0.Hủy");
            int choice = IO.PromptOption("Nhập vào lựa chọn của mình: ", 1);
            if (choice == 1) {
                info.Remove("name");
                info.Remove("index");
                info.Remove("isManager");
                info.Remove("userID");
            }
            return choice;
        }
        public static void ShowError(string mess) {
            Console.Clear();
            Console.WriteLine(mess);
            IO.PromptOption("trở về màn hình chính", -2);
            Console.Clear();
        }
    }
}
