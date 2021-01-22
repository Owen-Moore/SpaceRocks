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
        int shipspeed = 6;
        int shipHBX = 217;
        int shipHBY = 280;
        int shipHBW = 25;
        int shipHBH = 20;

        List<int> rockSizeList = new List<int>();
        List<int> rockYList = new List<int>();
        List<int> rockXList = new List<int>();
        List<int> rockXSpeedList = new List<int>();
        List<int> rockYSpeedList = new List<int>();
        Random randGen = new Random();
        int randValue = 0;

        int counter = 1;
        int wave = 1;
        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
       
        SolidBrush blackBrush = new SolidBrush(Color.Black);
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

            randValue = randGen.Next(0, 1000);

            if (randValue < 10)
            {
                rockSizeList.Add(80);
                rockXList.Add(randGen.Next(1, 2400));
                rockYList.Add(randGen.Next(1, 601));
                rockXSpeedList.Add(randGen.Next(4, 6));
                rockYSpeedList.Add(randGen.Next(4, 6));
            }
            else if (randValue > 990)
            {
                rockSizeList.Add(40);
                rockXList.Add(randGen.Next(1, 2400));
                rockYList.Add(randGen.Next(1, 601));
                rockXSpeedList.Add(randGen.Next(4, 10));
                rockYSpeedList.Add(randGen.Next(4, 6));
            }

            for (int i = 0; i < rockXList.Count(); i++)
            {
                rockXList[i] += rockXSpeedList[i];
                
            }
            for (int i = 0; i < rockYList.Count(); i++)
            {
                rockYList[i] += rockYSpeedList[i];
                
            }
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

            for (int i = 0; i < rockYList.Count(); i++)
            {
                if (rockYList[i] > this.Height - rockSizeList[i] || rockYList[i] < 0)
                {
                    rockYSpeedList[i] *= -1;
                }
                if (rockXList[i] > this.Width - rockSizeList[i]|| rockXList[i] < 0)
                {
                    rockXSpeedList[i] *= -1;
                }
            }
            for (int i = 0; i < rockXList.Count(); i++)
            {
                Rectangle RockRec = new Rectangle(rockXList[i], rockYList[i], rockSizeList[i], rockSizeList[i]);
                Rectangle shipHB = new Rectangle(shipHBX, shipHBY, shipHBW, shipHBH);

                if (shipHB.IntersectsWith(RockRec))
                {
                    this.BackColor = Color.White;
                    youloseText.ForeColor = Color.Black;
                    youloseText.Text = $"YOU LOSE";
                }
                else
                {
                    youloseText.Text = $"Space Rocks (entirely different than asteroids)";
                }

            }
        
            counter++;
            //youloseText.ForeColor = Color.White;
            //youloseText.Text = $"Wave {Convert.ToString(wave)} {Convert.ToString(counter)}";
            Refresh();
        }
       
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            // e.Graphics.DrawRectangle(testpen, 217, 280, 25, 20);
            e.Graphics.DrawPie(mypen, shipx, shipy, 50, 50, shipangle, 45);
            e.Graphics.DrawString("You lose", Font, blackBrush, shipx, shipy);
            for (int i = 0; i < rockXList.Count(); i++)
            {
                if (randValue > 1)
                {
                    e.Graphics.DrawEllipse(mypen, rockXList[i], rockYList[i], rockSizeList[i], rockSizeList[i]);
                }
                else if (randValue < 0)
                {
                    e.Graphics.DrawEllipse(mypen, rockXList[i], rockYList[i], rockSizeList[i], rockSizeList[i]);
                }
             
            }

        }

        

        }
    }

