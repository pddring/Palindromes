using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromes
{
    public partial class Palindrome : Form
    {
        public Palindrome()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // read text from text box to check if it's a palidrome
            string input = txtInput.Text;
            
            // assume the text is a palindrome until proven otherwise
            bool palindrome = true;
            
            // iterate through each letter up to half way through the text
            for(int i = 0; i < input.Length / 2; i++)
            {
                // check pairs of letters
                if(input[i] != input[input.Length - 1 - i])
                {
                    // stop as soon as we find a pair of letters that doesn't match
                    palindrome = false;
                    break;
                }
            }
            
            // display output
            if(palindrome)
            {
                lblOutput.Text = input + " is a palindrome";
                lblOutput.ForeColor = Color.Green;
            } else
            {
                lblOutput.Text = input + " is not a palindrome";
                lblOutput.ForeColor = Color.Red;
            }
        }
    }
}
