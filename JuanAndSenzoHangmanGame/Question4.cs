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
    public partial class Question4 : Form
    {
        private int correct;
        private int wrong;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        public Question4()
        {
            InitializeComponent();
            correctSound = new SoundPlayer(@"Sounds\Crowd_Excited_Sound_Effect.wav");
            wrongSound = new SoundPlayer(@"Sounds\Wrong_Buzzer_-_Sound_Effect.wav");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "t")
            {
                lblLetter1.Text = "t";
                lblLetter3.Text = "t";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "a")
            {
                lblLetter2.Text = "a";
                lblLetter4.Text = "a";
                lblLetter6.Text = "a";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "k")
            {
                lblLetter5.Text = "k";
                txtAnswer.Text = "";
                correct++;
            }
            if (txtAnswer.Text == "i")
            {
                lblLetter7.Text = "i";
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
                MessageBox.Show("You are correct the word is tatakai");
                correctSound.Stop();
                this.Hide();
                var question5 = new Question5();
                question5.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
