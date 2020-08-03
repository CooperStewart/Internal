using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal
{
    public partial class Form1 : Form
    {
        bool jumping = false; int pipeSpeed = 5; int gravity = 5; int inscore = 0;
        public Form1()
        {
            InitializeComponent();
            endText1.Text = "Game Over!"; gameDesigner.Text = "Game designed by your name here"; endText1.Visible = false; endText2.Visible = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
        }

        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { jumping = true; gravity = -5; }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { jumping = false; gravity = 5; }
        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true; endText2.Visible = true; endText2.Text = "Your Final Score is: " + inscore; gameDesigner.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {

            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed; Titan.Top += gravity; scoreText.Text = " " + inscore;

            if (Titan.Bounds.IntersectsWith(ground.Bounds))
            {
                Titan.Top += 0;
            }
            if (Titan.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            if (Titan.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            if (pipeBottom.Left < -80)

            { pipeBottom.Left = 1000; inscore += 1; }
            else if (pipeTop.Left < -95)

            { pipeTop.Left = 1100; inscore += 1; }
        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }
    }
}
