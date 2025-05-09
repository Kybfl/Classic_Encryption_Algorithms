using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology_Project
{
    public partial class Permutation_Cipher : Form
    {
        public Permutation_Cipher()
        {
            InitializeComponent();
        }

        int[] permutationKey;


        private void button_enc_Click(object sender, EventArgs e)
        {
            string inputText = textBox_permutation_text.Text;
            string plainText = inputText.ToLower().Replace(" ", "");

            // Anahtarı textbox_permutation_key2'den al
            try
            {
                permutationKey = textbox_permutation_key2.Text
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s.Trim()))
                    .ToArray();
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }

            int blockSize = permutationKey.Length;

            // Düz metni X karakteriyle padleyerek tam bloklara bölünebilir hale getir
            int paddingLength = blockSize - (plainText.Length % blockSize);
            if (paddingLength != blockSize) // Eğer tam bölünüyorsa ekleme
            {
                plainText = plainText.PadRight(plainText.Length + paddingLength, 'x');
            }

            char[] encrypted = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i += blockSize)
            {
                for (int j = 0; j < blockSize; j++)
                {
                    encrypted[i + j] = plainText[i + permutationKey[j]];
                }
            }

            textBox_transposition_enc.Text = new string(encrypted);
        }

    

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }
    }
}

