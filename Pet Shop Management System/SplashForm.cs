namespace Pet_Shop_Management_System
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            guna2ProgressBar1.Value = startPoint;
            if (guna2ProgressBar1.Value == 100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Hide();

            }
        }

        private void Splashform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
