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
    public partial class Question11 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question11()
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
            if (txtbxAns11.Text == "t")
            {
                lblLetter1.Text = "t";
                lblLetter3.Text = "t";
                txtbxAns11.Text = "";
                correct++;
            }
            if (txtbxAns11.Text == "a")
            {
                lblLetter2.Text = "a";
                lblLetter4.Text = "a";
                lblLetter6.Text = "a";
                txtbxAns11.Text = "";
                correct++;
            }
            if (txtbxAns11.Text == "k")
            {
                lblLetter5.Text = "k";
                txtbxAns11.Text = "";
                correct++;
            }
            if (txtbxAns11.Text == "u")
            {
                lblLetter7.Text = "u";
                txtbxAns11.Text = "";
                correct++;
            }
            //Code to check for incorrect answer
            if (txtbxAns11.Text == "q")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "w")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "e")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "r")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "t")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "y")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "i")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "o")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "p")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "s")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "d")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "f")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "g")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "h")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "j")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "l")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "z")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "x")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "c")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "v")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "b")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "n")
            {
                txtbxAns11.Text = "";
                wrong++;
            }
            if (txtbxAns11.Text == "m")
            {
                txtbxAns11.Text = "";
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
                MessageBox.Show("You are correct, the word is tatakau");
                correctSound.Stop();
                this.Hide();
                var question12 = new Question12();
                question12.Show(); ;
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

        private void Question11_Load(object sender, EventArgs e)
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
            lblHeading.Text = "What is the Japanese word for fight?";
        }
    }
}