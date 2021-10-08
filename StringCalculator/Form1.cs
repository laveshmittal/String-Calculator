using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.concatStringClipboardLabel.Visible = false;

            if (this.string1TextBox.Text == "")
            {
                MessageBox.Show("String 1 input field is empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (this.string2TextBox.Text == "")
            {
                MessageBox.Show("String 2 input field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Storing concat string to result textbox
            this.resultTextBox.Text = this.string1TextBox.Text + this.string2TextBox.Text;
            

            //Copy result to clipboard
            Clipboard.SetText(this.resultTextBox.Text);
            this.concatStringClipboardLabel.Visible = true;

        }

        private void concatStringClipboardLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearConcatButton_Click(object sender, EventArgs e)
        {
            this.string1TextBox.Clear();
            this.string2TextBox.Clear();
            this.resultTextBox.Clear();
            this.concatStringClipboardLabel.Visible = false;
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
             this.concatStringClipboardLabel.Visible = false;

            if (this.string1TextBox.Text == "")
            {
                MessageBox.Show("String 1 input field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.string2TextBox.Text == "")
            {
                MessageBox.Show("String 2 input field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.string1TextBox.Text.Equals(this.string2TextBox.Text))
            {
                this.resultTextBox.Text = "Equal Strings : True";
            }
            else
            {
                this.resultTextBox.Text = "Equal Strings : False";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.concatStringClipboardLabel.Visible = false;

            this.string2TextBox.Clear();
            if (this.string1TextBox.Text == "")
            {
                MessageBox.Show("String 1 input field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPallinrome(this.string1TextBox.Text)) 
                this.resultTextBox.Text = "Pallindrome : True";
            else
                this.resultTextBox.Text = "Pallindrome : False";

        }

        
        private bool IsPallinrome(string text)
        {
            for (int i = 0; i < (text.Length)/2; i++)
            {
                if (text[i] != text[text.Length - i - 1]) return false;
            }

            return true;
        }

        private string GetReverse(string text)
        {
            var reverseString = "";
            for (int i = text.Length-1; i >=0; i--)
            {
                reverseString += text[i];
            }

            return reverseString;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.concatStringClipboardLabel.Visible = false;

            this.string2TextBox.Clear();

            if (this.string1TextBox.Text == "")
            {
                MessageBox.Show("String 1 input field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.resultTextBox.Text = GetReverse(this.string1TextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    button1_Click(sender, e);
                    break;
                case Keys.F6:
                    compareButton_Click(sender, e);
                    break;
                case Keys.F7:
                    button2_Click(sender, e);
                    break;
                case Keys.F8:
                    button1_Click_1(sender, e);
                    break;
                case Keys.F10:
                    clearConcatButton_Click(sender, e);
                    break;
                default:
                    break;

            }
        }
    }
}
