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
    public partial class Question12 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question12()
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
            if (txtbxAns12.Text == "h")
            {
                lblLetter1.Text = "h";
                txtbxAns12.Text = "";
                correct++;
            }
            if (txtbxAns12.Text == "i")
            {
                lblLetter2.Text = "i";
                txtbxAns12.Text = "";
                correct++;
            }
            if (txtbxAns12.Text == "t")
            {
                lblLetter3.Text = "t";
                txtbxAns12.Text = "";
                correct++;
            }
            if (txtbxAns12.Text == "o")
            {
                lblLetter4.Text = "o";
                txtbxAns12.Text = "";
                correct++;
            }
            //Code to check for incorrect answer
            if (txtbxAns12.Text == "q")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "w")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "e")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "r")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "y")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "u")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "o")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "p")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "a")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "s")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "d")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "f")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "g")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "j")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "k")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "l")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "z")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "x")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "c")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "v")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "b")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "n")
            {
                txtbxAns12.Text = "";
                wrong++;
            }
            if (txtbxAns12.Text == "m")
            {
                txtbxAns12.Text = "";
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
                MessageBox.Show("You are correct, the word is hito");
                this.Hide();
                MessageBox.Show("Congradulations you beat the game!");
                correctSound.Stop();
                MessageBox.Show("We hope you play again to better your Japanese vocabulary!");
                this.Hide();
                var menu = new Menu();
                menu.Show();
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

        private void Question12_Load(object sender, EventArgs e)
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
            lblHeading.Text = "What is the Japanese word for person?";
            lblLetter5.Hide();
            lblLetter6.Hide();
            lblLetter7.Hide();
        }
    }
}
