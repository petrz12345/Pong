using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    internal class clsBall {
        Graphics mobjGraphics;

        public int mintCoordinatesX, mintCoordinatesY;
        int mintMoveX, mintMoveY;
        const int cnSize = 20;


        //constructor
        public clsBall(Graphics objGraphics, int intX,int intY) {

            mobjGraphics = objGraphics;

            mintCoordinatesX = mintCoordinatesY = 100;
            mintMoveX = mintMoveY = 10;

            mintCoordinatesX = intX;
            mintCoordinatesY = intY;

        }

        public void Render() {
            //delete ball
            mobjGraphics.FillEllipse(Brushes.White, mintCoordinatesX, mintCoordinatesY, cnSize, cnSize);

            //move ball
            mintCoordinatesX += mintMoveX; mintCoordinatesY += mintMoveY;

            //bounce
            if ((mintCoordinatesY > mobjGraphics.VisibleClipBounds.Height - cnSize) || (mintCoordinatesY < 0))
            {
                mintMoveY = mintMoveY * -1;
            }
            if ((mintCoordinatesX > mobjGraphics.VisibleClipBounds.Width - cnSize) || (mintCoordinatesX < 0))
            {
                mintMoveX = mintMoveX * -1;
            }
            //draw ball
            mobjGraphics.FillEllipse(Brushes.Blue, mintCoordinatesX, mintCoordinatesY, cnSize, cnSize);

        }



    }
}
