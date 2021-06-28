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
    public partial class Question10 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question10()
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
            if (txtbxAns10.Text == "s")
            {
                lblLetter1.Text = "s";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "u")
            {
                lblLetter2.Text = "u";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "g")
            {
                lblLetter3.Text = "g";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "o")
            {
                lblLetter4.Text = "o";
                txtbxAns10.Text = "";
                correct++;
            }
            if (txtbxAns10.Text == "i")
            {
                lblLetter5.Text = "i";
                txtbxAns10.Text = "";
                correct++;
            }
            //Code to check for incorrect answer
            if (txtbxAns10.Text == "q")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "w")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "e")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "r")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "t")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "y")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "p")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "a")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "d")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "f")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "h")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "j")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "k")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "l")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "z")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "x")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "c")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "v")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "b")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "n")
            {
                txtbxAns10.Text = "";
                wrong++;
            }
            if (txtbxAns10.Text == "m")
            {
                txtbxAns10.Text = "";
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
            if (correct == 5)
            {
                correctSound.Play();
                MessageBox.Show("You are correct, the word is sugoi");
                correctSound.Stop();
                this.Hide();
                var question11 = new Question11();
                question11.Show();
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

        private void Question10_Load(object sender, EventArgs e)
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
            lblHeading.Text = "What is the Japanese word for amazing?";
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}