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
    public partial class Question1 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question1()
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
            // correct calculation
            if (txtAnswer.Text == "o")
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
            if (correct == 6)
            {
                correctSound.Play();
                MessageBox.Show("You are correct the word is onichan");
                correctSound.Stop();
                this.Hide();
                var question2 = new Question2();
                question2.Show();
            }
            // wrong calculation
            if (txtAnswer.Text == "b")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "d")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "e")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "f")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "g")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "j")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "k")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "l")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "m")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "p")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "q")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "r")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "s")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "t")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "u")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "v")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "w")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "x")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "y")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "z")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (wrong == 1)
            {
                picVerPole.Visible = true;
            }
            if (wrong == 2)
            {
                picHorPole.Visible = true;
            }
            if (wrong == 3)
            {
                picRope.Visible = true;
            }
            if (wrong == 4)
            {
                picHead.Visible = true;
            }
            if (wrong == 5)
            {
                picBody.Visible = true;
            }
            if (wrong == 6)
            {
                picLeftArm.Visible = true;
            }
            if (wrong == 7)
            {
                picRightArm.Visible = true;
            }
            if (wrong == 8)
            {
                picLeftLeg.Visible = true;
            }
            if (wrong == 9)
            {
                picRightLeg.Visible = true;
                wrongSound.Play();
                MessageBox.Show("Sorry you have been hung");
                lblLetter1.Text = "";
                lblLetter2.Text = "";
                lblLetter3.Text = "";
                lblLetter4.Text = "";
                lblLetter5.Text = "";
                lblLetter6.Text = "";
                lblLetter7.Text = "";
                correct = 0;
                wrong = 0;
                picVerPole.Visible = false;
                picHorPole.Visible = false;
                picRope.Visible = false;
                picHead.Visible = false;
                picBody.Visible = false;
                picLeftArm.Visible = false;
                picRightArm.Visible = false;
                picLeftLeg.Visible = false;
                picRightLeg.Visible = false;
            }
        }

        private void Question1_Load(object sender, EventArgs e)
        {

        }
    }
}
