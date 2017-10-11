using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSoOnline
{
    class IO
    {
        public static int PromptOption(string message, int numberOfOption) {
            if (numberOfOption == -2) {
                Console.WriteLine("Bấm phím bất kì để {0}",message);
                Console.ReadKey();
                return 0;
            }
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
                if (choice < 0 || choice > numberOfOption)
                {
                    throw new System.IO.InvalidDataException();
                }               
            } catch (Exception e) {
                Console.Clear();
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Giá trị chỉ từ 0 đến {0}. Bấm phím bất kì để nhập lại.", numberOfOption);
                Console.ReadKey();
                return -1;
            }
            return choice;
        }
    }
}
