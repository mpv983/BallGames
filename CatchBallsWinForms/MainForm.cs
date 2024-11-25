using BallGames.Common;

namespace CatchBallsWinForms
{
    public partial class MainForm : Form
    {
        RandomSizeAndDirectionMoveBallFromPoint moveBall;
        List<Ball> moveBalls = new List<Ball>();
        private int countCatches = 0;
        private int countBalls = 8;
        System.Windows.Forms.Timer globalTimer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void GameStart()
        {
            var pr = new PalletsRepository();
            var currentPallete = pr.GetRandom();
            var centerPoint = new Point(ClientSize.Width/2, ClientSize.Height/2);
            for (int i = 0; i < countBalls; i++)
            {
                var moveBall = new RandomSizeAndDirectionMoveBallFromPoint(this, centerPoint);
                moveBall.SetTimerInterval(34);
                moveBall.SetRandomRadius(20, 60);
                moveBall.DirectionRandomDiapasone = 5;
                moveBall.Color = BallBrushes.GetRandomFromPallete(currentPallete);
                moveBall.Brush = new SolidBrush(moveBall.Color);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
            ballsLabel.Text = $"{countCatches} / {countBalls}";
            startButton.Hide();
            GlobalTimerStart();
        }

        private void GlobalTimerStart()
        {
            globalTimer = new System.Windows.Forms.Timer();
            globalTimer.Interval = 1000;
            globalTimer.Tick += GlobalTimer_Tick;
            globalTimer.Start();
        }

        private void GlobalTimer_Tick(object? sender, EventArgs e)
        {
            if (BallsOutOfSpace())
            {
                globalTimer.Stop();
                ShowResult();
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            StopAll();
            var itemsToRemove = new List<Ball>();
            foreach (var moveBall in moveBalls)
            {
                if (moveBall.IsPointInside(e.Location))
                {
                    countCatches++;
                    ballsLabel.Text = $"{countCatches} / {countBalls}";
                    moveBall.Clear();
                    var ballBurst = new BallBurst(this, moveBall);
                    ballBurst.Burst();
                    itemsToRemove.Add(moveBall);
                    break;
                }
            }
            moveBalls = moveBalls.Except(itemsToRemove).ToList();
            StartAll();
            if (IsAllCatched())
            {
                globalTimer.Stop();
                ShowResult();
            }
        }

        private void ShowResult()
        {
            MessageBox.Show("Поймано шариков: " + countCatches);
            startButton.Visible = true;
            ballsLabel.Text = "0 / 0";
            countCatches = 0;
        }

        private bool IsAllCatched()
        {
            return moveBalls.Count == 0;
        }

        private bool BallsOutOfSpace()
        {
            var count = 0;
            foreach (var ball in moveBalls)
            {
                if (ball.Rectangle.Bottom <= 0)
                {
                    count++;
                    continue;
                }
                if (ball.Rectangle.Top >= ClientSize.Height)
                {
                    count++;
                    continue;
                }
                if (ball.Rectangle.Right <= 0)
                {
                    count++;
                    continue;
                }
                if (ball.Rectangle.Left >= ClientSize.Width)
                {
                    count++;
                    continue;
                }
            }
            return count == moveBalls.Count;
        }

        private void StopAll()
        {
            foreach (var item in moveBalls)
            {
                item.Stop();
            }
        }
        private void StartAll()
        {
            foreach (var item in moveBalls)
            {
                item.Start();
            }
        }
    }
}
