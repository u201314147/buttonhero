using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGiroxD
{
    public partial class Form1 : Form
    {
           
        int an1 = 0;
        int minitimerA1 = 0;
        int an2 = 0;
        int minitimerA2 = 0;
        int an3 = 0;
        int minitimerA3 = 0;
        int an4 = 0;
        int minitimerA4 = 0;
        int an5 = 0;
        int minitimerA5 = 0;
        int score = 0;

        int megatimer = 0;
          int minitimer = 0;
        int tab1;
        int tab2;
        int tab3;
        int tab4;
        int tab5;
        List<CCirculo> Circulo;
        		 System.Media.SoundPlayer player;
                
                 WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                 WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
           
        public Form1()
        {
            player = new System.Media.SoundPlayer();
            player.SoundLocation = "slash5.wav";
            
            Circulo = new List<CCirculo>();
            InitializeComponent();

        button1.Enabled = false;
            button1.Visible = false;
           tab1=0 ; tab2=0; tab3=0; tab4=0; tab5=0;
           AddCirc(-10, 1);
           AddCirc(-12, 2);
          
            AddCirc(-14, 1);
           AddCirc(-15, 1);
           AddCirc(-16, 2);
           
            AddCirc(-18, 1);
            AddCirc(-19, 1);
            AddCirc(-20, 2);
            AddCirc(-21, 1);
            AddCirc(-23, 1);

           AddCirc(-24, 2);
           AddCirc(-25, 2);


           AddCirc(-26, 1);
           AddCirc(-27, 1);
           AddCirc(-28, 2);
           
            AddCirc(-30, 1);

            AddCirc(-31, 1);

            AddCirc(-32, 2);
           AddCirc(-33, 1);
           AddCirc(-34, 1);
           AddCirc(-36, 2);
           AddCirc(-37, 1);
           AddCirc(-38, 1);
          
            AddCirc(-40, 2);
           AddCirc(-41, 2);

           AddCirc(-42, 3);
           AddCirc(-43, 3);
           AddCirc(-45, 2);
           AddCirc(-47, 2);
           AddCirc(-49, 3);
           AddCirc(-50, 3);
           AddCirc(-51, 4);
           AddCirc(-52, 5);
           AddCirc(-54, 5);
           AddCirc(-55, 5);

           AddCirc(-58, 3);
           AddCirc(-59, 3);
           AddCirc(-61, 2);
           AddCirc(-63, 2);
           AddCirc(-65, 3);
           AddCirc(-66, 3);
           AddCirc(-67, 4);
           AddCirc(-68, 5);
           AddCirc(-70, 5);
           AddCirc(-71, 5);

           AddCirc(-73, 3); AddCirc(-73, 4);
           AddCirc(-74, 3); AddCirc(-74, 4);
           AddCirc(-75, 3); AddCirc(-75, 4);
           AddCirc(-76, 3); AddCirc(-76, 4);

           AddCirc(-77, 2); AddCirc(-77, 3);
           AddCirc(-78, 2); AddCirc(-78, 3);
           AddCirc(-79, 2); AddCirc(-79, 3);
           AddCirc(-80, 2); AddCirc(-80, 3);

           AddCirc(-81, 3); AddCirc(-81, 4);
           AddCirc(-82, 3); AddCirc(-82, 4);
           AddCirc(-83, 4);
           AddCirc(-84, 4); AddCirc(-84, 5);
           AddCirc(-85, 4); AddCirc(-85, 5);
           AddCirc(-86, 4); AddCirc(-86, 5);
           AddCirc(-87, 4); AddCirc(-87, 5);
           AddCirc(-88, 4); AddCirc(-88, 5);

           AddCirc(-89, 3); AddCirc(-89, 4);
           AddCirc(-90, 3); AddCirc(-90, 4);
           AddCirc(-91, 3); AddCirc(-91, 4);
           AddCirc(-92, 3); AddCirc(-92, 4);

           AddCirc(-93, 2); AddCirc(-93, 3);
           AddCirc(-94, 2); AddCirc(-94, 3);
           AddCirc(-95, 2); AddCirc(-95, 3);
           AddCirc(-96, 2); AddCirc(-96, 3);

           AddCirc(-97, 3); AddCirc(-97, 4);
           AddCirc(-98, 3); AddCirc(-98, 4);
           AddCirc(-99, 4);
           AddCirc(-100, 4); AddCirc(-100, 5);
           AddCirc(-101, 4); AddCirc(-101, 5);
           AddCirc(-102, 4); AddCirc(-102, 5);
           AddCirc(-103, 4); AddCirc(-103, 5);
           AddCirc(-104, 4); AddCirc(-104, 5);


           AddCirc(-105, 3); AddCirc(-105, 4);
           AddCirc(-106, 3); AddCirc(-106, 4);
           AddCirc(-107, 3); AddCirc(-107, 4);
           AddCirc(-108, 3); AddCirc(-108, 4);

           AddCirc(-109, 2); AddCirc(-109, 3);
           AddCirc(-110, 2); AddCirc(-110, 3);
           AddCirc(-111, 2); AddCirc(-111, 3);
           AddCirc(-112, 2); AddCirc(-112, 3);

           AddCirc(-113, 3); AddCirc(-113, 4);
           AddCirc(-114, 3); AddCirc(-114, 4);
           AddCirc(-115, 4);
           AddCirc(-116, 4); AddCirc(-116, 5);
           AddCirc(-117, 4); AddCirc(-117, 5);
           AddCirc(-118, 4); AddCirc(-118, 5);
           AddCirc(-119, 4); AddCirc(-119, 5);
           AddCirc(-120, 4); AddCirc(-120, 5);



           AddCirc(-121, 3); AddCirc(-121, 4);
           AddCirc(-122, 3); AddCirc(-122, 4);
           AddCirc(-123, 3); AddCirc(-123, 4);
           AddCirc(-124, 3); AddCirc(-124, 4);

           AddCirc(-125, 2); AddCirc(-125, 3);
           AddCirc(-126, 2); AddCirc(-126, 3);
           AddCirc(-127, 2); AddCirc(-127, 3);
           AddCirc(-128, 2); AddCirc(-128, 3);

           AddCirc(-128, 3); AddCirc(-128, 4);
           AddCirc(-129, 3); AddCirc(-129, 4);
           AddCirc(-130, 4);
           AddCirc(-131, 4); AddCirc(-131, 5);
           AddCirc(-132, 4); AddCirc(-132, 5);
           AddCirc(-133, 4); AddCirc(-133, 5);
           AddCirc(-134, 4); AddCirc(-134, 5);
           AddCirc(-135, 4); AddCirc(-135, 5);

           AddCirc(-136, 1);
           AddCirc(-137, 1);
           AddCirc(-138, 2);
           AddCirc(-140, 1);
           AddCirc(-141, 1);
           AddCirc(-142, 2);
           AddCirc(-144, 1);
           AddCirc(-145, 1);
           AddCirc(-146, 2);
           AddCirc(-147, 1);
           
            AddCirc(-149, 1);
           AddCirc(-150, 2);
           AddCirc(-151, 2);

           AddCirc(-152, 1);
           AddCirc(-153, 1);
           AddCirc(-154, 2);
           AddCirc(-156, 1);
           AddCirc(-157, 1);
           AddCirc(-158, 2);
           AddCirc(-160, 1);
           AddCirc(-161, 1);
           AddCirc(-162, 2);
            AddCirc(-163, 1);

            AddCirc(-165, 1);
            AddCirc(-166, 2);
           AddCirc(-167, 2);

           AddCirc(-168, 1);
           AddCirc(-169, 1);
           AddCirc(-170, 2);
           AddCirc(-172, 1);
           AddCirc(-173, 1);
           AddCirc(-174, 2);
           AddCirc(-176, 1);
           AddCirc(-177, 1);
           AddCirc(-178, 2);
           AddCirc(-179, 1);

           AddCirc(-180, 1);
           AddCirc(-181, 2);
      

           AddCirc(-183, 1);
           AddCirc(-184, 1);
           AddCirc(-185, 2);
           AddCirc(-187, 1);
           AddCirc(-188, 1);
           AddCirc(-189, 2);
           AddCirc(-191, 1);
           AddCirc(-192, 1);
           AddCirc(-193, 2);

           AddCirc(-194, 1);

           AddCirc(-196, 1);
           AddCirc(-197, 2);
           AddCirc(-198, 2);

           AddCirc(-199, 3); AddCirc(-199, 4);
           AddCirc(-200, 3); AddCirc(-200, 4);
           AddCirc(-201, 3); AddCirc(-201, 4);
           AddCirc(-202, 3); AddCirc(-202, 4);

           AddCirc(-203, 2); AddCirc(-203, 3);
           AddCirc(-204, 2); AddCirc(-204, 3);
           AddCirc(-205, 2); AddCirc(-205, 3);
           AddCirc(-206, 2); AddCirc(-206, 3);

           AddCirc(-207, 3); AddCirc(-207, 4);
           AddCirc(-208, 3); AddCirc(-208, 4);
           AddCirc(-209, 4);
           AddCirc(-210, 4); AddCirc(-210, 5);
           AddCirc(-211, 4); AddCirc(-211, 5);
           AddCirc(-212, 4); AddCirc(-212, 5);
           AddCirc(-213, 4); AddCirc(-213, 5);
           AddCirc(-214, 4); AddCirc(-214, 5);


           AddCirc(-215, 3); AddCirc(-215, 4);
           AddCirc(-216, 3); AddCirc(-216, 4);
           AddCirc(-217, 3); AddCirc(-217, 4);
           AddCirc(-218, 3); AddCirc(-218, 4);

           AddCirc(-219, 2); AddCirc(-219, 3);
           AddCirc(-220, 2); AddCirc(-220, 3);
           AddCirc(-221, 2); AddCirc(-221, 3);
           AddCirc(-222, 2); AddCirc(-222, 3);

           AddCirc(-223, 3); AddCirc(-223, 4);
           AddCirc(-224, 3); AddCirc(-224, 4);
           AddCirc(-225, 4);
           AddCirc(-226, 4); AddCirc(-226, 5);
           AddCirc(-227, 4); AddCirc(-227, 5);
           AddCirc(-228, 4); AddCirc(-228, 5);
           AddCirc(-229, 4); AddCirc(-229, 5);
           AddCirc(-230, 4); AddCirc(-230, 5);

           AddCirc(-231, 3); AddCirc(-231, 4);
           AddCirc(-232, 3); AddCirc(-232, 4);
           AddCirc(-233, 3); AddCirc(-233, 4);
           AddCirc(-234, 3); AddCirc(-234, 4);

           AddCirc(-235, 2); AddCirc(-235, 3);
           AddCirc(-236, 2); AddCirc(-236, 3);
           AddCirc(-237, 2); AddCirc(-237, 3);
           AddCirc(-238, 2); AddCirc(-238, 3);

           AddCirc(-239, 3); AddCirc(-239, 4);
           AddCirc(-240, 3); AddCirc(-240, 4);
           AddCirc(-241, 4);
           AddCirc(-242, 4); AddCirc(-242, 5);
           AddCirc(-243, 4); AddCirc(-243, 5);
           AddCirc(-244, 4); AddCirc(-244, 5);
           AddCirc(-245, 4); AddCirc(-245, 5);
           AddCirc(-246, 4); AddCirc(-246, 5);

           AddCirc(-247, 2); AddCirc(-247, 3);
           AddCirc(-248, 2); AddCirc(-248, 3);
           AddCirc(-249, 2); AddCirc(-249, 3);
           AddCirc(-250, 2); AddCirc(-250, 3);
           AddCirc(-251, 2); AddCirc(-251, 3);
           AddCirc(-252, 2); AddCirc(-252, 3);
           AddCirc(-253, 2); AddCirc(-253, 3);
           AddCirc(-254, 2); AddCirc(-254, 3);

           AddCirc(-255, 3); AddCirc(-255, 4);
           AddCirc(-256, 3); AddCirc(-256, 4);
           AddCirc(-257, 3); AddCirc(-257, 4);
           AddCirc(-258, 3); AddCirc(-258, 4);
           AddCirc(-259, 3); AddCirc(-259, 4);
           AddCirc(-260, 3); AddCirc(-260, 4);
           AddCirc(-261, 3); AddCirc(-261, 4);
           AddCirc(-262, 3); AddCirc(-262, 4);

           AddCirc(-263, 4); AddCirc(-263, 5);
           AddCirc(-264, 4); AddCirc(-264, 5);
           AddCirc(-265, 4); AddCirc(-265, 5);
           AddCirc(-266, 4); AddCirc(-266, 5);
           AddCirc(-267, 4); AddCirc(-267, 5);
           AddCirc(-268, 4); AddCirc(-268, 5);
           AddCirc(-269, 4); AddCirc(-269, 5);
           AddCirc(-270, 4); AddCirc(-270, 5);

           AddCirc(-271, 4); AddCirc(-271, 5);
           AddCirc(-272, 4); AddCirc(-272, 5);
           AddCirc(-273, 4); AddCirc(-273, 5);
           AddCirc(-274, 4); AddCirc(-274, 5);
           AddCirc(-275, 4); AddCirc(-275, 5);
           AddCirc(-276, 4); AddCirc(-276, 5);
           AddCirc(-277, 4); AddCirc(-277, 5);
           AddCirc(-278, 4); AddCirc(-278, 5);

           AddCirc(-279, 2); AddCirc(-279, 4);
           AddCirc(-280, 2); AddCirc(-280, 4);
           AddCirc(-281, 3); AddCirc(-281, 5);
           AddCirc(-282, 2); AddCirc(-282, 4);
           AddCirc(-283, 3); AddCirc(-283, 5);
           AddCirc(-284, 2); AddCirc(-284, 4);
           AddCirc(-285, 3); AddCirc(-285, 5);
           AddCirc(-286, 2); AddCirc(-286, 4);
           AddCirc(-287, 3); AddCirc(-287, 5);
           AddCirc(-288, 3); AddCirc(-288, 5);
           AddCirc(-289, 4);
           AddCirc(-290, 4); AddCirc(-290, 5);
           AddCirc(-291, 4); AddCirc(-291, 5);
           AddCirc(-292, 4); AddCirc(-292, 5);
           AddCirc(-293, 4); AddCirc(-293, 5);

           AddCirc(-294, 2); AddCirc(-294, 4);
           AddCirc(-295, 2); AddCirc(-295, 4);
           AddCirc(-296, 3); AddCirc(-296, 5);
           AddCirc(-297, 2); AddCirc(-297, 4);
           AddCirc(-298, 3); AddCirc(-298, 5);
           AddCirc(-299, 2); AddCirc(-299, 4);
           AddCirc(-300, 3); AddCirc(-300, 5);
           AddCirc(-301, 2); AddCirc(-301, 4);
           AddCirc(-302, 3); AddCirc(-302, 5);
           AddCirc(-303, 3); AddCirc(-303, 5);
           AddCirc(-304, 4);
           AddCirc(-305, 4); AddCirc(-305, 5);
           AddCirc(-306, 4); AddCirc(-306, 5);
           AddCirc(-307, 4); AddCirc(-307, 5);
           AddCirc(-308, 4); AddCirc(-308, 5);
           AddCirc(-309, 4); AddCirc(-309, 5);

           AddCirc(-310, 5); 
            AddCirc(-311, 2);
           AddCirc(-312, 1);
       

        }

        private void AddCirc(int pY, int pTipo)
        {
        CCirculo circ;

            Circulo.Add(circ = new CCirculo(pY, pTipo));
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score < 0)
                score = 0;
            Graphics g = this.CreateGraphics();
            BufferedGraphicsContext contexto = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = contexto.Allocate(g, this.DisplayRectangle);
           //buffer.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            buffer.Graphics.Clear(Color.White);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 500, 500, 50);
            
            buffer.Graphics.FillRectangle(Brushes.LightGray, 54, 1, 495, 600);

            buffer.Graphics.DrawRectangle(Pens.Black, 50, 500, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 450, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 400, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 350, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 300, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 250, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 200, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 150, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 100, 500, 50);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 50, 500, 50);


            buffer.Graphics.DrawRectangle(Pens.Black, 50, 0, 1, 600); 
            buffer.Graphics.DrawRectangle(Pens.Black, 150, 0, 1, 600);
            buffer.Graphics.DrawRectangle(Pens.Black, 250, 0, 1, 600);
            buffer.Graphics.DrawRectangle(Pens.Black, 350, 0, 1, 600);
            buffer.Graphics.DrawRectangle(Pens.Black, 450, 0, 1, 600);
            buffer.Graphics.DrawRectangle(Pens.Black, 550, 0, 1, 600);



            foreach (CCirculo c in Circulo)
            {
                c.dibujar(buffer.Graphics);
                c.mover();
                c.hitV();
                if (c.dropMusic() == 1)
                    wplayer.settings.volume = 0;
                }

            buffer.Graphics.FillEllipse(Brushes.DarkGreen, 48, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkRed, 148, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkKhaki, 248, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkBlue, 348, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkGoldenrod, 448, 448, 104, 54);



            if(tab1==0)
            buffer.Graphics.FillEllipse(Brushes.Green, 50, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.LightGreen, 50, 450, 100, 50);

            if (tab2 == 0)
            buffer.Graphics.FillEllipse(Brushes.Red, 150, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.Pink, 150, 450, 100, 50);

            if (tab3 == 0)
            buffer.Graphics.FillEllipse(Brushes.Yellow, 250, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.LightGoldenrodYellow, 250, 450, 100, 50);

            if (tab4 == 0)
            buffer.Graphics.FillEllipse(Brushes.Blue, 350, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.LightBlue, 350, 450, 100, 50);

            if (tab5 == 0)      
            buffer.Graphics.FillEllipse(Brushes.Orange, 450, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.Gold, 450, 450, 100, 50);



            if (an1 == 1)
            {
                if(minitimerA1==1)
                buffer.Graphics.FillEllipse(Brushes.White, 30, 440, 140, 60);

                if(minitimerA1==2)
                    buffer.Graphics.FillEllipse(Brushes.White, 55, 455, 90, 40);

                if(minitimerA1==3)
                    buffer.Graphics.FillEllipse(Brushes.White, 60, 460, 80, 30);

                if(minitimerA1==4)
                    buffer.Graphics.FillEllipse(Brushes.White, 65, 465, 70, 20);

                minitimerA1++;

                if (minitimerA1 == 6)
                {
                    an1 = 0;
                    minitimerA1 = 0;
                }
            }


            if (an2 == 1)
            {
                if (minitimerA2 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 130, 440, 140, 60);

                if (minitimerA2 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 155, 455, 90, 40);

                if (minitimerA2 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 160, 460, 80, 30);

                if (minitimerA2 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 165, 465, 70, 20);

                minitimerA2++;

                if (minitimerA2 == 6)
                {
                    an2 = 0;
                    minitimerA2 = 0;
                }
            }

            if (an3 == 1)
            {
                if (minitimerA3 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 230, 440, 140, 60);

                if (minitimerA3 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 255, 455, 90, 40);

                if (minitimerA3 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 260, 460, 80, 30);

                if (minitimerA3 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 265, 465, 70, 20);

                minitimerA3++;

                if (minitimerA3 == 6)
                {
                    an3 = 0;
                    minitimerA3 = 0;
                }
            }

            if (an4 == 1)
            {
                if (minitimerA4 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 330, 440, 140, 60);

                if (minitimerA4 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 355, 455, 90, 40);

                if (minitimerA4 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 360, 460, 80, 30);

                if (minitimerA4 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 365, 465, 70, 20);

                minitimerA4++;

                if (minitimerA4 == 6)
                {
                    an4 = 0;
                    minitimerA4 = 0;
                }
            }


            if (an5 == 1)
            {
                if (minitimerA5 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 430, 440, 140, 60);

                if (minitimerA5 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 455, 455, 90, 40);

                if (minitimerA5 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 460, 460, 80, 30);

                if (minitimerA5 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 465, 465, 70, 20);

                minitimerA5++;

                if (minitimerA5 == 6)
                {
                    an5 = 0;
                    minitimerA5 = 0;
                }
            }

          
            label1.Text = score.ToString();
          
            if (megatimer == 4800)
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                button1.Visible = true;
                buffer.Render();
                button1.Text = "Puntuación Final" + "\n" + score.ToString() + "\n" + "Reiniciar";
           
            }

            
            megatimer++;
            buffer.Render();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Application.Restart();
            }
            if (minitimer<2)
            {
                if (e.KeyCode == Keys.Q)
                {
                    tab1 = 1;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 1 && c.getHit() == 1)
                        {
                            an1 = 1;
                            score = score + 45;       
                            Circulo.Remove(c);
                      //      player.SoundLocation = "kick.wav";
                    //        player.Play();
                            wplayer.settings.volume = 100;
                            return;
                        }
                    }
                    score = score - 15;
                    player.Play();
                }

                if (e.KeyCode == Keys.W)
                {
                    tab2 = 1;
                    foreach (CCirculo c in Circulo)
                    {

                        if (c.getTipo() == 2 && c.getHit() == 1)
                        {
                            an2 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            wplayer.settings.volume = 100;
                           
                            //player.SoundLocation = "kick.wav";
                            //player.Play();
                            return;
                        }
                    }
                    score = score - 15;
                    //player.SoundLocation = "slash2.wav";
                    player.Play();
               
                }

                if (e.KeyCode == Keys.I)
                {
                    tab3 = 1;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 3 && c.getHit() == 1)
                        {
                            an3 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            wplayer.settings.volume = 100;
                           
                            //        player.SoundLocation = "kick.wav";
                      //      player.Play();
                            return;
                        }
                    }
                    score = score - 15;
                 //   player.SoundLocation = "slash3.wav";
                    player.Play();
                           
                }

                if (e.KeyCode == Keys.O)
                {
                    tab4 = 1;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 4 && c.getHit() == 1)
                        {
                            an4 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            wplayer.settings.volume = 100;
                           
                            //         player.SoundLocation = "kick.wav";
                     //       player.Play();
                            return;
                        }
                    }
                    score = score - 15;
                    //player.SoundLocation = "slash4.wav";

                    player.Play();
                       
                }

                if (e.KeyCode == Keys.P)
                {
                    tab5 = 1;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 5 && c.getHit() == 1)
                        {
                            an5 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            wplayer.settings.volume = 100;
                           
                      //      player.SoundLocation = "kick.wav";
                        //    player.Play();
                            return;
                        }
                    }
                    score = score - 15;
                  //  player.SoundLocation = "slash5.wav";
                        player.Play();
                  
                }
                

            }

            if(minitimer<=2)
            minitimer++;

            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                tab1 = 0;
            }
            if (e.KeyCode == Keys.W)
            {
                tab2 = 0;
            }
            if (e.KeyCode == Keys.I)
            {
                tab3 = 0;
            }
            if (e.KeyCode == Keys.O)
            {
                tab4 = 0;
            }
            if (e.KeyCode == Keys.P)
            {
                tab5 = 0;
            }

            minitimer = 0;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            
                wplayer.URL = "Song2_touch.mp3";
                wplayer2.URL = "Song2_music.mp3";
           
    
                wplayer.controls.play();
                wplayer2.controls.play();

                wplayer2.settings.volume = 50;
               
                timer2.Enabled = false;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
