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
    public partial class Question7 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question7()
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
            if (txtbxAns7.Text == "s")
            {
                lblLetter1.Text = "s";
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "h")
            {
                lblLetter2.Text = "h";
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "u")
            {
                lblLetter3.Text = "u";
                lblLetter6.Text = "u";
                lblLetter7.Text = "u";
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "k")
            {
                lblLetter4.Text = "k";
                txtbxAns7.Text = "";
                correct++;
            }
            if (txtbxAns7.Text == "y")
            {
                lblLetter5.Text = "y";
                txtbxAns7.Text = "";
                correct++;
            }
            //Code to check for incorrect answer
            if (txtbxAns7.Text == "q")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "w")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "e")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "r")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "t")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "i")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "o")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "p")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "a")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "d")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "f")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "g")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "j")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "l")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "z")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "x")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "c")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "v")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "b")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "n")
            {
                txtbxAns7.Text = "";
                wrong++;
            }
            if (txtbxAns7.Text == "m")
            {
                txtbxAns7.Text = "";
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
                MessageBox.Show("You are correct, the word is shukyuu");
                correctSound.Stop();
                this.Hide();
                var question8 = new Question8();
                question8.Show();
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

        private void Question7_Load(object sender, EventArgs e)
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
            lblHeading.Text = "What is the Japanese word for football?";
        }
    }
}
