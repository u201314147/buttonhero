using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ButtonGiroxD
{
    public class CCirculo
    {
        int x;
        double y;
        int ancho;
        int alto;
        int tipo;
        int hit;
        int hitcount;
        int hitLast;
        Color ColorC;
        Brush p1;

        public CCirculo(double pY, int pX, int pTipo, int phitCount, int plasthit)
        {
            hitLast = plasthit;
            hitcount = phitCount;
            x = pX;
            //y = pY*74 - 60;
            y = pY - 60;

            ancho = 50;
            alto = 50;
            tipo = pTipo;
            hit = 0;
 
            //TIPOS 1 = Azul; 2 = Rojo; 3 = Amarillo; 4 = Verde; 5 = Naranja
            if (tipo == 1)
            {
                ColorC = Color.Green;
               // x = pX;
            }
            if (tipo == 2)
            {
                ColorC = Color.Red;
               // x = 150;
            }
            if (tipo == 3)
            {
                ColorC = Color.Pink;
               // x = 250;
            }
            if (tipo == 4)
            {
                ColorC = Color.Blue;
               // x = 350;
            }
            if (tipo >= 5)
            {
               
               ColorC = Color.Orange;
               // x = 450;
            }
            p1 = new SolidBrush(ColorC);   
    
           
        }   
    
        public void dibujar(Graphics g)
        {
            int y2 = Convert.ToInt32(y);
    
            if (y > -100 && y < 700)
            {
                        g.FillEllipse(p1, x, y2, ancho, alto);
                g.DrawEllipse(Pens.Black, x, y2, ancho, alto);



                if (tipo == 1)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("△", drawFont, Brushes.Black, p);
                }
                if (tipo == 2)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("O", drawFont, Brushes.Black, p);
                }
                if (tipo == 3)
                {
                    Point p = new Point(x + 15, y2 + 15);
                    Size s = new Size(20, 20);
                    Rectangle rect = new Rectangle(p, s);
                    g.DrawRectangle(Pens.Black, rect);
                }
                if (tipo == 4)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("X", drawFont, Brushes.Black, p);
                }
                if (tipo == 5)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("←", drawFont, Brushes.Black, p);
                }
                if (tipo == 6)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("→", drawFont, Brushes.Black, p);
                }
                if (tipo == 7)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("↑", drawFont, Brushes.Black, p);
                }
                if (tipo == 8)
                {
                    Font drawFont = new Font("Arial Black", 25);
                    Point p = new Point(x, y2);
                    g.DrawString("↓", drawFont, Brushes.Black, p);
                }
            }
        }

        public void mover(double pmover)
        {
            y = y +pmover;
        }

        public void hitV()
        {
            if (hitLast == 0)
            {
                if (y > 0 && y < 450)
                {
                    hit = 1;
                }
            }

            if (hitLast == 1)
            {
                if (y > 200 && y < 650)
                {
                    hit = 1;
                }
            }
        }
        public int getHitCount()
        {
            return hitcount;
        }
        
        public int getHit()
        {
            return hit;
        }
        public int dropMusic()
        {
            if (y > 505 && hit == 1)
            {
                hit = 2;
                return 1;
            }

            return 0;
        }

        public int getTipo()
        {
            return tipo;
        }
            
    }


}
