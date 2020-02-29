using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOver.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coin(gamespeed);
            CoinsCollection();
        }

        int collectedCoin = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (Enemy1.Top >= 500)
            {
                x = r.Next(0, 200);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Enemy1.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Enemy1.Top += speed;
            }


            if (Enemy2.Top >= 500)
            {
                x = r.Next(0, 400);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Enemy2.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Enemy2.Top += speed;
            }


            if (Enemy3.Top >= 500)
            {
                x = r.Next(200, 350);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Enemy3.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Enemy3.Top += speed;
            }

        }

        void coin(int speed)
        {
            if (Coin1.Top >= 500)
            {
                x = r.Next(0, 200);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Coin1.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Coin1.Top += speed;
            }

            if (Coin2.Top >= 500)
            {
                x = r.Next(0, 200);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Coin2.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Coin2.Top += speed;
            }

            if (Coin3.Top >= 500)
            {
                x = r.Next(50, 300);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Coin3.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Coin3.Top += speed;
            }


            if (Coin4.Top >= 500)
            {
                x = r.Next(0, 400);//yolun solundaki koordinatlarda rastgele 
                //y koordinatı 0 cunku en tepede arabanın cıkmasını istiyoruz
                Coin4.Location = new Point(x, 0);//düsman kaybolunca yeniden doğmasını sağla

            }
            else
            {
                Coin4.Top += speed;
            }


        }


        void gameover()
        {
            if (Car.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }

            if (Car.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }

            if (Car.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }
        }




        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }
        int gamespeed = 0;


        void CoinsCollection()
        {
            if (Car.Bounds.IntersectsWith(Coin1.Bounds))
            {
                collectedCoin++;
                label1.Text = "Coins= " + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin1.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                collectedCoin++;
                label1.Text = "Coins= " + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin2.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin3.Bounds))
            {
                collectedCoin++;
                label1.Text = "Coins= " + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin3.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin4.Bounds))
            {
                collectedCoin++;
                label1.Text = "Coins= " + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin4.Location = new Point(x, 0);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(Car.Left>0)
                Car.Left += -8;
            }
             if (e.KeyCode == Keys.Right)
            {
                if(Car.Right<380)
                Car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {

                if (gamespeed < 21)

                { gamespeed++; }
            }
            if  (e.KeyCode == Keys.Down) { 
                if (gamespeed > 0)
                { gamespeed--; }
            }
             
        }
    }
}
