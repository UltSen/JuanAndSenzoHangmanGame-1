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
    public partial class Question5 : Form
    {
        private int correct;
        private int wrong;
        public Question5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "a")
            {
                lblLetter1.Text = "a";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "r")
            {
                lblLetter2.Text = "r";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "u")
            {
                lblLetter3.Text = "u";
                lblLetter5.Text = "u";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "k")
            {
                lblLetter4.Text = "k";
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
                MessageBox.Show("You are correct the word is aruku");
                this.Hide();
                var question6 = new Question6();
                question6.Show();
            }
            if (wrong == 9)
            {
                MessageBox.Show("Sorry you have been hung");
                lblLetter1.Text = "";
                lblLetter2.Text = "";
                lblLetter3.Text = "";
                lblLetter4.Text = "";
                lblLetter5.Text = "";
                wrong = 0;
            }
        }
    }
}
