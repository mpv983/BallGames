using BallGames.Common;

namespace StopBallsWinForms
{
    public partial class MainForm : Form
    {
        RandomSizeAndDirectionMoveBallFromPoint moveBall;
        List<Ball> moveBalls = new List<Ball>();
        Button stopButton;
        public MainForm()
        {
            InitializeComponent();
        }

        private void RandomPointStopButton_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in moveBalls)
            {
                moveBall.Stop();
            }
            CalculateResult();
            foreach (var moveBall in moveBalls)
            {
                moveBall.Clear();
            }
            moveBalls.Clear();
            Controls.Remove(stopButton);
            startButton.Visible = true;
        }

        private void RandomPointStopButton()
        {
            var random = new Random();

            stopButton = new Button();
            stopButton.Height = 60;
            stopButton.Width = 80;
            var x = random.Next(0, ClientSize.Width - stopButton.Width);
            var y = random.Next(0, ClientSize.Height - stopButton.Height);
            stopButton.Click += RandomPointStopButton_Click;
            stopButton.Text = "Catch!";
            stopButton.Location = new Point(x, y);
            Controls.Add(stopButton);
        }

        private void CalculateResult()
        {
            var result = 0;
            foreach (var ball in moveBalls)
            {
                if (ball.OnForm())
                {
                    result++;
                }
            }

            MessageBox.Show($"Шариков поймано: {result}");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var centerPoint = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            for (int i = 0; i < 8; i++)
            {
                var moveBall = new RandomSizeAndDirectionMoveBallFromPoint(this, centerPoint);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
            startButton.Hide();
            RandomPointStopButton();
        }
    }
}
