using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cryptology_Project.Main_Page;

namespace Cryptology_Project
{
    public partial class Linear_Cipher : Form
    {
        public Linear_Cipher()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }

        private void linear_enc_button_Click(object sender, EventArgs e)
        {
            string input_text = textBox_linear_text.Text.ToLower();
            string plaintext = textBox_linear_text.Text.ToLower().Replace(" ", "");
            string encryptedText = "";

            // girilen sayının text olup olmadığnı kontrol et eğer sayıysa a ya ata
            if (!int.TryParse(textBox_key1.Text, out int a) || !int.TryParse(textBox_key2.Text, out int b))
            {
                MessageBox.Show("Please enter an integer key");
                return;
            }


            foreach (char c in plaintext)
            {
                if (!Globals.AlphabetToIndex.ContainsKey(c)) continue;

                int x = Globals.AlphabetToIndex[c];
                int encryptedIndex = (a * x + b) % Globals.AlphabetLength;
                encryptedText += Globals.IndexToAlphabet[encryptedIndex];
            }

            textBox_shift_enc.Text = encryptedText;
        }
    }
}
