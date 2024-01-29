using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] buttons;
        Random random = new Random();
        
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] {_1, _2, _3, _4, _5, _6, _7, _8, _9};
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (_1 as Button).IsEnabled = true;
            (_1 as Button).Content = "";
            (_2 as Button).IsEnabled = true;
            (_2 as Button).Content = "";
            (_3 as Button).IsEnabled = true;
            (_3 as Button).Content = "";
            (_4 as Button).IsEnabled = true;
            (_4 as Button).Content = "";
            (_5 as Button).IsEnabled = true;
            (_5 as Button).Content = "";
            (_6 as Button).IsEnabled = true;
            (_6 as Button).Content = "";
            (_7 as Button).IsEnabled = true;
            (_7 as Button).Content = "";
            (_8 as Button).IsEnabled = true;
            (_8 as Button).Content = "";
            (_9 as Button).IsEnabled = true;
            (_9 as Button).Content = "";
        }
        private void prosto_click(object sender, RoutedEventArgs e)
        {
            
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;

            int index = random.Next(buttons.Length);
            while (buttons[index].IsEnabled == false)
                index = random.Next(buttons.Length);

            buttons[index].Content = "O";
            buttons[index].IsEnabled = false;

            if ((_1 as Button).Content == "X" && (_2 as Button).Content == "X" && (_3 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false; 
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_4 as Button).Content == "X" && (_5 as Button).Content == "X" && (_6 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_7 as Button).Content == "X" && (_8 as Button).Content == "X" && (_9 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_1 as Button).Content == "X" && (_4 as Button).Content == "X" && (_7 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_2 as Button).Content == "X" && (_5 as Button).Content == "X" && (_8 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_3 as Button).Content == "X" && (_6 as Button).Content == "X" && (_9 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_1 as Button).Content == "X" && (_5 as Button).Content == "X" && (_9 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_3 as Button).Content == "X" && (_5 as Button).Content == "X" && (_7 as Button).Content == "X")
            {
                (win as Button).Content = "Кристики выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }

            else if ((_1 as Button).Content == "O" && (_2 as Button).Content == "O" && (_3 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_4 as Button).Content == "O" && (_5 as Button).Content == "O" && (_6 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_7 as Button).Content == "O" && (_8 as Button).Content == "O" && (_9 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_1 as Button).Content == "O" && (_4 as Button).Content == "O" && (_7 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_2 as Button).Content == "O" && (_5 as Button).Content == "O" && (_8 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_3 as Button).Content == "O" && (_6 as Button).Content == "O" && (_9 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_1 as Button).Content == "O" && (_5 as Button).Content == "O" && (_9 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }
            else if ((_3 as Button).Content == "O" && (_5 as Button).Content == "O" && (_7 as Button).Content == "O")
            {
                (win as Button).Content = "нолыки выигралы";
                (_1 as Button).IsEnabled = false;
                (_2 as Button).IsEnabled = false;
                (_3 as Button).IsEnabled = false;
                (_4 as Button).IsEnabled = false;
                (_5 as Button).IsEnabled = false;
                (_6 as Button).IsEnabled = false;
                (_7 as Button).IsEnabled = false;
                (_8 as Button).IsEnabled = false;
                (_9 as Button).IsEnabled = false;
            }

          

        }




    }
}
