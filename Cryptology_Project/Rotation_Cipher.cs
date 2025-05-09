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
    public partial class Rotation_Cipher : Form
    {
        public Rotation_Cipher()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }

        private void button_enc_Click(object sender, EventArgs e)
        {
            string plainText = textBox_rotation_text.Text.Replace(" ", "").ToLower();

            if (!int.TryParse(textBox_rotation_key.Text, out int columnCount) || columnCount <= 0)
            {
                MessageBox.Show("Please enter a number that bigger than 0");
                return;
            }

            int rowCount = (int)Math.Ceiling((double)plainText.Length / columnCount);
            int totalLength = rowCount * columnCount;
            plainText = plainText.PadRight(totalLength, 'X');

            // Metni matrise satır satır yerleştir
            char[,] matrix = new char[rowCount, columnCount];
            int index = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = plainText[index++];
                }
            }

            // Spiral sıralama ilk sütunun en altından başla
            List<char> spiralChars = new List<char>();
            int top = 0, bottom = rowCount - 1, left = 0, right = columnCount - 1;

            while (top <= bottom && left <= right)
            {
                // İlk sütunun en altından yukarıya
                for (int i = bottom; i >= top; i--)
                    spiralChars.Add(matrix[i, left]);
                left++;

                // Üst satırda soldan sağa
                for (int j = left; j <= right; j++)
                    spiralChars.Add(matrix[top, j]);
                top++;

                if (top > bottom || left > right) break;

                // Sağ sütunda yukarıdan aşağıya
                for (int i = top; i <= bottom; i++)
                    spiralChars.Add(matrix[i, right]);
                right--;

                // Alt satırda sağdan sola
                for (int j = right; j >= left; j--)
                    spiralChars.Add(matrix[bottom, j]);
                bottom--;
            }

            rotation_enc_textBox.Text = new string(spiralChars.ToArray());
        }

    }
}
