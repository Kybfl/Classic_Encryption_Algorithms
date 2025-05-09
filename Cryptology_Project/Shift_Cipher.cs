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
    public partial class Shift_Cipher : Form
    {
        public Shift_Cipher()
        {
            InitializeComponent();
        }
        private void shift_enc_button_Click(object sender, EventArgs e)
        {
            string plaintext = textBox_shifttext.Text.ToLower();
            string input = textBox_shifttext.Text.ToLower().Replace(" ", "");
            if (!int.TryParse(textbox_shiftkey.Text, out int shift))
            {
                MessageBox.Show("Please enter number");
                return;
            }

            string encryptedText = "";
            foreach (char c in input)
            {
                if (!Globals.AlphabetToIndex.ContainsKey(c)) // alfabe dışı karakteri atla
                    MessageBox.Show("Please enter turkish characters");

                int index = Globals.AlphabetToIndex[c]; 
                int shiftedIndex = (index + shift) % Globals.AlphabetLength; 
                encryptedText += Globals.IndexToAlphabet[shiftedIndex]; 
            }

            shift_textBox.Text = encryptedText; 

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page main = new Main_Page();
            main.Show();
        }
    }
}
