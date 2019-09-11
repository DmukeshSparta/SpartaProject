using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HelicopterGameProject
{
    //Name: Dipak Mukesh 
    //Project: Helicopter Game Project
    //Project Date: 09.09.2019 - 11.09.2019
    //What the program is about: To create Helicopter game, where the player 
    //can move by click or keyboard event. 
    //To calculate the distance: how far the player have travelled by avoiding obstacle 
    //To calculate the score: It keeps the old distance on the "Best score"
    
    public partial class MainWindow : Window
    {
        //Variables 
        int survive = 0; //this is a integer for player to calcuate player survive
        int playerspeed; //this is a integer will control how fast the player moves
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            playerspeed = 169; //starting position on the canvas 

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Ticker;
            timer.Start();
        }

        private void Ticker(object sender, EventArgs e)
        {
            //show the survive on the label 
            survive++;
            DistanceResult.Content = survive.ToString();

            List<Rectangle> pillaroflist = new List<Rectangle>()
            {
                Pillar1, Pillar2, Pillar3, Pillar4
            };

            // move pillar 1,2,3,4 towards the left of the screen
            //pillar 1 - top pillar
            double pillar1Left = Canvas.GetLeft(Pillar1);
            Canvas.SetLeft(Pillar1, pillar1Left - 50);

            //pillar 2 - right pillar
            double pillar2Left = Canvas.GetLeft(Pillar2);
            Canvas.SetLeft(Pillar2, pillar2Left - 40);

            //pillar 3 - left pillar 
            double pillar3Left = Canvas.GetLeft(Pillar3);
            Canvas.SetLeft(Pillar3, pillar3Left - 40);

            //pillar 4 - bottom pillar
            double pillar4Left = Canvas.GetLeft(Pillar4);
            Canvas.SetLeft(Pillar4, pillar4Left - 40);

            //pillar 1
            foreach (Rectangle r in pillaroflist)
            {
                //if pillar reaches 0 width then it will reset the pillar and start window width 
                if (Canvas.GetLeft(r) < 0)
                {
                    Canvas.SetLeft(r, 600);
                }
            }

            Rect heli = new Rect(Canvas.GetLeft(RectHeli), Canvas.GetTop(RectHeli), RectHeli.Width, RectHeli.Height);
            Rect rect1 = new Rect(Canvas.GetLeft(Pillar1), Canvas.GetTop(Pillar1), Pillar1.Width, Pillar1.Height);
            Rect rect2 = new Rect(Canvas.GetLeft(Pillar2), Canvas.GetTop(Pillar2), Pillar2.Width, Pillar2.Height);
            Rect rect3 = new Rect(Canvas.GetLeft(Pillar3), Canvas.GetTop(Pillar3), Pillar3.Width, Pillar3.Height);
            Rect rect4 = new Rect(Canvas.GetLeft(Pillar4), Canvas.GetTop(Pillar4), Pillar4.Width, Pillar4.Height);
            Rect rect5 = new Rect(Canvas.GetLeft(TitleRect), Canvas.GetTop(TitleRect), TitleRect.Width, TitleRect.Height);
            Rect rect6 = new Rect(Canvas.GetLeft(CalcuRect), Canvas.GetTop(CalcuRect), CalcuRect.Width, CalcuRect.Height);

            //if the helicopter collide with obstacle then it will stop the timer and 
            //print the message out. 
            if (rect1.IntersectsWith(heli) || rect2.IntersectsWith(heli) ||
                rect3.IntersectsWith(heli) || rect4.IntersectsWith(heli) ||
                rect5.IntersectsWith(heli) || rect6.IntersectsWith(heli))
            {
                timer.Stop();
                MessageBox.Show("Game is finished " + "\n" + "Final Result: " + survive.ToString());
                Close();
            }
        }

        private void MseDown(object sender, MouseButtonEventArgs e)
        {
            //if the player right click, the helicopter will move down
            if (e.LeftButton == MouseButtonState.Released)
            {
                double player = playerspeed += 20;
                RectHeli.SetValue(Canvas.TopProperty, player);
            }
        }

        private void MseUP(object sender, MouseButtonEventArgs e)
        {
            //if the player left click, the helicopter will move up
            if (e.LeftButton == Mouse.LeftButton)
            {
                double player = playerspeed -= 20;
                RectHeli.SetValue(Canvas.TopProperty, player);
            }
        }
    }
}
