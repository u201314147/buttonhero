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
        int y;
        int ancho;
        int alto;
        int tipo;
        int hit;
        Color ColorC;
        Brush p1;

        public CCirculo(int pY, int pTipo)
        {
            x = 0;
            y = pY*74 - 60;
            ancho = 100;
            alto = 50;
            tipo = pTipo;
            hit = 0;
 
            //TIPOS 1 = Azul; 2 = Rojo; 3 = Amarillo; 4 = Verde; 5 = Naranja
            if (tipo == 1)
            {
                ColorC = Color.Green;
                x = 50;
            }
            if (tipo == 2)
            {
                ColorC = Color.Red;
                x = 150;
            }
            if (tipo == 3)
            {
                ColorC = Color.Yellow;
                x = 250;
            }
            if (tipo == 4)
            {
                ColorC = Color.Blue;
                x = 350;
            }
            if (tipo == 5)
            {
                ColorC = Color.Orange;
                x = 450;
            }
            p1 = new SolidBrush(ColorC);   
    
           
        }   
    
        public void dibujar(Graphics g)
        {
            if (y > -100 && y < 700)
            {
                g.FillEllipse(p1, x, y , ancho, alto);
                g.DrawEllipse(Pens.Black, x, y , ancho, alto);
            }
        }

        public void mover()
        {
            y = y +5;
        }

        public void hitV()
        {
            if (y > 405 && y < 505)
            {
                hit = 1;
            }
          
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
