using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSoOnline
{
    class Interface
    {
        public static int PrintMainMenu() {
        BeginMenu:
            
            Console.WriteLine("****Mua ve so online");
            Console.WriteLine("1.Xem tất cả dãy số đang được bán. \n2.Xem các dãy số đã mua \n3.Đăng nhập \n0.Thoát\n");
            Console.WriteLine("-------------------------------------");
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
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,10}", "Dãy số", "Ngày xổ", "Số người mua", "Giá tiền");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}","123456","11-10-2017","20","10,000VNĐ");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "654321", "10-10-2017", "113", "10,000VNĐ");
            IO.PromptOption("trở về màn hình chính",-2);

        }
    }
}
