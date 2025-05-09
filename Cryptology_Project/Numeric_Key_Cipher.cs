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
    public partial class Numeric_Key_Cipher : Form
    {
        public Numeric_Key_Cipher()
        {
            InitializeComponent();
        }
        private void button_enc_Click(object sender, EventArgs e)
        {
            string plainText = textBox_numeric_text.Text.Replace(" ", "").ToLower();

            if (!int.TryParse(textBox_numeric_key.Text, out int columnCount) || columnCount <= 0)
            {
                MessageBox.Show("Please enter valid key number.");
                return;
            }

            // Metni X ile doldur
            int rowCount = (int)Math.Ceiling((double)plainText.Length / columnCount);
            int paddedLength = rowCount * columnCount;
            plainText = plainText.PadRight(paddedLength, 'X');

            // Matrise yerleştir
            char[,] matrix = new char[rowCount, columnCount];
            int index = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = plainText[index++];
                }
            }

            // Sütun sütun şifreli metni oluştur
            string cipherText = "";
            for (int col = 0; col < columnCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    cipherText += matrix[row, col];
                }
            }

            numeric_enc_textBox.Text = cipherText;
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }
    }
}
