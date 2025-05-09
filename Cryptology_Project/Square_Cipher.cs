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
    public partial class Square_Cipher : Form
    {
        public Square_Cipher()
        {
            InitializeComponent();
        }

        private List<char> key1 = new List<char>();
        private List<char> key2 = new List<char>();

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Page main = new Main_Page();
            main.Show();
        }

        private void square_enc_button_Click(object sender, EventArgs e)
        {
            // 1. Türk alfabesi sabit sırayla tanımlanmalı
            string alphabet = "abcçdefgğhıijklmnoöprsştuüvyzx";

            // 2. Girişleri al
            string keyTR_input = string.Join("", listBox_rightup.Items.Cast<char>());
            string keyBL_input = string.Join("", listBox_leftdown.Items.Cast<char>());


            string input = textBox_squaretext.Text.ToLower().Replace(" ", "");
            int cols = int.Parse(textBox_key3.Text); // Sütun sayısı

            // 3. Anahtarları hazırla (tekrar edenleri alma, sadece alfabede olanları al)
            string Prepare(string key) =>
                new string((key + alphabet)
                .Where(c => alphabet.Contains(c))
                .Distinct()
                .Take(30)
                .ToArray());

            string keyTR = Prepare(keyTR_input);  // Sağ Üst kare
            string keyBL = Prepare(keyBL_input);  // Sol Alt kare

            // 4. Kare oluşturucu
            char[,] MakeGrid(string text)
            {
                int rows = 5;
                char[,] grid = new char[rows, cols];
                for (int i = 0; i < rows * cols; i++)
                    grid[i / cols, i % cols] = text[i];
                return grid;
            }

            // 5. Harf bulucu
            (int, int) Find(char[,] grid, char c)
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                    for (int j = 0; j < grid.GetLength(1); j++)
                        if (grid[i, j] == c)
                            return (i, j);
                return (-1, -1);
            }

            // 6. Kareleri oluştur
            char[,] TL = MakeGrid(alphabet);  // Sol Üst
            char[,] TR = MakeGrid(keyTR);     // Sağ Üst
            char[,] BL = MakeGrid(keyBL);     // Sol Alt
            char[,] BR = MakeGrid(alphabet);  // Sağ Alt

            // 7. Giriş metnini çift harfli hale getir
            if (input.Length % 2 != 0)
                input += "x";

            string result = "";

            // 8. Her iki harfli grup için şifreleme
            for (int i = 0; i < input.Length; i += 2)
            {
                char a = input[i];         // TL'den alınacak harf
                char b = input[i + 1];     // BR'den alınacak harf

                var (r1, c1) = Find(TL, a);  // TL'de bul
                var (r2, c2) = Find(BR, b);  // BR'de bul

                char ciph1 = TR[r1, c2];     // Sağ Üst
                char ciph2 = BL[r2, c1];     // Sol Alt

                result += ciph1.ToString() + ciph2.ToString();
            }

            // 9. Sonucu yaz
            square_textBox.Text = result;
        }

        private void button_createkeys_Click(object sender, EventArgs e)
        {
            string alphabet = new string(Globals.AlphabetToIndex.Keys.ToArray());
            string Shuffle(string input)
            {
                Random rand = new Random();
                return new string(input.OrderBy(c => rand.Next()).ToArray());
            }

            //Rastgele ve farklı iki alfabe 
            string rightUpKey, leftDownKey;

            do
            {
                rightUpKey = Shuffle(alphabet);
                leftDownKey = Shuffle(alphabet);
            } while (rightUpKey == leftDownKey);

            listBox_rightup.Items.Clear();
            listBox_leftdown.Items.Clear();

            foreach (char c in rightUpKey)
                listBox_rightup.Items.Add(c);

            foreach (char c in leftDownKey)
                listBox_leftdown.Items.Add(c);
        }
    }
}
