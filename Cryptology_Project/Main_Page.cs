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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        public static class Globals
        {

            public static readonly Dictionary<char, int> AlphabetToIndex = new Dictionary<char, int>
             {
             {'a', 0}, {'b', 1}, {'c', 2}, {'ç', 3}, {'d', 4}, {'e', 5}, {'f', 6}, {'g', 7},
             {'ğ', 8}, {'h', 9}, {'ı', 10}, {'i', 11}, {'j', 12}, {'k', 13}, {'l', 14}, {'m', 15},
             {'n', 16}, {'o', 17}, {'ö', 18}, {'p', 19}, {'r', 20}, {'s', 21}, {'ş', 22}, {'t', 23},
             {'u', 24}, {'ü', 25}, {'v', 26}, {'y', 27}, {'z', 28}
             };

            // İndexten harfe döndürme
            public static readonly Dictionary<int, char> IndexToAlphabet = AlphabetToIndex
                .ToDictionary(pair => pair.Value, pair => pair.Key);

            // Alfabe uzunluğu
            public static readonly int AlphabetLength = AlphabetToIndex.Count;
        }

        private void shift_button_Click(object sender, EventArgs e)
        {
            Shift_Cipher shift_Cipher = new Shift_Cipher();
            shift_Cipher.Show();
            this.Close();
        }

        private void linear_button_Click(object sender, EventArgs e)
        {
            Linear_Cipher linear_Cipher = new Linear_Cipher();
            linear_Cipher.Show();
            this.Close();
        }

        private void transposition_button_Click(object sender, EventArgs e)
        {
            Transposition_Cipher transposition_Cipher = new Transposition_Cipher();
            transposition_Cipher.Show();
            this.Close();
        }

        private void permutation_button_Click(object sender, EventArgs e)
        {
            Permutation_Cipher permutation_Cipher = new Permutation_Cipher();
            permutation_Cipher.Show();
            this.Close();
        }

        private void numerickey_button_Click(object sender, EventArgs e)
        {
            Numeric_Key_Cipher numeric_Key_Cipher = new Numeric_Key_Cipher();
            numeric_Key_Cipher.Show();
            this.Close();
        }

        private void rotation_button_Click(object sender, EventArgs e)
        {
            Rotation_Cipher rotation_Cipher = new Rotation_Cipher();
            rotation_Cipher.Show();
            this.Close();
        }

        private void railfence_button_Click(object sender, EventArgs e)
        {
            Rail_Fence_Cipher rail_Fence_Cipher = new Rail_Fence_Cipher();
            rail_Fence_Cipher.Show();
            this.Close();
        }

        private void vigenere_button_Click(object sender, EventArgs e)
        {
            Vigenere_Cipher vigenere_cipher = new Vigenere_Cipher();
            vigenere_cipher.Show();
            this.Close();
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            Square_Cipher square_Cipher = new Square_Cipher();
            square_Cipher.Show();
            this.Close();
        }


        private void hill_button_Click(object sender, EventArgs e)
        {
            Hill_Cipher hill_Cipher = new Hill_Cipher();
            hill_Cipher.Show();
            this.Close();
        }

        private void button_TR_Click(object sender, EventArgs e)
        {
            Main_Page_Label.Text = "Şifreleme Algoritmalarından Birini Seçiniz";
            shift_button.Text = "Kaydırmalı";
            linear_button.Text = "Doğrusal";
            transposition_button.Text = "Yer Değiştirme";
            permutation_button.Text = "Permütasyon";
            numerickey_button.Text = "Sayı Anahtarlı";
            rotation_button.Text = "Rota";
            railfence_button.Text = "Zigzag";
            vigenere_button.Text = "Vigenere";
            square_button.Text = "4 Kare";
            hill_button.Text = "Hill";
        }

        private void button_EN_Click(object sender, EventArgs e)
        {
            Main_Page_Label.Text = "Choose One Of The Encryption Algorithms Below";
            shift_button.Text = "Shift";
            linear_button.Text = "Linear";
            transposition_button.Text = "Transposition";
            permutation_button.Text = "Permutation";
            numerickey_button.Text = "Numeric Key";
            rotation_button.Text = "Rotation";
            railfence_button.Text = "Rail Fence";
            vigenere_button.Text = "Vigenere";
            square_button.Text = "4 Square";
            hill_button.Text = "Hill";
        }
    }
}
