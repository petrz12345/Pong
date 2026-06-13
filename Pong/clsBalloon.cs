using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    internal class clsBalloon
    {
        Graphics mobjGraphics;

        int mintCoordinatesX, mintCoordinatesY, mintMoveX, mintMoveY;
        public const int cnSize = 50;
        bool mblVisible; 



        public clsBalloon(Graphics objGraphics, int intX, int intY)
        {

            mobjGraphics = objGraphics;

            mintCoordinatesX = mintCoordinatesY = 100;
            mintMoveX = mintMoveY = 10;

            mintCoordinatesX = intX;
            mintCoordinatesY = intY;
            mblVisible = true;

        }



        //Collision detection
        public void Collision(int intX, int intY, int intBallSize, int intBalloonSize)
        {
            int lintBallCenterX, lintBallCenterY, lintBalloonCenterX, lintBalloonCenterY;
            double ldblDistance, ldblRadiuses;

            //ball center
            lintBallCenterX = intX + intBallSize / 2;
            lintBallCenterY = intY + intBallSize / 2;

            //balloon center
            lintBalloonCenterX = mintCoordinatesX + intBalloonSize / 2;
            lintBalloonCenterY = mintCoordinatesY + intBalloonSize / 2;


            //add radiuses
            ldblRadiuses = intBallSize / 2 + cnSize / 2;

            //distance
            ldblDistance = Math.Sqrt(Math.Pow(lintBallCenterX - lintBalloonCenterX, 2) + Math.Pow(lintBallCenterY - lintBalloonCenterY, 2));


            if (ldblDistance < ldblRadiuses)
            {
                mblVisible = false;
            }
        }
            public void Render(int i) {

                if (mblVisible == true) {
                //draw balloon
                mobjGraphics.DrawEllipse(Pens.Red, mintCoordinatesX, mintCoordinatesY, cnSize, cnSize);

                }
                else
                {
                //delete balloon
                mobjGraphics.DrawEllipse(Pens.White, mintCoordinatesX, mintCoordinatesY, cnSize, cnSize);
                }


        
        }
    }
}
