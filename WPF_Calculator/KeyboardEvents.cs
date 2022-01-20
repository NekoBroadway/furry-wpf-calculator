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

namespace WPF_Calculator
{
    public partial class MainWindow : Window
    {
         private void ButtonEvents(object sender, KeyEventArgs e)
    {
        RoutedEventArgs MouseClick = new RoutedEventArgs();
        MouseClick.RoutedEvent = MouseLeftButtonDownEvent;

        switch (e.Key)
        {
            case Key.Enter:
                ButtonCalc_Click(sender, MouseClick);
                break;

            case Key.NumPad0:
                ButtonAddZero_Click(sender, MouseClick);
                break;

            case Key.NumPad1:
                ButtonAddOne_Click(sender, MouseClick);
                break;

            case Key.NumPad2:
                ButtonAddTwo_Click(sender, MouseClick);
                break;

            case Key.NumPad3:
                ButtonAddThree_Click(sender, MouseClick);
                break;

            case Key.NumPad4:
                ButtonAddFour_Click(sender, MouseClick);
                break;

            case Key.NumPad5:
                ButtonAddFive_Click(sender, MouseClick);
                break;

            case Key.NumPad6:
                ButtonAddSix_Click(sender, MouseClick);
                break;

            case Key.NumPad7:
                ButtonAddSeven_Click(sender, MouseClick);
                break;

            case Key.NumPad8:
                ButtonAddEight_Click(sender, MouseClick);
                break;

            case Key.NumPad9:
                ButtonAddNine_Click(sender, MouseClick);
                break;

            case Key.Multiply:
                ButtonMulty_Click(sender, MouseClick);
                break;

            case Key.Divide:
                ButtonDivide_Click(sender, MouseClick);
                break;

            case Key.Add:
                ButtonPlus_Click(sender, MouseClick);
                break;

            case Key.Subtract:
                ButtonMinus_Click(sender, MouseClick);
                break;

            case Key.Delete:
                ButtonDeleteALL_Click(sender, MouseClick);
                break;

            case Key.Back:
                ButtonDelete_Click(sender, MouseClick);
                break;
        }
    }
}
}
