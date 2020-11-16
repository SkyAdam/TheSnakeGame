using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheSnake
{
    class Food
    {
        public int x, y, segment;




        public void spam()
        {
            Random r = new Random();
            x = r.Next(0, 20) * segment;
            y = r.Next(0, 20) * segment;
        }
        public Food(int segment)
        {
            this.segment = segment;
            spam();
        }
        public bool needFood(int headX, int headY)
        {
            if(x==headX && y == headY)
            {
                spam();
                return true;
                    
            }
            return false;
        }
        public void drawFood(Graphics g,Image imageOfFood)
        {
            Point locationOfFood = new Point(x, y);
            g.DrawImage(imageOfFood, locationOfFood);
        }
    }
    
}
