using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JuanAndSenzoHangmanGame
{
    //Juan Work
    public partial class Question6 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question6()
        {
            InitializeComponent();
            correctSound = new SoundPlayer(@"Sounds\Crowd_Excited_Sound_Effect.wav");
            wrongSound = new SoundPlayer(@"Sounds\Wrong_Buzzer_-_Sound_Effect.wav");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "t")
            {
                lblLetter1.Text = "t";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "a")
            {
                lblLetter2.Text = "a";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "b")
            {
                lblLetter3.Text = "b";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "e")
            {
                lblLetter4.Text = "e";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "r")
            {
                lblLetter5.Text = "r";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "u")
            {
                lblLetter6.Text = "u";
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
                correctSound.Play();
                MessageBox.Show("You are correct the word is taberu");
                correctSound.Stop();
                this.Hide();
                var question7 = new Question7();
                question7.Show();
            }
            if (wrong == 9)
            {
                wrongSound.Play();
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
