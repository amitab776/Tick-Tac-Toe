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

namespace Tick_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Counter = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            if (Convert.ToString(b.Content).Equals(""))
            {
                Counter++;
                Console.WriteLine(Counter);
                if (Counter % 2 == 0)
                    b.Content = "X";
                else
                    b.Content = "0";
                if (CheckForWinningMove(b))
                {
                    one.IsEnabled = false;
                    two.IsEnabled = false;
                    three.IsEnabled = false;
                    four.IsEnabled = false;
                    five.IsEnabled = false;
                    six.IsEnabled = false;
                    seven.IsEnabled = false;
                    eight.IsEnabled = false;
                    nine.IsEnabled = false;
                }
            }
        }

        private bool CheckForWinningMove(Button button)
        {
            var content = Convert.ToString(button.Content);
            if (!string.IsNullOrWhiteSpace(content) && Counter > 3 && !string.IsNullOrWhiteSpace(button.Name))
            {
                switch (button.Name.ToLower())
                {
                    case "one":
                        if (CheckWin(one, two, three, content))
                        {
                            return true;
                        }
                        else if (CheckWin(one, four, seven, content))
                        {
                            return true;
                        }
                        else if (CheckWin(one, five, nine, content))
                        {
                            return true;
                        }
                        return false;
                    case "two":
                        if (CheckWin(one, two, three, content))
                        {
                            return true;
                        }
                        else if (CheckWin(two, five, eight, content))
                        {
                            return true;
                        }
                        return false;
                    case "three":
                        if (CheckWin(one, two, three, content))
                        {
                            return true;
                        }
                        else if (CheckWin(three, six, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(three, five, seven, content))
                        {
                            return true;
                        }
                        return false;
                    case "four":
                        if (CheckWin(one, four, seven, content))
                        {
                            return true;
                        }
                        else if (CheckWin(five, four, six, content))
                        {
                            return true;
                        }
                        return false;
                    case "five":
                        if (CheckWin(five, four, six, content))
                        {
                            return true;
                        }
                        else if (CheckWin(five, two, eight, content))
                        {
                            return true;
                        }
                        else if (CheckWin(one, five, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(three, five, seven, content))
                        {
                            return true;
                        }
                        return false;
                    case "six":
                        if (CheckWin(three, six, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(five, four, six, content))
                        {
                            return true;
                        }
                        return false;
                    case "seven":
                        if (CheckWin(one, four, seven, content))
                        {
                            return true;
                        }
                        else if (CheckWin(seven, eight, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(three, five, seven, content))
                        {
                            return true;
                        }
                        return false;
                    case "eight":
                        if (CheckWin(seven, eight, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(two, five, eight, content))
                        {
                            return true;
                        }
                        return false;
                    case "nine":
                        if (CheckWin(seven, eight, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(three, six, nine, content))
                        {
                            return true;
                        }
                        else if (CheckWin(one, five, nine, content))
                        {
                            return true;
                        }
                        return false;
                }
            }
            return false;
        }

        private bool CheckWin(Button b1, Button b2, Button b3, string content)
        {
            if (Convert.ToString(b1.Content).Equals(content) && Convert.ToString(b2.Content).Equals(content) && Convert.ToString(b3.Content).Equals(content))
            {
                return true;
            }
            return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            one.IsEnabled = true;
            one.Content = "";
            two.IsEnabled = true;
            two.Content = "";
            three.IsEnabled = true;
            three.Content = "";
            four.IsEnabled = true;
            four.Content = "";
            five.IsEnabled = true;
            five.Content = "";
            six.IsEnabled = true;
            six.Content = "";
            seven.IsEnabled = true;
            seven.Content = "";
            eight.IsEnabled = true;
            eight.Content = "";
            nine.IsEnabled = true;
            nine.Content = "";
            Counter = 0;
        }
    }
}
