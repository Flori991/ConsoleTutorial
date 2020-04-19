using BeginnerProject;
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

namespace WpfBeginnerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gamedata game = new Gamedata();
            game.ReadCsvData();
        }

        private void DivButtonClick(object sender, RoutedEventArgs e)
        {
        }

        private void TestClick(object sender, RoutedEventArgs e)
        {
            var test = BadstraßePanel.Children;
            Label label = (Label)test[0];
            label.Background = Brushes.Red;
        }
    }
}
