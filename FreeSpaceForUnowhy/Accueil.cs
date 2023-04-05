using System;
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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/channel/UCLfboIvl8VrNM3n6D9_QdZg";
            Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/FGAMER768/FreeSpaceUnowhy";
            Process.Start(url);
        }
    }
}
