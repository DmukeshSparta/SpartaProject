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
        int playerspeed = 5; //this is a integer will control how fast the player moves
        int obspeed = 5; //this is a speed of obstacles 

        public MainWindow()
        {
            InitializeComponent();
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

        private void Gameplay (object sender, EventArgs e)
        {
            // move pillar 1 towards the left of the screen
            Pillar1.Height -= obspeed;
            Pillar1.Width -= obspeed;
            
            // move pillar 2 towards the left of the screen
            Pillar2.Height -= obspeed;
            Pillar2.Width -= obspeed;

            //show the distance on the label 
            DistanceResult.Content = distance;

            if (moveUp)
            {
                btnHelicopter -= playerspeed;
            }

            if (moveDown)
            {
                btnHelicopter += playerspeed;
            }


        }



    }
}
