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
        const int fps = 60;


        //Constructor
        public Form1() {
            InitializeComponent();
        }

        //load form
        private void pbCanvas_Click(object sender, EventArgs e) {
            mobjGraphics = pbCanvas.CreateGraphics();

            //start timer
            tmrRender.Interval = Math.Pow(fps, -1)*1000;
            tmrRender.Enabled = true;
        }

        private void tmrRender_Tick(object sender, EventArgs e) {
            //draw ball
            mobjGraphics.FillEllipse(Brushes.Blue, 100, 100, 20, 20);
        }
    }
}
