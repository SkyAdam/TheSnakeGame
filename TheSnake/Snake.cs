using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSnake
{
    class Snake
    {
        public int segments;
        public int oneSegment;

        public int[] x = new int[900]; //tu beda fragmenty weza
        public int[] y = new int[900];

        public string direction;

        public Snake(int width, int height) //okreslaja pole gry
        {
            oneSegment = width / 20; //wyliczamy ile zajmuje jeden segement kiedy waz ma zajac 20 segmentami cala szerokosc planszy
            segments = 3;

            direction = "right";

            int headX = 9 * oneSegment; //glowa bedzie na 10 segmencie
            int headY = 9 * oneSegment;

            for(int i = 0; i < segments; i++)
            {
                x[i] = headX - (i * oneSegment); //glowa to [0]
                y[i] = headY;
            }
           
        }
        public void move()
        {
            for(int i = segments; i > 0; i--) //przesuwa segmenty do przodu, tyl nr 2 na pozycje 1
            {
                x[i] = x[i - 1];
                y[i] = y[i - 1];
            }
            if(direction == "left")
            {
                x[0] = x[0] - oneSegment; //przesuniecie glowy w lewo
            }
            if(direction == "right")
            {
                x[0] = x[0] + oneSegment;
            }
            if(direction == "down")
            {
                y[0] = y[0] + oneSegment;
            }
            if(direction == "up")
            {
                y[0] = y[0] - oneSegment;
            }

            if (x[0] < 0)
            {
                x[0] = oneSegment * 19; //maksymalny fragment
                
            }
            if(x[0] > oneSegment * 20)
            {
                x[0] = 0;
            }
            if (y[0] < 0)
            {
                y[0] = oneSegment * 19;
            }
            if(y[0]> oneSegment * 20)
            {
                y[0] = 0;
            }
        }
        public void drawSnake(Graphics g,Image imageOfSnake) //gdzie i co chce narysowac
        {
            
            for(int i =0; i < segments; i++)
            {
                Point locationOfSegment = new Point(x[i], y[i]);
                g.DrawImage(imageOfSnake, locationOfSegment);

            }
            
        }
        public void grow()
        {
            x[segments] = x[segments - 1];
            y[segments] = y[segments - 1];
            segments = segments + 1;
        }
        public bool isSnakeLife()
        {
            for (int i = 1; i < segments; i++)
            {
                if (x[0] == x[i] && y[0] == y[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
