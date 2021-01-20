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
        int shipangle = 150;
        int shipheight = 50;
        int shipwidth = 50;
        int shipspeed = 6;
        int shipHBX = 217;
        int shipHBY = 280;
        int shipHBW = 25;
        int shipHBH = 20;

        int spacerockX = 25;
        int spacerockY = 25;
        int spacerockW = 80;
        int spacerockH = 80;

        int rockXSpeed = 5;
        int rockYSpeed = -5;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        Pen testpen = new Pen(Color.Red);
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
            spacerockX += rockXSpeed;
            spacerockY += rockYSpeed;

            if (wDown == true && shipy > 0)
            {
                shipy -= shipspeed;
                shipHBY -= shipspeed;
            }

            if (sDown == true && shipy < this.Height - shipheight)
            {
                shipy += shipspeed;
                shipHBY += shipspeed;
            }
            if (aDown == true && shipx > 0)
            {
                shipx -= shipspeed;
                shipHBX -= shipspeed;
            }

            if (dDown == true && shipy < this.Width - shipheight)
            {
                shipx += shipspeed;
                shipHBX += shipspeed;
            }

            if (spacerockY < 0 || spacerockY > this.Height - spacerockH)
            {
                rockYSpeed *= -1;  
            }
            if (spacerockX < 0 || spacerockX > this.Width - spacerockW)
            {
                rockXSpeed *= -1;
            }
            Rectangle RockRec = new Rectangle(spacerockX, spacerockY, spacerockW, spacerockH);
            Rectangle shipHB = new Rectangle(shipHBX, shipHBY, shipHBW, shipHBH);
            if (shipHB.IntersectsWith(RockRec))
            {
                this.BackColor = Color.White;
                youloseText.Text = "YOU LOSE";
            }
            Refresh();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
           // e.Graphics.DrawRectangle(testpen, 217, 280, 25, 20);
            e.Graphics.DrawPie(mypen, shipx, shipy, 50, 50, shipangle, 45);
            e.Graphics.DrawEllipse(mypen, spacerockX, spacerockY, spacerockW, spacerockH);
        }
    }
}
