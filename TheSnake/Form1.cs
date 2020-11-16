using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSnake
{
    public partial class Form1 : Form
    {
        bool is_start;
        Snake theSnake;
        public Image imageSnake = Properties.Resources.snakepart;
        Food theFood;
        public Image imageFood = Properties.Resources.fruit;
        public Form1() //konstruktor dla form
        {
            InitializeComponent();
            is_start = false;
            timer1.Enabled = true;

            this.BackgroundImage = Properties.Resources.grassSmall;

            Playground.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void pAUZAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_start ==false)
            {
                timer2.Enabled = false;
                FontFamily myFontFamily = new FontFamily("Arial");
                Font myFont = new Font(myFontFamily, 16);
                Brush myBrush = new SolidBrush(Color.Red);
                Playground.CreateGraphics().DrawString("Click START",myFont,myBrush,80,135);
            }
            else
            {
                Playground.CreateGraphics().Clear(Color.Transparent);
                Playground.BackgroundImage = Properties.Resources.grassSmall; //dodajemy tlo ze zrodla, zrodlo mozna zobaczyc w eksploratorze rozwiazan
                timer1.Enabled = false;
                timer2.Enabled = true;
                 
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_start = true;
            theSnake = new Snake(Playground.Width, Playground.Height);

            theFood = new Food(theSnake.oneSegment);
        }

        private void Playground_Paint(object sender, PaintEventArgs e)
        {
            //this.BackgroundImage = Properties.Resources.grassSmall;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Playground.CreateGraphics().Clear(Color.FromArgb(60, 0, 0, 0));
            //Playground.CreateGraphics().Clear(Color.Transparent); //narazie nie jestem w stanie zmusic go do przezroczytsosci po czyszczeniu

            //Playground.Invalidate();
            //Playground.Controls.Clear();
            Playground.CreateGraphics().Clear(Color.ForestGreen);
            //Playground.BackgroundImage = Properties.Resources.grassSmall;
            theSnake.move();
            theSnake.drawSnake(Playground.CreateGraphics(),Properties.Resources.snakepart);

            theFood.drawFood(Playground.CreateGraphics(), imageFood);
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    theSnake.direction = "up";
                    break;
                case Keys.Down:
                    theSnake.direction = "down";
                    break;
                case Keys.Right:
                    theSnake.direction = "right";
                    break;
                case Keys.Left:
                    theSnake.direction = "left";
                    break;
            }
        }
    }
}
