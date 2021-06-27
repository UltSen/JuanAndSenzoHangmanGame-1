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
            
        }
    }
}
