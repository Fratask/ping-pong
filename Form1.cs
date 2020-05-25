using System;
using System.Drawing;
using System.Windows.Forms;

namespace ping_pong_app_solution {
    public partial class Form1 : Form {

        Point direction;
        public Form1() {
            InitializeComponent();
            direction = initDirection();
            ball.Location = new Point(150, new Random().Next(30, 200));
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

            if (ball.Location.Y < 20 || ball.Location.Y > 200) {
                direction = new Point(direction.X, direction.Y * -1);
            }
            if (ball.Location.X < 0) {
                score2.Text =  (int.Parse(score2.Text)+1).ToString();
                resetBallPosition();
            } else if (ball.Location.X > 290) {
                score1.Text = (int.Parse(score1.Text) + 1).ToString();
                resetBallPosition();
            }

            if (plate1.Bounds.IntersectsWith(ball.Bounds) && direction.X < 0) {
                direction = new Point(direction.X * -1, direction.Y);
            }
            if (plate2.Bounds.IntersectsWith(ball.Bounds) && direction.X > 0) {
                direction = new Point(direction.X * -1, direction.Y);
            }
        }

        private void resetBallPosition() {
            ball.Location = new Point(150, new Random().Next(30, 200));
            direction = initDirection();
        }

        private Point initDirection() {
            int x = 1;
            int y = 1;
            int rndInt = new Random().Next(0, 3);
            switch (rndInt) {
                case 0: 
                    x = -1;
                    y = -1;
                    break;
                case 1:
                    x = -1;
                    y = 1;
                    break;
                case 2:
                    x = 1;
                    y = -1;
                    break;
                case 3:
                    x = 1;
                    y = 1;
                    break;
                default:
                    x = 1;
                    y = 1;
                    break;
            }
            return new Point(x, y);
        }

        private void plate2_MouseMove(object sender, MouseEventArgs e) {
                plate2.Location = new Point(e.X, e.Y);
        }
    }
}
