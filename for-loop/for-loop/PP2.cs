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
    public partial class PP2 : Form
    {

        for_loop classMethod = new for_loop();
        public PP2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = classMethod.pingPong0(textBox1.Text);
            richTextBox1.Text = "\n" + result;
        }
    }
}
