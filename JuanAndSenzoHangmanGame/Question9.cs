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
    //Senzo Work
    public partial class Question9 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question9()
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
        {//Code for correct answer
            if (txtbxAns9.Text == "h")
            {
                lblLetter1.Text = "h";
                txtbxAns9.Text = "";
                correct++;
            }
            if (txtbxAns9.Text == "a")
            {
                lblLetter2.Text = "a";
                txtbxAns9.Text = "";
                correct++;
            }
            if (txtbxAns9.Text == "r")
            {
                lblLetter3.Text = "r";
                txtbxAns9.Text = "";
                correct++;
            }
            if (txtbxAns9.Text == "u")
            {
                lblLetter4.Text = "u";
                txtbxAns9.Text = "";
                correct++;
            }
            //Code to check for incorrect answer
            if (txtbxAns9.Text == "q")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "w")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "e")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "t")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "y")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "i")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "o")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "p")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "s")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "d")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "f")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "g")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "j")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "k")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "l")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "z")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "x")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "c")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "v")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "b")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "n")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            if (txtbxAns9.Text == "m")
            {
                txtbxAns9.Text = "";
                wrong++;
            }
            //Stickman appearance conditions
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
            if (correct == 4)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is haru");
                correctSound.Stop();
                this.Hide();
                var question10 = new Question10();
                question10.Show();
            }
            if (wrong == 9)
            {
                picRightLeg.Show();
                wrongSound.Play();
                MessageBox.Show("Sorry you have been hung");
                wrongSound.Stop();
                lblLetter1.Text = "";
                lblLetter2.Text = "";
                lblLetter3.Text = "";
                lblLetter4.Text = "";
                lblLetter5.Text = "";
                lblLetter6.Text = "";
                lblLetter7.Text = "";
                wrong = 0;
                correct = 0;
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
        private void Question9_Load(object sender, EventArgs e)
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
            lblHeading.Text = "What is the Japanese word for Spring?";
            lblLetter5.Hide();
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}