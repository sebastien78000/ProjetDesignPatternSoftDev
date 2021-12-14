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

namespace ProjetDesignPatternSoftDev
{
    /// <summary>
    /// Logique d'interaction pour Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        public Game()
        {
            InitializeComponent();
        }
        private void ButtonRoll_Click(object sender, RoutedEventArgs e)
        {
            UpdateDice(1, 3);
            UpdateDice(2, 5);
            player1box.Opacity = 1;
        }

        private void UpdateDice(int number, int value)
        {
            if(number == 1)
            {
                if (value == 1)
                {
                    dice1x1.Opacity = 0;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 0;
                    dice1x4.Opacity = 0;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 0;
                    dice1x7.Opacity = 1;
                }
                if (value == 2)
                {
                    dice1x1.Opacity = 0;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 0;
                    dice1x7.Opacity = 0;
                }
                if (value == 3)
                {
                    dice1x1.Opacity = 0;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 0;
                    dice1x7.Opacity = 1;
                }
                if (value == 4)
                {
                    dice1x1.Opacity = 1;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 1;
                    dice1x7.Opacity = 0;
                }
                if (value == 5)
                {
                    dice1x1.Opacity = 1;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 1;
                    dice1x7.Opacity = 1;
                }
                if (value == 6)
                {
                    dice1x1.Opacity = 1;
                    dice1x2.Opacity = 1;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 1;
                    dice1x6.Opacity = 1;
                    dice1x7.Opacity = 0;
                }
            }
            if (number == 2)
            {
                if (value == 1)
                {
                    dice2x1.Opacity = 0;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 0;
                    dice2x4.Opacity = 0;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 0;
                    dice2x7.Opacity = 1;
                }
                if (value == 2)
                {
                    dice2x1.Opacity = 0;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 0;
                    dice2x7.Opacity = 0;
                }
                if (value == 3)
                {
                    dice2x1.Opacity = 0;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 0;
                    dice2x7.Opacity = 1;
                }
                if (value == 4)
                {
                    dice2x1.Opacity = 1;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 1;
                    dice2x7.Opacity = 0;
                }
                if (value == 5)
                {
                    dice2x1.Opacity = 1;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 1;
                    dice2x7.Opacity = 1;
                }
                if (value == 6)
                {
                    dice2x1.Opacity = 1;
                    dice2x2.Opacity = 1;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 1;
                    dice2x6.Opacity = 1;
                    dice2x7.Opacity = 0;
                }
            }
        }
        private void ButtonRollHovered(object sender, MouseEventArgs e)
        {
            GradientStopCollection Grad = new GradientStopCollection(2);
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFE63070"), 1));
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFFE8704"), 0));

            ButtonLogin.Background = new LinearGradientBrush(Grad, 0);
        }

        private void ButtonRollNotHovered(object sender, MouseEventArgs e)
        {
            GradientStopCollection Grad = new GradientStopCollection(2);
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#182454"), 1));
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#182454"), 0));

            ButtonLogin.Background = new LinearGradientBrush(Grad, 0);
        }

        private void MovePlayer(int player)
        {
        }
    }
}
