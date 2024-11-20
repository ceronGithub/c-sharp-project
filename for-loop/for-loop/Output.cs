using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_loop
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        string stringForLoop0;
        public string stringLoopReciever0(string input)
        {
            return stringForLoop0 = input;
        }

        private void Output_Load(object sender, EventArgs e)
        {            
            richTextBox1.Text = stringForLoop0;
        }        
    }
}
