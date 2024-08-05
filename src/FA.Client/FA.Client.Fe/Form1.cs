using FA.Client.Common.Contracts.Request.Users;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

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
            var client = new HttpClient();
            var content = JsonContent.Create(new UsersLoginRequest()
            {
                Username = textBox1.Text,
                Password = textBox2.Text
            });
            var result = client.PostAsync("http://192.168.0.27:8080/login", content)
                .GetAwaiter()
                .GetResult();

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                MessageBox.Show("Uspesno ste se ulogovali!");
            else if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                MessageBox.Show(result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            else
                MessageBox.Show("Unhandled server response: " + result.StatusCode);
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
