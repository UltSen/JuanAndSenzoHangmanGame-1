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
    public partial class Question2 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question2()
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
            if (txtAnswer.Text == "c")
            {
                lblLetter1.Text = "c";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "h")
            {
                lblLetter2.Text = "h";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "o")
            {
                lblLetter3.Text = "o";
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
            else
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (correct == 5)
            {
                correctSound.Play();
                MessageBox.Show("You are correct the word is chosa");
                correctSound.Stop();
                this.Hide();
                var question3 = new Question3();
                question3.Show();
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
                wrong = 0;
            }
        }
    }
}
