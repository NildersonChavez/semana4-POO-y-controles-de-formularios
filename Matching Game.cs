using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana4_POO_y_controles_de_formularios
{


    public partial class Form1 : Form
    {
        
        
            Label firstClicked = null;

            Label secondClicked = null;

            Random random = new Random();

            List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };
            public Form1()
            {
                InitializeComponent();

                AssignIconsToSquares();
            }
            private void AssignIconsToSquares()
            {

                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    Label iconLabel = control as Label;
                    if (iconLabel != null)
                    {
                        int randomNumber = random.Next(icons.Count);
                        iconLabel.Text = icons[randomNumber];
                        iconLabel.ForeColor = iconLabel.BackColor;
                        icons.RemoveAt(randomNumber);
                    }
                }
            }

            private void label6_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label2_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label3_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label4_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;

                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label5_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label1_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label7_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label8_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label9_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label10_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label11_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label12_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label13_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {

                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label14_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {
                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label15_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {
                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void label16_Click(object sender, EventArgs e)
            {
                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {
                    if (clickedLabel.ForeColor == Color.Black)
                        return;


                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    timer1.Start();
                }
            }

            private void timer1_Tick_1(object sender, EventArgs e)
            {
                timer1.Stop();


                firstClicked.ForeColor = firstClicked.BackColor;
                secondClicked.ForeColor = secondClicked.BackColor;

                firstClicked = null;
                secondClicked = null;
            }

           
            }


        }
    }
    
 

    




