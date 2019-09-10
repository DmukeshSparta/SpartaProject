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
        int playerspeed = 0; //this is a integer will control how fast the player moves
        int obspeed = 0; //this is a speed of obstacles 

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Ticker;
            timer.Start();
        }

        private void Ticker (object sender, EventArgs e)
        {
            //show the distance on the label 
            distance++;

            DistanceResult.Content = distance.ToString();
        }

        private void OnClickUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == Mouse.LeftButton)
            {
                //if the player click left button 
                //the player the MoveUp to true
                moveUp = false;

            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                //if the player release left button 
                //the player the MoveDown to true
                moveDown = false;
              
            }
        }

        private void OnClickDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == Mouse.LeftButton)
            { 
                //if the player click left button 
                //the player the MoveUp to false
                moveUp = true;
            }

            if(e.LeftButton == MouseButtonState.Released)
            {
               //if the player release the left button
               //the player MoveDown to false
               moveDown = true;
            }
        }

        private void Gameplay(object sender, EventArgs e)
        {
            // move pillar 1,2,3 towards the left of the screen
            double obstaclespeed = obspeed -= 5;
            Canvas.SetLeft(Pillar1, obstaclespeed);
            Canvas.SetLeft(Pillar2, obstaclespeed);
            Canvas.SetLeft(Pillar3, obstaclespeed);
            
            if (moveUp)
            {
                double Player = playerspeed -= 10;
                btnHelicopter.SetValue(Canvas.LeftProperty, Player);
                btnHelicopter.SetValue(Canvas.TopProperty, Player);
            }

            if (moveDown)
            {
                double Player = playerspeed += 10;
                btnHelicopter.SetValue(Canvas.LeftProperty, Player);
                btnHelicopter.SetValue(Canvas.TopProperty, Player);
            }

           /* if (btnHelicopter.IntersectsWith(Pillar1) ||
                btnHelicopter.IntersectsWith(Pillar2) ||
                 btnHelicopter.IntersectsWith(Pillar3) ||
                  btnHelicopter.IntersectsWith(TitleRect) ||
                   btnHelicopter.IntersectsWith(CalcuRect)
                )
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Stop();
                MessageBox.Show("you hit the obstacle" + DistanceResult);
            }*/
        }
    }
}
