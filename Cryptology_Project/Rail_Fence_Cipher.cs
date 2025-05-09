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
    public partial class Rail_Fence_Cipher : Form
    {
        public Rail_Fence_Cipher()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Page main = new Main_Page();
            main.Show();
        }

        private void rail_enc_button_Click(object sender, EventArgs e)
        {
            string input = textBox_railtext.Text.Replace(" ", "").ToLower();

            if (!int.TryParse(textbox_railkey.Text, out int key))
            {
                MessageBox.Show("Please enter a integer key");
                return;
            }

            // Rayların string dizisi
            string[] rails = new string[key];
            for (int i = 0; i < key; i++) rails[i] = "";

            int currentRail = 0;
            bool goingDown = true;

            // Zigzag yerleştirme
            foreach (char c in input)
            {
                rails[currentRail] += c;

                if (goingDown)
                {
                    currentRail++;
                    if (currentRail == key - 1) goingDown = false;
                }
                else
                {
                    currentRail--;
                    if (currentRail == 0) goingDown = true;
                }
            }

            // Rayları sırayla birleştir
            string cipherText = string.Join("", rails);
            rail_textBox.Text = cipherText;
        }
    }
}
