﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace how_to_pass_data_from_form_to_class
{
    internal class Class
    {

        public static string StaticMethod()
        {
            return "Static Method";
        }

        public string NonStaticMethod()
        {
            return "Non-Static Method";
        }
            
        public string NonStaticMethod2(string Svalue) { 
            if(Svalue == "Recieved from Form1")
            {
                return "Retrieved, from class.";
            }
            else
            {
                return "didnt recieved any data from form!.";
            }
        }

        public static int StaticMethod1(int Ivalue) { 
            if(Ivalue == 0)
            {
                return 1;
            }
            else
            {
                return -0;
            }
        }

        public static Double StaticMethod2(Double Dvalue)
        {
            if (Dvalue == 2.98)
            {
                return 3;
            }
            else
            {
                return -0;
            }
        }
    }
}
