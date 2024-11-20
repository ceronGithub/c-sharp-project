namespace for_loop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingPongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingPong1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingPong2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pingPong2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmingTestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmingTestToolStripMenuItem
            // 
            this.programmingTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingPongToolStripMenuItem,
            this.pingPong2ToolStripMenuItem});
            this.programmingTestToolStripMenuItem.Name = "programmingTestToolStripMenuItem";
            this.programmingTestToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.programmingTestToolStripMenuItem.Text = "Programming test";
            // 
            // pingPongToolStripMenuItem
            // 
            this.pingPongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingPong1ToolStripMenuItem,
            this.pingPong2ToolStripMenuItem1});
            this.pingPongToolStripMenuItem.Name = "pingPongToolStripMenuItem";
            this.pingPongToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pingPongToolStripMenuItem.Text = "Ping Pong";
            this.pingPongToolStripMenuItem.Click += new System.EventHandler(this.pingPongToolStripMenuItem_Click);
            // 
            // pingPong1ToolStripMenuItem
            // 
            this.pingPong1ToolStripMenuItem.Name = "pingPong1ToolStripMenuItem";
            this.pingPong1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pingPong1ToolStripMenuItem.Text = "Ping Pong 1";
            this.pingPong1ToolStripMenuItem.Click += new System.EventHandler(this.pingPong1ToolStripMenuItem_Click);
            // 
            // pingPong2ToolStripMenuItem1
            // 
            this.pingPong2ToolStripMenuItem1.Name = "pingPong2ToolStripMenuItem1";
            this.pingPong2ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.pingPong2ToolStripMenuItem1.Text = "Ping Pong 2";
            this.pingPong2ToolStripMenuItem1.Click += new System.EventHandler(this.pingPong2ToolStripMenuItem1_Click);
            // 
            // pingPong2ToolStripMenuItem
            // 
            this.pingPong2ToolStripMenuItem.Name = "pingPong2ToolStripMenuItem";
            this.pingPong2ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pingPong2ToolStripMenuItem.Text = "Development...";
            this.pingPong2ToolStripMenuItem.Click += new System.EventHandler(this.pingPong2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingPongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingPong2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingPong1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingPong2ToolStripMenuItem1;
    }
}

