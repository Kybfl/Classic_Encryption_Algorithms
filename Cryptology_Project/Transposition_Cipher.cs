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
    public partial class Transposition_Cipher : Form
    {
        public Transposition_Cipher()
        {
            InitializeComponent();
        }

        private void button_shuffle_Click(object sender, EventArgs e)
        {
            var originalAlphabet = Globals.AlphabetToIndex.Keys.ToList();
            var random = new Random();
            var shuffled = originalAlphabet.OrderBy(x => random.Next()).ToList();

            listBox_key.Items.Clear(); // Önce temizle

            for (int i = 0; i < shuffled.Count; i++)
            {
                listBox_key.Items.Add($"{i} : {shuffled[i]}");
            }
        }

        private void button_enc_Click(object sender, EventArgs e)
        {
            string input = textBox_transposition_text.Text.ToLower();
            string plainText = textBox_transposition_text.Text.ToLower().Replace(" ", "");
            // ListBox'tan karıştırılmış alfabeyi al
            List<char> shuffledAlphabet = new List<char>();

            foreach (var item in listBox_key.Items)
            {
                // Her satır "0 : x" şeklinde → split edip karakteri al
                string line = item.ToString();
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    char c = parts[1].Trim()[0];
                    shuffledAlphabet.Add(c);
                }
            }

            // Eşleme sözlüğü oluştur
            Dictionary<char, char> transpositionDict = new Dictionary<char, char>();
            var originalAlphabet = Globals.AlphabetToIndex.Keys.ToList();

            for (int i = 0; i < Globals.AlphabetLength; i++)
            {
                transpositionDict[originalAlphabet[i]] = shuffledAlphabet[i];
            }

            // Şifreleme işlemi
            string encryptedText = "";
            foreach (char c in plainText)
            {
                if (transpositionDict.ContainsKey(c))
                    encryptedText += transpositionDict[c];
                else
                    encryptedText += c; // harf değilse olduğu gibi bırak
            }

            textBox_transposition_enc.Text = encryptedText;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }
    }
}
