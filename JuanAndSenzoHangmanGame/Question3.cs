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
    public partial class Question3 : Form
    {
        private int correct;
        private int wrong;
        public Question3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "o")
            {
                lblLetter1.Text = "o";
                lblLetter3.Text = "o";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "t")
            {
                lblLetter2.Text = "t";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "s")
            {
                lblLetter4.Text = "s";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "a")
            {
                lblLetter5.Text = "a";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "n")
            {
                lblLetter6.Text = "n";
                txtAnswer.Text = "";
                correct++;
            }
            else
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (correct == 5)
            {
                MessageBox.Show("You are correct the word is Otosan");
                this.Hide();
                var question4 = new Question4();
                question4.Show();
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
                wrong = 0;
            }
        }
    }
}
