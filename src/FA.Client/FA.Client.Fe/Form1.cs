namespace FA.Client.Fe
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;

            // Validiraj username
            // Validiraj passowrd

            // Iskomuniciraj sa bazom i kreiraj korisnika

            MessageBox.Show("Uspesno kreiran korisnik");
        }
    }
}
