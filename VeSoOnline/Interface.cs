using System;

namespace VeSoOnline
{
    class Interface
    {
        public static int PrintMainMenu(Users userInfo) {
        BeginMenu:            
            if (!userInfo.isLogin())
            {
                Console.WriteLine("****Mua ve so online****{0,30}", "Khách lai vãng");                
                Console.WriteLine("1.Xem tất cả dãy số đang được bán. \n2.Xem các dãy số đã mua \n3.Đăng nhập \n0.Thoát\n");
            }
            else {
                Console.WriteLine("****Mua ve so online****{0,30}", userInfo.userName);
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
        public static void PrintAllBroughtTickets(Users userInfo) {
            Console.Clear();
            Database.GetAllBroughtTicket(userInfo);
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "Dãy số", "Ngày xổ", "Ngày mua", "Giá tiền");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "123456", "11-10-2017", "11-10-2017", "10,000VNĐ");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "654321", "10-10-2017", "10-10-2017", "10,000VNĐ");
            IO.PromptOption("trở về màn hình chính", -2);
        }
        public static void ShowLogin(ref Users userInfo) {
            Console.Clear();
            Console.Write("Nhập vào tên đăng nhập: ");
            userInfo.userName = Console.ReadLine();
            Console.Write("Nhập vào mật khẩu: ");
            userInfo.password = IO.Returnpassword();
            Console.WriteLine("Đăng nhập thành công");
            IO.PromptOption("trở về màn hình chính", -2);
        }
        public static int ShowLogout(ref Users userInfo) {
            Console.Clear();
            Console.WriteLine("Bạn có chắc chắn muốn đăng xuất ?\n1.Tôi chắc\n0.Hủy");
            int choice = IO.PromptOption("Nhập vào lựa chọn của mình: ", 1);
            if (choice == 1) {
                userInfo.Clear();
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
