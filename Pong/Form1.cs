using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pong {
    public partial class Form1 : Form {
        Graphics mobjGraphics;
        const int fps = 600;
        const int cnBalloonCount = 5;
        clsBall mobjBall;
        clsBalloon[] mobjBalloon;



        //Constructor
        public Form1() {
            InitializeComponent();
        }

        //load form
        private void pbCanvas_Click(object sender, EventArgs e) {
            mobjGraphics = pbCanvas.CreateGraphics();

            //create ball
            mobjBall = new clsBall(mobjGraphics, 100, 100);

            //create balloons
            mobjBalloon = new clsBalloon[cnBalloonCount];


            int lintX, lintY;
            lintX = lintY = 10;

            for (int i = 0; i < cnBalloonCount; i++)
            {
                mobjBalloon[i] = new clsBalloon(mobjGraphics, 10, 10);
                //move X
                lintX = lintX + 60;
                //line overflow protection
                if (lintX + 60 > pbCanvas.Width) {
                    lintX = 10;
                    lintY = lintY + 60;
                }

            }
            //start timer
            tmrRender.Interval = 1000 / fps;
            //tmrRender.Interval = 100;
            tmrRender.Enabled = true;
        }
        private void tmrRender_Tick(object sender, EventArgs e) {
            //render balls
            mobjBall.Render();

            for (int i = 0; i < cnBalloonCount; i++)
            {
                mobjBalloon[i].Render();
            }
        }
    } 
}
