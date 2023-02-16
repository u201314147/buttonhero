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
        double bpmreset = 170.0;
        Random y = new Random();
        Random x = new Random();
        Random r = new Random();

        int frame = 0;
        int frameskip = 5;
        int maxNotas = 0;
        double bpmadded = 0;
        double speed = 0;
        double bpmcount =0;
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
        int phitcount = 1;
      //  int megatimer = 0;
          int minitimer = 0;
        int timeEspera = 0;
        int tab1;
        int tab2;
        int tab3;
        int tab4;
        int tab5;
        int tab6;
        int tab7;
        int tab8;
        String file;
        List<CCirculo> Circulo;
        List<CCirculo> Circulos2;
        System.Media.SoundPlayer player;
                
                 WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                 WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
       


        public Form1(double bpm, double repeattime, int maxNotes, int pTimeWait, double bpmadd, String pFile)
        {
            speed = bpm;
            bpmreset = repeattime;
            maxNotas = maxNotes;
            bpmadded = bpmadd;
            timeEspera = pTimeWait;
            bpmcount = bpmcount - timeEspera;
            file = pFile;
            player = new System.Media.SoundPlayer();
            player.SoundLocation = "slash5.wav";
            Circulos2 = new List<CCirculo>();
            Circulo = new List<CCirculo>();


             wplayer2.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
          

            InitializeComponent();

        button1.Enabled = false;
            button1.Visible = false;
           tab1=0 ; tab2=0; tab3=0; tab4=0; tab5=0;

           

        }


         private void wplayer_PlayStateChange(int NewState)
          {
              if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
              {
                timer1.Enabled = false;
                MessageBox.Show("TU PUNTAJE FINAL ES: " + score);

                
                this.Close();
              }
           
        }

        private void AddCirc(int pY, int pX, int pTipo, int phitCount, int plasthit)
        {
        CCirculo circ;

            Circulo.Add(circ = new CCirculo(pY, pX, pTipo, phitCount, plasthit));
        }

        private void AddCirc2(int pY, int pX, int pTipo, int phitCount, int plasthit)
        {
            CCirculo circ;

            Circulos2.Add(circ = new CCirculo(pY, pX, pTipo, phitCount, plasthit));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frame = frame + 1;
            bpmcount = bpmcount + bpmadded;

            if (bpmcount > bpmreset)
            {
                Circulo.Clear();
                Circulos2.Clear();
                int max = y.Next(0, maxNotas);
                for (int i = 0; i <= max; i++)
                {

                    int select = x.Next(1, 9);
                    int select2 = r.Next(select, 9);

                    int selectrandom = x.Next(select, select2);
                    int selectmax = r.Next(1, 6);
                    if (i < max)
                        AddCirc(-10, 50 + i * 50, selectrandom, i + 1, 0);



                    if (i == max)
                        AddCirc(-10, 50 + i * 50, selectmax, i + 1, 1);


                    //AGREGADO VISION 


                    if (i < max)
                        AddCirc2(300, 50 + i * 50, selectrandom, i + 1, 0);


                    if (i == max)
                        AddCirc2(300, 50 + i * 50, selectmax, i + 1, 1);
                }



                phitcount = 1;
                bpmcount = 0;
            }




            if (score < 0)
                score = 0;

            if (frame == frameskip)
            {

            
            Graphics g = this.CreateGraphics();
            BufferedGraphicsContext contexto = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = contexto.Allocate(g, this.DisplayRectangle);
            //buffer.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            buffer.Graphics.Clear(Color.Black);
            buffer.Graphics.DrawRectangle(Pens.Black, 50, 500, 500, 50);

            buffer.Graphics.FillRectangle(Brushes.LightGray, 54, 1, 495, 600);

            /*buffer.Graphics.DrawRectangle(Pens.Black, 50, 500, 500, 50);
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
            */
            foreach (CCirculo c in Circulo)
            {
                c.dibujar(buffer.Graphics);
                c.mover(speed);
                c.hitV();
                if (c.dropMusic() == 1)
                    wplayer.settings.volume = 0;
            }

            buffer.Graphics.FillEllipse(Brushes.DarkGreen, 48, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkRed, 148, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DeepPink, 248, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkBlue, 348, 448, 104, 54);
            buffer.Graphics.FillEllipse(Brushes.DarkGoldenrod, 448, 448, 104, 54);
                
                //SE DIBUJAN AL FINAL
                foreach (CCirculo c in Circulos2)
                {
                    c.dibujar(buffer.Graphics);

                }
                frame = 0;

                buffer.Render();

            }
            /*if(tab1==0)
            buffer.Graphics.FillEllipse(Brushes.Green, 50, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.LightGreen, 50, 450, 100, 50);

            if (tab2 == 0)
            buffer.Graphics.FillEllipse(Brushes.Red, 150, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.Pink, 150, 450, 100, 50);

            if (tab3 == 0)
            buffer.Graphics.FillEllipse(Brushes.LightPink, 250, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.Pink, 250, 450, 100, 50);

            if (tab4 == 0)
            buffer.Graphics.FillEllipse(Brushes.Blue, 350, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.LightBlue, 350, 450, 100, 50);

            if (tab5 == 0 && tab6 == 0 && tab7 ==0 && tab8 ==0)      
            buffer.Graphics.FillEllipse(Brushes.Orange, 450, 450, 100, 50);
            else
                buffer.Graphics.FillEllipse(Brushes.Gold, 450, 450, 100, 50);

            */
            if (an1 == 1)
            {
               /* if(minitimerA1==1)
                buffer.Graphics.FillEllipse(Brushes.White, 30, 440, 140, 60);

                if(minitimerA1==2)
                    buffer.Graphics.FillEllipse(Brushes.White, 55, 455, 90, 40);

                if(minitimerA1==3)
                    buffer.Graphics.FillEllipse(Brushes.White, 60, 460, 80, 30);

                if(minitimerA1==4)
                    buffer.Graphics.FillEllipse(Brushes.White, 65, 465, 70, 20);
               */
                minitimerA1++;

                if (minitimerA1 == 6)
                {
                    an1 = 0;
                    minitimerA1 = 0;
                }
            }


            if (an2 == 1)
            {
                /*if (minitimerA2 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 130, 440, 140, 60);

                if (minitimerA2 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 155, 455, 90, 40);

                if (minitimerA2 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 160, 460, 80, 30);

                if (minitimerA2 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 165, 465, 70, 20);
                */
                minitimerA2++;

                if (minitimerA2 == 6)
                {
                    an2 = 0;
                    minitimerA2 = 0;
                }
            }

            if (an3 == 1)
            {
                /*if (minitimerA3 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 230, 440, 140, 60);

                if (minitimerA3 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 255, 455, 90, 40);

                if (minitimerA3 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 260, 460, 80, 30);

                if (minitimerA3 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 265, 465, 70, 20);
                */
                minitimerA3++;

                if (minitimerA3 == 6)
                {
                    an3 = 0;
                    minitimerA3 = 0;
                }
            }

            if (an4 == 1)
            {
             /*   if (minitimerA4 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 330, 440, 140, 60);

                if (minitimerA4 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 355, 455, 90, 40);

                if (minitimerA4 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 360, 460, 80, 30);

                if (minitimerA4 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 365, 465, 70, 20);
             */
                minitimerA4++;

                if (minitimerA4 == 6)
                {
                    an4 = 0;
                    minitimerA4 = 0;
                }
            }


            if (an5 == 1)
            {
               /* if (minitimerA5 == 1)
                    buffer.Graphics.FillEllipse(Brushes.White, 430, 440, 140, 60);
               
                if (minitimerA5 == 2)
                    buffer.Graphics.FillEllipse(Brushes.White, 455, 455, 90, 40);

                if (minitimerA5 == 3)
                    buffer.Graphics.FillEllipse(Brushes.White, 460, 460, 80, 30);

                if (minitimerA5 == 4)
                    buffer.Graphics.FillEllipse(Brushes.White, 465, 465, 70, 20);
               */
                minitimerA5++;

                if (minitimerA5 == 6)
                {
                    an5 = 0;
                    minitimerA5 = 0;
                }
            }

          

            label1.Text ="Score :" + score.ToString() + " Count: " + phitcount.ToString();

            /*if (megatimer == 4800)
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                button1.Visible = true;
                buffer.Render();
                button1.Text = "Puntuación Final" + "\n" + score.ToString() + "\n" + "Reiniciar";
           
            }

            
            megatimer++;
            */

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Application.Restart();
            }
            if (minitimer<2)
            {
                if (e.KeyCode == Keys.Z)
                {
                    tab1 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 1 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            an1 = 1;
                            score = score + 45;

                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            phitcount = phitcount + 1;
                            //      player.SoundLocation = "kick.wav";
                            //        player.Play();
                            wplayer.settings.volume = 100;
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                 //   player.Play();
                }

                if (e.KeyCode == Keys.X)
                {
                    tab2 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {

                        if (c.getTipo() == 2 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            an2 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //player.SoundLocation = "kick.wav";
                            //player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                    //player.SoundLocation = "slash2.wav";
                 //   player.Play();
               
                }
                
                if (e.KeyCode == Keys.C)
                {
                    tab3 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 3 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            an3 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //        player.SoundLocation = "kick.wav";
                            //      player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                 //   player.SoundLocation = "slash3.wav";
                //    player.Play();
                           
                }

                if (e.KeyCode == Keys.V)
                {
                    tab4 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 4 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            an4 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //         player.SoundLocation = "kick.wav";
                            //       player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                    //player.SoundLocation = "slash4.wav";

                  //  player.Play();
                       
                }

                if (e.KeyCode == Keys.Left)
                {
                    tab5 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 5 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            an5 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //      player.SoundLocation = "kick.wav";
                            //    player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                  //  player.SoundLocation = "slash5.wav";
                  //      player.Play();
                  
                }

                if (e.KeyCode == Keys.Right)
                {
                    tab6 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 6 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                        
                           // an5 = 1;
                            score = score + 45;
                            
                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            
                            // wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //      player.SoundLocation = "kick.wav";
                            //    player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                    //  player.SoundLocation = "slash5.wav";
                    //      player.Play();

                }

                if (e.KeyCode == Keys.Up)
                {
                    tab7 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 7 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            // an5 = 1;
                            score = score + 45;

                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            // wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //      player.SoundLocation = "kick.wav";
                            //    player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                    //  player.SoundLocation = "slash5.wav";
                    //      player.Play();

                }

                if (e.KeyCode == Keys.Down)
                {
                    tab8 = 1;
                    int i = 0;
                    foreach (CCirculo c in Circulo)
                    {
                        if (c.getTipo() == 8 && c.getHit() == 1 && c.getHitCount() == phitcount)
                        {
                            // an5 = 1;
                            score = score + 45;
                            Circulo.Remove(c);
                            Circulos2.RemoveAt(i);
                            // wplayer.settings.volume = 100;

                            phitcount = phitcount + 1;
                            //      player.SoundLocation = "kick.wav";
                            //    player.Play();
                            i = i + 1;
                            return;
                        }
                    }
                    score = score - 15;
                    //  player.SoundLocation = "slash5.wav";
                    //      player.Play();

                }

            }

            if(minitimer<=2)
            minitimer++;

          



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Z)
            {
                tab1 = 0;
            }
            if (e.KeyCode == Keys.X)
            {
                tab2 = 0;
            }
            if (e.KeyCode == Keys.C)
            {
                tab3 = 0;
            }
            if (e.KeyCode == Keys.V)
            {
                tab4 = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                tab5 = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                tab6 = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                tab7 = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                tab8 = 0;
            }

            minitimer = 0;

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            wplayer2.URL = file;
            // wplayer.URL = "Song2_touch1.mp3";
           // wplayer2.URL = "Song2_music1.mp3";
           
    
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            wplayer2.controls.pause();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
