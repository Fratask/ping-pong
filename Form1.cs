using System;
using System.Drawing;
using System.Windows.Forms;

namespace ping_pong_app_solution {
    public partial class Form1 : Form {

        Point direction;
        public Form1() {
            InitializeComponent();
            direction = initDirection();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (e.Location.X > 150) {
                plate2.Location = new Point(e.X, e.Y);
            }

        }

        private void tickTimer_Tick(object sender, EventArgs e) {
            ball.Location = new Point(
                ball.Location.X + direction.X,
                ball.Location.Y + direction.Y
                );
            plate1.Location = new Point(plate1.Location.X, ball.Location.Y-18);
        }

        private Point initDirection() {
            int x = 0;
            int y = 0;
            while (x * x < y * y || (x==0 && y==0)) {
                int rndInt = new Random().Next(0, 9);
                if (rndInt % 2 == 0) {
                    if (rndInt >= 5) {
                        x = 1;
                        y = 1;
                    } else {
                        x = -1;
                        y = 1;
                    }
                } else {
                    if (rndInt >= 5) {
                        x = 1;
                        y = -1;
                    } else {
                        x = -1;
                        y = -1;
                    }
                }
            }
            return new Point(x, y);
        }
    }
}
