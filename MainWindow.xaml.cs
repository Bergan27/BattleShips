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

namespace BattleShips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GameBoard_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
            var row = new RowDefinition();
            row.Height = new GridLength(45);
            GameBoard.RowDefinitions.Add(row);
            var col = new ColumnDefinition();
            col.Width = new GridLength(50);
                GameBoard.ColumnDefinitions.Add(col);
            for (int j = 0; j < 10; j++)
            {
                var button = new Button();
                button.Click += new RoutedEventHandler((a, b) => {
                    button.Content = "träff";
                });
                Grid.SetRow(button, i);
                Grid.SetColumn(button, j);
                    GameBoard.Children.Add(button);
            }
            }
        }
    }
}

