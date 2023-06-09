﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Management;



namespace FreeSpaceForUnowhy
{
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{SystemInformation.ComputerName}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = $"{SystemInformation.UserName}";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor");

            
            ManagementObject obj = searcher.Get().Cast<ManagementObject>().FirstOrDefault();

           
            string cpuName = obj["Name"].ToString();

            
            label4.Text = $"{cpuName}";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = $"{((new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024) / 1024)} Mo Installées";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo("C");
            long availableSpace = drive.AvailableFreeSpace;
            long totalSpace = drive.TotalSize;
            label6.Text = $"Total : {FormatBytes(totalSpace)}, Libre: {FormatBytes(availableSpace)}";
        }

        public static string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 Bytes";
        }

        private void Form5FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
