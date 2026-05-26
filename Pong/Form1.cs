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

        clsBall mobjBall;

        //ball values
        int mintCoordinatesX, mintCoordinatesY, mintMoveX, mintMoveY, cnSize = 20;

        //Constructor
        public Form1() {
            InitializeComponent();
        }

        //load form
        private void pbCanvas_Click(object sender, EventArgs e) {
            mobjGraphics = pbCanvas.CreateGraphics();

            //create ball
            mobjBall = new clsBall();

            //start timer
            tmrRender.Interval = 1000/fps;
            //tmrRender.Interval = 100;
            tmrRender.Enabled = true;
            mintCoordinatesX = mintCoordinatesY = 100;
            mintMoveX = mintMoveY = 10;
        }
        private void tmrRender_Tick(object sender, EventArgs e) {
            //render ball
            mobjBall.Render();
            
            //delete ball
            mobjGraphics.FillEllipse(Brushes.White, mintCoordinatesX, mintCoordinatesY, cnSize, cnSize);

            //move ball
            mintCoordinatesX += mintMoveX; mintCoordinatesY += mintMoveY;

            //bounce
            if ((mintCoordinatesY > pbCanvas.Height - cnSize) || (mintCoordinatesY < 0)) {
                mintMoveY = mintMoveY * -1; 
            }
            if ((mintCoordinatesX > pbCanvas.Width - cnSize) || (mintCoordinatesX < 0)) {
                mintMoveX = mintMoveX * -1; 
            }
            //draw ball
            mobjGraphics.FillEllipse(Brushes.Blue, mintCoordinatesX, mintCoordinatesY, cnSize, cnSize);
        }
    }
}
