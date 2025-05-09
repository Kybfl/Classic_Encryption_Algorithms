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
    public partial class Hill_Cipher : Form
    {
        public Hill_Cipher()
        {
            InitializeComponent();
        }

        private int[,] keyMatrix;
        private int rows, columns;

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Page main = new Main_Page();
            main.Show();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            rows = int.Parse(textbox_rowkey.Text);
            columns = int.Parse(textBox_columnkey.Text);
            string plainText = textBox_hilltext.Text.ToLower().Replace(" ", "");

            var elements = textBox_matris.Text.Split(',').Select(int.Parse).ToArray();

            if (elements.Length != rows * columns)
            {
                MessageBox.Show("Number of rows x columns does not match the size of the matrix");
                return;
            }

            keyMatrix = new int[rows, columns];
            int idx = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    keyMatrix[i, j] = elements[idx++];
                }
            }

            MessageBox.Show("Anahtar matrisi oluşturuldu!");
        }

        private void hill_enc_button_Click(object sender, EventArgs e)
        {
            if (keyMatrix == null)
            {
                MessageBox.Show("Please Create The Matrix First");
                return;
            }

            string plainText = textBox_hilltext.Text.ToLower();
            List<int> numericText = new List<int>();

            // Metni sayılara dönüştür
            foreach (char c in plainText)
            {
                if (Globals.AlphabetToIndex.ContainsKey(c))
                {
                    numericText.Add(Globals.AlphabetToIndex[c]);
                }
            }

            // Eğer tam bölünmüyorsa a harfi ekle
            while (numericText.Count % columns != 0)
            {
                numericText.Add(Globals.AlphabetToIndex['a']);
            }

            List<int> cipherNumbers = new List<int>();

            for (int i = 0; i < numericText.Count; i += columns)
            {
                int[] block = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    // numericText içinden blok blok elemanları alıyoruz
                    block[j] = numericText[i + j];
                }

                for (int r = 0; r < rows; r++)
                {
                    int sum = 0; // Her satır için toplama işlemi yapmak için tanımlandı
                    for (int c = 0; c < columns; c++)
                    {
                        // Satırın her elemanını bloktaki karşılık gelen elemanla çarp ve topla
                        sum += keyMatrix[r, c] * block[c];
                    }
                    sum %= Globals.AlphabetLength;

                    //  değeri şifreli sayı listesine eklw
                    cipherNumbers.Add(sum);
                }
            }

            string cipherText = "";
            foreach (var num in cipherNumbers)
            {
                cipherText += Globals.IndexToAlphabet[num];
            }

            hill_textBox.Text = cipherText;
        }

    }
}
