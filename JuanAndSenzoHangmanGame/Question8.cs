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
    public partial class Question8 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question8()
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
            if (txtbxAns8.Text == "n")
            {
                lblLetter1.Text = "n";
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "a")
            {
                lblLetter2.Text = "a";
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "t")
            {
                lblLetter3.Text = "t";
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "s")
            {
                lblLetter4.Text = "s";
                txtbxAns8.Text = "";
                correct++;
            }
            if (txtbxAns8.Text == "u")
            {
                lblLetter5.Text = "u";
                txtbxAns8.Text = "";
                correct++;
            }
            //Code to check for incorrect answer
            if (txtbxAns8.Text == "q")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "w")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "e")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "r")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "y")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "i")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "o")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "p")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "d")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "f")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "g")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "h")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "j")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "k")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "l")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "z")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "x")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "c")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "v")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "b")
            {
                txtbxAns8.Text = "";
                wrong++;
            }
            if (txtbxAns8.Text == "m")
            {
                txtbxAns8.Text = "";
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
                MessageBox.Show("You are correct, the word is natsu");
                correctSound.Stop();
                this.Hide();
                var question9 = new Question9();
                question9.Show();
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

        private void Question8_Load(object sender, EventArgs e)
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
            lblHeading.Text = "What is the Japanese word for Summer?";
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}