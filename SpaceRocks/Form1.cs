using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceRocks
{
    public partial class Form1 : Form
    {

        int shipx = 220;
        int shipy = 260;
        int shipangle = 180;
        int shipheight = 50;
        int shipwidth = 50;

        int shipspeed = 6;

        bool wDown = false;
        bool sDown = false;
        
        bool aDown = false;
        bool dDown = false;
        
        Pen mypen = new Pen(Color.White);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;

            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
               
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wDown == true && shipy > 0)
            {
                shipy -= shipspeed;
            }

            if (sDown == true && shipy < this.Height - shipheight)
            {
                shipy += shipspeed;
            }
            Refresh();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawPie(mypen, shipx, shipy, 50, 50, shipangle, 45);
        }
    }
}
