using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using FreeSpaceUnowhy;

namespace FreeSpaceForUnowhy
{
    public partial class Form2 : Form
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90);
            path.AddLine(radius, 0, this.Width - radius, 0);
            path.AddArc(new Rectangle(this.Width - radius * 2, 0, radius * 2, radius * 2), -90, 90);
            path.AddLine(this.Width, radius, this.Width, this.Height - radius);
            path.AddArc(new Rectangle(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(this.Width - radius, this.Height, radius, this.Height);
            path.AddArc(new Rectangle(0, this.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();

            
            this.Region = new Region(path);
        }

        public Form2()
        {
            InitializeComponent();

            
            
            
            
            this.StartPosition = FormStartPosition.CenterScreen;
            

            pnlNav.Height = buttonFreeSpace.Height;
            pnlNav.Top = buttonFreeSpace.Top;
            pnlNav.Left = buttonFreeSpace.Left;
            buttonFreeSpace.BackColor = Color.FromArgb(46, 51, 73);

            pnlNav.Height = buttonAccueil.Height;
            pnlNav.Top = buttonAccueil.Top;
            pnlNav.Left = buttonAccueil.Left;
            buttonAccueil.BackColor = Color.FromArgb(46, 51, 73);

            pnlNav.Height = buttonParametres.Height;
            pnlNav.Top = buttonParametres.Top;
            pnlNav.Left = buttonParametres.Left;
            buttonParametres.BackColor = Color.FromArgb(46, 51, 73);

            pnlNav.Height = buttonInfos.Height;
            pnlNav.Top = buttonInfos.Top;
            pnlNav.Left = buttonInfos.Left;
            buttonInfos.BackColor = Color.FromArgb(46, 51, 73);

            pnlNav.Height = buttonLauncher.Height;
            pnlNav.Top = buttonLauncher.Top;
            pnlNav.Left = buttonLauncher.Left;
            buttonLauncher.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Accueil";
            this.PnlFormLoader.Controls.Clear();
            Accueil Accueil_Vrb = new Accueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();

            lblTitle.Text = "Paramètres";
            this.PnlFormLoader.Controls.Clear();
            Form4 Parametres_Vrb = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Parametres_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Parametres_Vrb);
            Parametres_Vrb.Show();

            lblTitle.Text = "Libérer de l'éspace";
            this.PnlFormLoader.Controls.Clear();
            Form3 FreeSpace_Vrb = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FreeSpace_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FreeSpace_Vrb);
            FreeSpace_Vrb.Show();

            lblTitle.Text = "Infos PC";
            this.PnlFormLoader.Controls.Clear();
            Form5 form5_Vrb = new Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(form5_Vrb);
            form5_Vrb.Show();

            lblTitle.Text = "Launcher";
            this.PnlFormLoader.Controls.Clear();
            Form6 form6_Vrb = new Form6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form6_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(form6_Vrb);
            form6_Vrb.Show();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string username = Environment.GetEnvironmentVariable("USERNAME");
            label1.Text = username;

            lblTitle.Text = "Accueil";
            this.PnlFormLoader.Controls.Clear();
            Accueil Accueil_Vrb = new Accueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();

            pnlNav.Height = buttonAccueil.Height;
            pnlNav.Top = buttonAccueil.Top;
            pnlNav.Left = buttonAccueil.Left;
            buttonAccueil.BackColor = Color.FromArgb(46, 51, 73);



            buttonInfos.BackColor = Color.FromArgb(24, 30, 54);


            buttonAccueil.BackColor = Color.FromArgb(24, 30, 54);


            buttonFreeSpace.BackColor = Color.FromArgb(24, 30, 54);


            buttonParametres.BackColor = Color.FromArgb(24, 30, 54);


            buttonLauncher.BackColor = Color.FromArgb(24, 30, 54);

            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFreeSpace_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonFreeSpace.Height;
            pnlNav.Top = buttonFreeSpace.Top;
            pnlNav.Left = buttonFreeSpace.Left;
            buttonFreeSpace.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Libérer de l'espace";
            this.PnlFormLoader.Controls.Clear();
            Form3 FreeSpace_Vrb = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FreeSpace_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FreeSpace_Vrb);
            FreeSpace_Vrb.Show();
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonAccueil.Height;
            pnlNav.Top = buttonAccueil.Top;
            pnlNav.Left = buttonAccueil.Left;
            buttonAccueil.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Accueil";
            this.PnlFormLoader.Controls.Clear();
            Accueil Accueil_Vrb = new Accueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();

        }

        private void buttonParametres_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonParametres.Height;
            pnlNav.Top = buttonParametres.Top;
            pnlNav.Left = buttonParametres.Left;
            buttonParametres.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Paramètres";
            this.PnlFormLoader.Controls.Clear();
            Form4 Parametres_Vrb = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Parametres_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Parametres_Vrb);
            Parametres_Vrb.Show();
        }

        private void buttonFreeSpace_Leave(object sender, EventArgs e)
        {
            buttonFreeSpace.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonAccueil_Leave(object sender, EventArgs e)
        {
            buttonAccueil.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonParametres_Leave(object sender, EventArgs e)
        {
            buttonParametres.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = buttonInfos.Height;
            pnlNav.Top = buttonInfos.Top;
            pnlNav.Left = buttonInfos.Left;
            buttonInfos.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Infos PC";
            this.PnlFormLoader.Controls.Clear();
            Form5 form5_Vrb = new Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(form5_Vrb);
            form5_Vrb.Show();
        }

        private void button1_Leave(object sender, EventArgs e)
        {

        }

        private void buttonInfos_Leave(object sender, EventArgs e)
        {
            buttonInfos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string url = "https://github.com/FGAMER768/FreeSpaceUnowhy";
            Process.Start(url);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(buttonPath);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/channel/UCLfboIvl8VrNM3n6D9_QdZg";
            Process.Start(url);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(buttonPath);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonLauncher.Height;
            pnlNav.Top = buttonLauncher.Top;
            pnlNav.Left = buttonLauncher.Left;
            buttonLauncher.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Launcher";
            this.PnlFormLoader.Controls.Clear();
            Form6 form6_Vrb = new Form6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form6_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(form6_Vrb);
            form6_Vrb.Show();
        }

        private void buttonLauncher_Leave(object sender, EventArgs e)
        {
            buttonLauncher.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/STY1001/Unowhy-Tools";
            Process.Start(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
