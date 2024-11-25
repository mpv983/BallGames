using BallGames.Common;

namespace BilliardWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                var ball = new BilliardBall(this);
                ball.DirectionRandomDiapasone = 8;
                ball.SetTimerInterval(20);
                ball.SetRandomRadius(20,20);
                ball.OnHited += Ball_OnHited;
                ball.Start();
            }
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: 
                    leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel.Text = (Convert.ToInt32(downLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}