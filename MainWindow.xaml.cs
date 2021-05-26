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
        int round = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Coordinates_X(object sender, RoutedEventArgs e)
        {
        }
        private void Coordinates_1(object sender, RoutedEventArgs e)
        {
        }
        public void GameBoard_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
            var row = new RowDefinition();
            row.Height = new GridLength(45);
            GameBoard.RowDefinitions.Add(row);
            var col = new ColumnDefinition();
            col.Width = new GridLength(45);
                GameBoard.ColumnDefinitions.Add(col);
            for (int j = 0; j < 10; j++)
            {
                var button = new Button();
                button.Content = 0;
                button.Click += new RoutedEventHandler((a, b) => {
                    if (round < 10)
                    {
                        button.Content = 1;
                        round++;
                    }
                    else
                    {
                        button.Content = 0;
                    }
                    // Jag hade tänkt här att göra en switch av något slag som tog in värden från de olika knapparna och sparade dem i 2 olika listor
                    // En för spelare 1 och en för spelare 2 som sparat alla skepp som sätts ut med ett värde på 1 och vatten värde 0
                    // när man väl träffat ett motståndar skepp så hade värdet på den knappen säts om till o 
                    // Då hade en annan funktion kollat av om listans värde var lika med 0 och skrivit ut att den spelare som sänkt alla skepp vunnnit
                });
                Grid.SetRow(button, i);
                Grid.SetColumn(button, j);
                GameBoard.Children.Add(button);
                }
            }
        }
        public void Game()
        {
            // Det skulle funnits en funktion som tagit "block" som skulle varit de olika skeppen och satt ett värde på 1-4 knappar i rad
            // Skeppen skulle ärva funktionalitet av varandra och öka storleken med 1 
            // Det skulle funnits en gräns för skeppen så att de inte skulle kunna sättas utanför spelplanen 
            // Och skeppen skulle kunna roteras med hjälp av horisontalalignment / verticalalignment
            var turn = 0;
            var player1Turns = true;
            while (true)
            {
                turn++;
                if (player1Turns)
                {
                    //spelare 1 spelare
                }
                else
                {
                    // Här är en enkel funktion som roterar omgångarna mellan spelare ett och två
                    // Input från denna loop hade tagits för att bestämma vilken lista som input från knapparna skulle sparats i 
                    //spelare 2 spelar
                }
                if (turn % 3 == 0)
                {
                    player1Turns = !player1Turns;
                }
            }
        }
      //   int[,] buttonListPlayer1 = new int[10, 10];
      //   var Row = Grid.GetRow(button);
      //   var Column = Grid.GetColumn(button);
      //   buttonListPlayer1[Row, Column] = 1;
    }

   





   












}

