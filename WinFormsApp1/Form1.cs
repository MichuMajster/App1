namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            //Application.Exit();

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


        }
    }
}