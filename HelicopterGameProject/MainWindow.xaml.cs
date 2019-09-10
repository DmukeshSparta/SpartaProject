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
        bool moveUp; //this is a boolean to allow player to move up
        bool moveDown; //this is a boolan to allow player to move down
        int score = 0; //this is a integer for player to keep score
        int distance = 0; //this is a integer for player to calcuate the distance
        int playerspeed = 2; //this is a integer will control how fast the player moves
        int obspeed = 2; //this is a speed of obstacles 
        private EventHandler timer_Tick;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void OnClickUp(object sender, MouseEventArgs e)
        {
          if (e.LeftButton == Mouse.LeftButton)
            {
                moveUp = false;
            }

          if(e.LeftButton == MouseButtonState.Released)
            {
                moveDown = false;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                 moveUp = false;
            }

            if(e.Key == Key.Down)
            {
                moveDown = false;
            }
        }

        private void OnClickDown(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == Mouse.LeftButton)
            {
                moveDown = true;
            }

            if(e.LeftButton == MouseButtonState.Released)
            {
                moveDown = false;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {
                moveUp = true;
            }

            if(e.Key == Key.Down)
            {
                moveDown = true;
            }
        }

        private void Gameplay(object sender, EventArgs e)
        {
            // move pillar 1 towards the left of the screen
            Rect rect1 = new Rect(Canvas.GetLeft(Pillar1), Canvas.GetTop(Pillar1), Pillar1.Width, Pillar1.Height);
            Rect rect2 = new Rect(Canvas.GetLeft(Pillar1), Canvas.GetTop(Pillar1), Pillar1.Width, Pillar2.Height);
            Rect rect3 = new Rect(Canvas.GetLeft(Pillar1), Canvas.GetTop(Pillar1), Pillar1.Width, Pillar3.Height);

            //show the distance on the label 
            DistanceResult.Content = distance;

            if (moveUp)
            {
                Canvas.SetLeft(btnHelicopter, 100);
                Canvas.SetTop(btnHelicopter, 10);
            }

            if (moveDown)
            {
                Canvas.SetLeft(btnHelicopter, 100);
                Canvas.SetTop(btnHelicopter, 10);
            }

           /* if (Canvas.GetLeft(Pillar1))
            {

            }
            if (btnHelicopter.IntersectsWith(rect1.Bounds) ||
                btnHelicopter.IntersectsWith(rect2.Bounds) ||
                 btnHelicopter.IntersectsWith(rect3.Bounds) 
                )
            {

            }*/
        }
    }
}
