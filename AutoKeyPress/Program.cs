using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKeyPress
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args != null)
            {
                if( args.Length > 0)
                {

                } else
                {
                    SendKeyMethod key = new SendKeyMethod();
                    key.StartAutoPress();
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
