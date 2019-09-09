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
using System.Windows.Shapes;
using System.Reflection;
using System.IO;
using System.Drawing;

namespace HelicopterGameProject
{
    //Name: Dipak Mukesh 
    //Project: Helicopter Game Project
    //Project Date: 09.09.2019 - 11.09.2019
    //What the program is about: Welcome Message Splash Screen 
    //player press "Space" to start the game and it will take the player to 
    //main window, where the player plays the game. 
    public partial class MessageScreen : Window
    {
        public MessageScreen()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, KeyEventArgs e)
        {
            //press "Space" key to start the game
            if (e.Key == Key.Space)
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
