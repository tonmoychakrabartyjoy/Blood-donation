namespace blood_donation
{
    public partial class Form1 : Form
    {
        public Form1()
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

            if(name == "tonmoy" && number == "01552987308" && pass == "1234")
            {
                Form3 ab = new Form3();
                ab.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
