using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.NetworkInformation;


namespace for_loop
{
    internal class for_loop
    {
        public static string staticMethod()
        {
            return "static";
        }

        public string nonStatisMethod()
        {
            return "non-static";
        }

        public int loop1()
        {
            return 0;
        }

        public string loop2() {
            return "...";
        }

        public double loop3()
        {
            return 1.00D;
        }

        public string pingPong(string value)
        {            
            // String.join : converts string[](array) to string
            int convertionStringToInt = Int32.Parse(String.Join(" ", value));
            List<string> stringResult = new List<string>();
            for (int i = 1; i <= convertionStringToInt; i++)
            {                
                if(!(i%3==0) && !(i%5==0))
                {
                    stringResult.Add("-");
                }
                if (i %3 == 0)
                {
                    stringResult.Add("ping");
                }
                if (i %5 == 0)
                {
                    stringResult.Add("pong");
                }
                if (i %3 == 0 && i %5 == 0)
                {
                    stringResult.Add("ping-pong");
                }
            }
            // convert string array into string
            return String.Join("\n", stringResult);                       
        }

        public int theValueOfAisB(int A, int B)
        {
            A = A - B;
            return A;
        }

        public int TheValueOfBIsA(int A, int B)
        {
            B = A - B + B;
            return B;
        }
    }
}
