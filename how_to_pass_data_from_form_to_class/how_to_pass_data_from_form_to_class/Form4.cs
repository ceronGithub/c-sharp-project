using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how_to_pass_data_from_form_to_class
{
    public partial class Form4 : Form
    {
        Class methods = new Class();
        public Form4()
        {
            InitializeComponent();
        }

        // create a double variable to received the double variable data that was sent from f1
        double ReturnDouble;
        // this function will able to pass data from f1 to f4
        public double passedDataFromForm1(Double fDouble)
        {
            // get the data, that has been passed by the f1
            // return the data.
            return ReturnDouble = fDouble;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // convert double variable to string
            label2.Text = "" + ReturnDouble;
            label5.Text = "double data pass by f1: " + ReturnDouble;
            label6.Text = "double data pass by class: " + Class.StaticMethod2(ReturnDouble);
        }
        
    }
}
