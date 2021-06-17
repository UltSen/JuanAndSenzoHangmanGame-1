using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanAndSenzoHangmanGame
{
    public partial class Question4 : Form
    {
        private int correct;
        private int wrong;
        public Question4()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "t")
            {
                lblLetter1.Text = "t";
                lblLetter3.Text = "t";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "a")
            {
                lblLetter2.Text = "a";
                lblLetter4.Text = "a";
                lblLetter6.Text = "a";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "k")
            {
                lblLetter5.Text = "k";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "i")
            {
                lblLetter7.Text = "i";
                txtAnswer.Text = "";
                correct++;
            }
            else
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (correct == 4)
            {
                MessageBox.Show("You are correct the word is tatakai");
                this.Hide();
                var question2 = new Question2();
                question2.Show();
            }
            if (wrong == 9)
            {
                MessageBox.Show("Sorry you have been hung");
                lblLetter1.Text = "";
                lblLetter2.Text = "";
                lblLetter3.Text = "";
                lblLetter4.Text = "";
                lblLetter5.Text = "";
                lblLetter6.Text = "";
                lblLetter7.Text = "";
                wrong = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
