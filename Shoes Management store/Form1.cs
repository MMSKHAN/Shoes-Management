namespace Shoes_Management_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invantory home = new Invantory();
            home.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer home = new Customer();
            home.TopLevel = false;
            panel2.Controls.Clear();
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            panel2.Controls.Add(home);
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sales home = new Sales();
            home.TopLevel = false;
          //  WindowState = FormWindowState.Maximized;
            panel2.Controls.Clear();
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            panel2.Controls.Add(home);
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report home = new Report();
            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(home);
            home.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
