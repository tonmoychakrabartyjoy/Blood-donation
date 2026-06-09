namespace blood_donation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 ac = new Form2();

            ac.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string number = textBox2.Text;
            string pass = textBox3.Text;

            if (name == "tonmoy" && number == "01552987308" && pass == "1234")
            {
                HomePage ab = new HomePage();
                ab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
