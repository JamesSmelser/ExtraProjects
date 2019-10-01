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

namespace ProjectWPF9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Borussia Dortmund", Team2 = "PSG", Score1 = 5, Score2 = 1, Completion = 55 });
            matches.Add(new Match() { Team1 = "Barca", Team2 = "AS Roma", Score1 = 2, Score2 = 4, Completion = 20 });
            matches.Add(new Match() { Team1 = "Manchester United", Team2 = "LA Galaxy", Score1 = 1, Score2 = 2, Completion = 42 });
            matches.Add(new Match() { Team1 = "FC Nurnberg", Team2 = "Hannover 96", Score1 = 6, Score2 = 2, Completion = 70 });
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show($"Match:  {(lbMatches.SelectedItem as Match).Team1}: {(lbMatches.SelectedItem as Match).Score1}  |  {(lbMatches.SelectedItem as Match).Score2} :{(lbMatches.SelectedItem as Match).Team2}  -  {90 - (lbMatches.SelectedItem as Match).Completion} minutes remaining");
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
