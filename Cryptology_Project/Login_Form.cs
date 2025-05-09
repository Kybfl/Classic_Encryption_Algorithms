using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cryptology_Project
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private bool Authenticate_User(string usernm, string psw) {

            string file = "Accounts.txt";


            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        string fileUsername = parts[0].Trim();
                        string filePassword = parts[1].Trim();

                        if (fileUsername == usernm && filePassword == psw)
                        {
                            return true;
                        }
                    }
                }
            } 
            else
            {
                MessageBox.Show("Kullanýcý dosyasý bulunamadý.");
            }

            return false;

        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Login(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            if (Authenticate_User(username, password))
            {
               Main_Page main = new Main_Page();
               main.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Wron Username Or Password");

            }
        }
    }
}
