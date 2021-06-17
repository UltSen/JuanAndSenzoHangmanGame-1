﻿using System;
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
    public partial class Question1 : Form
    {
        private int correct;
        private int wrong;
        public Question1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == "o")
            {
                lblLetter1.Text = "o";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "n")
            {
                lblLetter2.Text = "n";
                lblLetter7.Text = "n";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "i")
            {
                lblLetter3.Text = "i";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "c")
            {
                lblLetter4.Text = "c";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "h")
            {
                lblLetter5.Text = "h";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "a")
            {
                lblLetter6.Text = "a";
                txtAnswer.Text = "";
                correct++;
            }
            else
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (correct == 6)
            {
                MessageBox.Show("You are correct the word is onichan");
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
    }
}
