using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random r;
        int punkty;
        public Form1()
        {

            InitializeComponent();
            r = new Random();
            punkty = 0;
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            MoveButton();
            punkty = 0;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton();
            punkty++;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
            timer1.Stop();
            timer1.Start();


            /*//Application.Exit();

            //szerokosc
            int windowWidth = Size.Width;
            //wysokosc
            int windowHeight = Size.Height;

            windowWidth -= button1.Width;
            windowHeight -= button1.Height;

            Random rnd = new Random();
            int RandomLeft = rnd.Next(windowWidth);

            int RandomTop = rnd.Next(windowHeight);

            Point topLeftCorner = new Point(RandomLeft, RandomTop);
            button1.Location = topLeftCorner;   
            */
        }



        private void MoveButton()
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
        }
    }
}