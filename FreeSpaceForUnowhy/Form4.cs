﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace FreeSpaceForUnowhy
{
    public partial class Form4 : Form
    {
        

        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
 

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FGAMER768/FreeSpaceUnowhy");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/FGAMER768/FreeSpaceUnowhy/releases/latest";
            Process.Start(url);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("FreeSpaceUnowhy Version 8.1", "Version", MessageBoxButtons.OK);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FreeSpaceUnowhy Version 9.0", "Version", MessageBoxButtons.OK);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/FGAMER768/FreeSpaceUnowhy/releases/latest";
            Process.Start(url);
        }
    }
}
