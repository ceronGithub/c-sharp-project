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
    public partial class Form1 : Form
    {

        // calls the for-loop.cs
        for_loop classMethod = new for_loop();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this is error (below), because the function is static
            // label1.Text = classMethod.for_loop_one();            
        }

        private void pingPongToolStripMenuItem_Click(object sender, EventArgs e)
        {
                       
        }

        private void pingPong2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pingPong1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PP p1 = new PP();
            p1.ShowDialog();
        }

        private void pingPong2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PP2 p2 = new PP2();
            p2.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
