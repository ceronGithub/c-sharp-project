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

        public int intLoop0()
        {
            return 0;
        }

        public string stringLoop0() {
            List<string> result = new List<string>();
            for (int loop = 0; loop <= 10; loop++)
            {
                result.Add("\t" + loop + "\n\n");
            }
            return string.Join("", result);
        }

        public double doubleLoop0()
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
                    stringResult.Add(i + "." + " -");
                }
                if (i %3 == 0 && !(i % 3 == 0 && i % 5 == 0))
                {
                    stringResult.Add(i + "." + " ping");
                }
                if (i %5 == 0 && !(i % 3 == 0 && i % 5 == 0))
                {
                    stringResult.Add(i + "." + " pong");
                }
                if (i %3 == 0 && i %5 == 0)
                {
                    stringResult.Add(i + "." + " ping-pong");
                }
            }
            // convert string array into string
            return String.Join("\n", stringResult);                       
        }

        public string pingPong0(string value)
        {
            // String.join : converts string[](array) to string
            int convertionStringToInt = Int32.Parse(String.Join(" ", value));
            List<string> stringResult = new List<string>();
            for (int i = 1; i <= convertionStringToInt; i++)
            {
                if (i % 3 == 0 && !(i % 3 == 0 && i % 5 == 0))
                {
                    stringResult.Add(i + "." + " ping");
                }
                if (i % 5 == 0 && !(i % 3 == 0 && i % 5 == 0))
                {
                    stringResult.Add(i + "." + " pong");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringResult.Add(i + "." + " ping-pong");
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
