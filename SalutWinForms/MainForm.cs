using BallGames.Common;

namespace SalutWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(15, 51);
            var pr = new PalletsRepository();
            var pallete = pr.GetRandom();
            for (int i = 0; i < count; i++)
            {
                var ball = new SalutBallWithTrain(this, e.Location);
                ball.SetRandomRadius(2, 15);
                ball.Color = BallBrushes.GetRandomFromPallete(pallete);
                ball.Brush = new SolidBrush(ball.Color);
                ball.SetTimerInterval(15);
                ball.Start();
            }
        }
    }
}
