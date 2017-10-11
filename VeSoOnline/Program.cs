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
            Begin:
            Console.OutputEncoding = Encoding.UTF8;

            switch (Interface.PrintMainMenu()) {
                case 1:
                    Interface.PrintAllTickets();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    
                    break;
            }
            Console.Clear();
            goto Begin;
        }
    }
}
