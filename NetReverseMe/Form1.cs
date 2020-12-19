using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetReverseMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Password Initialization
        //string secretWord = "aB91cD28";
        string secretWord = "YUJjRDEyMzQ=";

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //string inputWord = txt_Password.Text;
            string inputWord = Enc(txt_Password.Text);

            if (inputWord == "")
            {
                MessageBox.Show("Please enter your secret word");
                return;
            }
            else if (inputWord == secretWord)
            {
                MessageBox.Show("Secret word found!");
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Wrong! Try again!");
                txt_Password.Text = "";
                return;
            }


        }

        //Base64 Encoding
        static public string Enc(string toEnc)
        {
            byte[] toEncodeAsBytes
                  = System.Text.ASCIIEncoding.ASCII.GetBytes(toEnc);
            string returnValue
                  = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

    }
}
