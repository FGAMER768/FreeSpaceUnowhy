using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSpaceForUnowhy
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            // Verrouiller le formulaire en grande fenêtre
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/doodles/gerald-jerry-lawsons-82nd-birthday");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form5FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mettre fin à l'application lorsque le formulaire se ferme
            Application.Exit();
        }
    }
}
