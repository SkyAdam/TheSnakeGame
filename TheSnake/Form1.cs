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
        public Form1() //konstruktor dla form
        {
            InitializeComponent();
            is_start = false;
            timer1.Enabled = true;
            
            
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
        }

        private void Playground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            theSnake.move();
            theSnake.drawSnake(Playground.CreateGraphics(),Properties.Resources.snakepart);
        }
    }
}
