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
            if (txtAnswer.Text == "q")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "w")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "e")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "r")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "t")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "y")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "u")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "p")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "s")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "d")
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
            if (txtAnswer.Text == "h")
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
            if (txtAnswer.Text == "z")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "x")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "v")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "b")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (txtAnswer.Text == "m")
            {
                txtAnswer.Text = "";
                wrong++;
            }
            if (wrong == 1)
            {
                picVerPole.Show();
            }
            if (wrong == 2)
            {
                picHorPole.Show();
            }
            if (wrong == 3)
            {
                picRope.Show();
            }
            if (wrong == 4)
            {
                picHead.Show();
            }
            if (wrong == 5)
            {
                picBody.Show();
            }
            if (wrong == 6)
            {
                picLeftArm.Show();
            }
            if (wrong == 7)
            {
                picRightArm.Show();
            }
            if (wrong == 8)
            {
                picLeftLeg.Show();
            }
            if (wrong == 8)
            {
                picRightLeg.Show();
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
                lblLetter7.Text = "";
                wrong = 0;
            }
        }

        private void Question1_Load(object sender, EventArgs e)
        {
            picVerPole.Hide();
            picHorPole.Hide();
            picRope.Hide();
            picHead.Hide();
            picBody.Hide();
            picLeftArm.Hide();
            picRightArm.Hide();
            picLeftLeg.Hide();
            picRightLeg.Hide();  
        }
    }
}
