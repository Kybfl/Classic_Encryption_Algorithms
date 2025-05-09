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
    public partial class Vigenere_Cipher : Form
    {
        public Vigenere_Cipher()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }

        private void vigenre_enc_button_Click(object sender, EventArgs e)
        {
            string input = textBox_vigeneretext.Text.ToLower(); // orijinal metin
            string plaintext = input.Replace(" ", "");           // boşluksuz
            string input_key = textBox_vigenere_key.Text.ToLower().Replace(" ", ""); // anahtar boşluksuz
            string key = input_key;
            string ciphertext = "";

            // Anahtarı metin uzunluğuna kadar uzat
            while (key.Length < plaintext.Length)
            {
                key += input_key;
            }
            key = key.Substring(0, plaintext.Length); // Fazlalığı kırp

            for (int i = 0; i < plaintext.Length; i++)
            {
                char plainChar = plaintext[i];

                if (Globals.AlphabetToIndex.ContainsKey(plainChar))
                {
                    int plainIndex = Globals.AlphabetToIndex[plainChar];
                    int keyIndex = Globals.AlphabetToIndex[key[i]];
                    int cipherIndex = (plainIndex + keyIndex) % Globals.AlphabetLength;

                    ciphertext += Globals.IndexToAlphabet[cipherIndex];
                }
                else
                {
                    // Harf değilse doğrudan ekle
                    ciphertext += plainChar;
                }
            }

            vigenere_textBox.Text = ciphertext;
        }

    }
}

