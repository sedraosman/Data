namespace DairyFarmSystem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int start = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}