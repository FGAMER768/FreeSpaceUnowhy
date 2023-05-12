using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace FreeSpaceForUnowhy
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeftRect,
             int nTopRect,
             int RightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse

            )
            ;

        public Form1()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Progressbar1.Value = 0;

            


        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progressbar1.Value += 1;
            Progressbar1.Text = Progressbar1.Value.ToString() +"%";

            if (Progressbar1.Value == 100)
            {
                timer1.Enabled = false;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }  
        

        private void timer3_Tick(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("Loading_Sound_1.wav");

            player.Play();

            timer2.Stop();
        }
    }


}

