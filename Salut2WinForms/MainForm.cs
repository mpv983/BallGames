using System.Media;
using BallGames.Common;

namespace SalutWinForms
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer timer;
        SalutBallFromDownSide chargeBall;
        List<Ball> chargeBalls;

        public MainForm()
        {
            InitializeComponent();
            chargeBalls = new List<Ball>();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            CreateChargeBall();
        }

        private void CreateChargeBall()
        {
            chargeBall = new SalutBallFromDownSide(this, new Point(0, 0));
            chargeBalls.Add(chargeBall);
            chargeBall.SetRandomRadius(2, 3);
            chargeBall.Color = Color.WhiteSmoke;
            chargeBall.Brush = new SolidBrush(chargeBall.Color);
            chargeBall.SetTimerInterval(15);
            chargeBall.GetTopEvent += Ball_GetTop;
            chargeBall.Start();

            PlaySound(@"zvuk-vyistrela-salyuta.wav");
        }

        private void PlaySound(string path)
        {
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
        }

        private void Ball_GetTop(object? sender, GetTopEventArgs e)
        {
            Salut(e.Point);
            if (chargeBalls.Count != 0)
            {
                chargeBalls[0].Stop();
                chargeBalls[0].Clear();
                chargeBalls.RemoveAt(0);
            }
        }

        private void Salut(Point point)
        {
            PlaySound(@"zvuk-vzriva-salyuta.wav");

            var random = new Random();
            var count = random.Next(25, 51);
            var pr = new PalletsRepository();
            var pallete = pr.GetRandom();
            for (int i = 0; i < count; i++)
            {
                var ball = new SalutBall(this, point);
                ball.SetRandomRadius(2, 11);
                ball.Color = BallBrushes.GetRandomFromPallete(pallete);
                ball.Brush = new SolidBrush(ball.Color);
                ball.SetTimerInterval(15);
                ball.Start();
            }
        }
    }
}
