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

namespace TicTacToeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Button b;

        bool endGame;

        Player player = new Player();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void EndCondition()
        {
            if ((button1.Content == button2.Content) && (button2.Content == button3.Content) && (!button2.IsEnabled) ||
                (button4.Content == button5.Content) && (button5.Content == button6.Content) && (!button5.IsEnabled) ||
                (button7.Content == button8.Content) && (button8.Content == button9.Content) && (!button8.IsEnabled) ||
                (button1.Content == button4.Content) && (button4.Content == button7.Content) && (!button4.IsEnabled) ||
                (button2.Content == button5.Content) && (button5.Content == button8.Content) && (!button5.IsEnabled) ||
                (button3.Content == button6.Content) && (button6.Content == button9.Content) && (!button6.IsEnabled) ||
                (button1.Content == button5.Content) && (button5.Content == button9.Content) && (!button5.IsEnabled) ||
                (button3.Content == button5.Content) && (button5.Content == button7.Content) && (!button5.IsEnabled)
                )
            {
                endGame = true;
                MessageBox.Show(player.PlayerTurn + " won the game.");
            }
            if (endGame == false && player.Counter == 9)
            {
                MessageBox.Show("It's a draw");
            }
        }

        private void button_OnClick(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            b.Content = player.PlaySymbol();
            b.IsEnabled = false;
            EndCondition();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
