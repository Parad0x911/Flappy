using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Properties.Resources.Aim);
            Cursor crsr = new Cursor(bmp.GetHicon());
            this.Cursor = crsr;
        }

        //Pour les tuers et ajouter au score
        int kill;

        //Pour faire voler les oiseaux
        void Birds()
        {
            if(P_1.Left<0)
            {
                P_1.Left = 650;
                P_1.Image = Properties.Resources.Bird__1_;
            }
            if(P_2.Left<0)
            {
                P_2.Left = 650;
                P_2.Image = Properties.Resources.Bird__1_;
            }
            if(P_3.Left<0)
            {
                P_3.Left = 650;
                P_3.Image = Properties.Resources.Bird__1_;
            }
            P_1.Left -= 5;
            P_2.Left -= 5;
            P_3.Left -= 5;
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Piaf1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kill++;
            label1.Text = "Killed : " + kill;
            P_1.Image = Properties.Resources.Hit;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Birds();
        }

        //Ne marche pas
        private void P_1_Click(object sender, EventArgs e)
        {
            kill++;
            label1.Text = "Killed : " + kill;
            P_1.Image = Properties.Resources.Hit;

        }

        //Piaf2
        private void P_2_Click(object sender, EventArgs e)
        {
            kill++;
            label1.Text = "Killed : " + kill;
            P_2.Image = Properties.Resources.Hit;
        }

        //Piaf3
        private void P_3_Click(object sender, EventArgs e)
        {
            kill++;
            label1.Text = "Killed : " + kill;
            P_3.Image = Properties.Resources.Hit;
        }
    }
}
