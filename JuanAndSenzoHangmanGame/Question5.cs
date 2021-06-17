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
    public partial class Question5 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question5()
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
                correctSound.Play();
                MessageBox.Show("You are correct the word is aruku");
                correctSound.Stop();
                this.Hide();
                var question6 = new Question6();
                question6.Show();
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
