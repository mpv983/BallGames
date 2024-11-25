using BallGames.Common;

namespace DiffusionWinForms
{
    public partial class MainForm : Form
    {
        private List<Ball> balls = new List<Ball>();
        private int quantyty = 10;

        private Color colorLeft = Color.DarkOrange;
        private Color colorRight = Color.DarkMagenta;

        private int countLeftSide_ball_1;
        private int countLeftSide_ball_2;

        private DrawLine drawLine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            leftLabel_1.ForeColor = colorLeft;
            leftLabel_2.ForeColor = colorRight;
            topLabel_1.ForeColor = colorLeft;
            topLabel_2.ForeColor = colorRight;
            rightLabel_1.ForeColor = colorLeft;
            rightLabel_2.ForeColor = colorRight;
            downLabel_1.ForeColor = colorLeft;
            downLabel_2.ForeColor = colorRight;

            countLeftLabel_ball1.ForeColor = colorLeft;
            countLeftLabel_ball2.ForeColor = colorRight;
            countRightLabel_ball1.ForeColor = colorLeft;
            countRightLabel_ball2.ForeColor = colorRight;

            for (int i = 0; i < quantyty; i++)
            {
                var radius = 10;
                var interval = 30;

                var leftBall = new DiffusionBall(this, Side.Left, colorLeft);
                leftBall.DirectionRandomDiapasone = 8;
                leftBall.SetTimerInterval(interval);
                leftBall.Radius = radius;
                balls.Add(leftBall);
                leftBall.OnHited += Ball_OnHited;
                leftBall.ChangeSide += Ball_ChangeSide;

                var rightBall = new DiffusionBall(this, Side.Right, colorRight);
                rightBall.DirectionRandomDiapasone = 8;
                rightBall.SetTimerInterval(interval);
                rightBall.Radius = radius;
                balls.Add(rightBall);
                rightBall.OnHited += Ball_OnHited;
                rightBall.ChangeSide += Ball_ChangeSide;
            }

            countLeftSide_ball_1 = quantyty;
            countLeftSide_ball_2 = 0;

            drawLine = new DrawLine(this);

            ShowCount();
        }

        private void Ball_ChangeSide(object? sender, ChangeSideEventArgs e)
        {
            if (e.Side == Side.Left && e.Color == colorLeft)
            {
                countLeftSide_ball_1++;
            }
            if (e.Side == Side.Left && e.Color == colorRight)
            {
                countLeftSide_ball_2++;
            }
            if (e.Side == Side.Right && e.Color == colorLeft)
            {
                countLeftSide_ball_1--;
            }
            if (e.Side == Side.Right && e.Color == colorRight)
            {
                countLeftSide_ball_2--;
            }

            ShowCount();

            if (EndGame_Half())
            {
                StartStop();
                MessageBox.Show("Произошло полное перемешивание!");
            }
        }

        private bool EndGame_Half()
        {
            return countLeftSide_ball_1 == quantyty / 2 && countLeftSide_ball_2 == quantyty / 2;
        }

        void ShowCount()
        {
            countLeftLabel_ball1.Text = countLeftSide_ball_1.ToString();
            countLeftLabel_ball2.Text = countLeftSide_ball_2.ToString();
            countRightLabel_ball1.Text = (quantyty - countLeftSide_ball_1).ToString();
            countRightLabel_ball2.Text = (quantyty - countLeftSide_ball_2).ToString();
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            if (e.Color == colorLeft)
                switch (e.Side)
                {
                    case Side.Left:
                        leftLabel_1.Text = (Convert.ToInt32(leftLabel_1.Text) + 1).ToString();
                        break;
                    case Side.Right:
                        rightLabel_1.Text = (Convert.ToInt32(rightLabel_1.Text) + 1).ToString();
                        break;
                    case Side.Top:
                        topLabel_1.Text = (Convert.ToInt32(topLabel_1.Text) + 1).ToString();
                        break;
                    case Side.Down:
                        downLabel_1.Text = (Convert.ToInt32(downLabel_1.Text) + 1).ToString();
                        break;
                }

            if (e.Color == colorRight)
                switch (e.Side)
                {
                    case Side.Left:
                        leftLabel_2.Text = (Convert.ToInt32(leftLabel_2.Text) + 1).ToString();
                        break;
                    case Side.Right:
                        rightLabel_2.Text = (Convert.ToInt32(rightLabel_2.Text) + 1).ToString();
                        break;
                    case Side.Top:
                        topLabel_2.Text = (Convert.ToInt32(topLabel_2.Text) + 1).ToString();
                        break;
                    case Side.Down:
                        downLabel_2.Text = (Convert.ToInt32(downLabel_2.Text) + 1).ToString();
                        break;
                }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!startButton.Enabled)
            {
                StartStop();
            }
        }

        private void StartStop()
        {
            foreach (var ball in balls)
            {
                if (ball.IsTimerEnabled())
                    ball.Stop();
                else
                    ball.Start();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DrawAll();
            drawLine.CenterLine();
        }

        private void DrawAll()
        {
            foreach (var ball in balls)
            {
                ball.Draw(ball.Brush);
            }
            startButton.Enabled = false;
        }
    }
}