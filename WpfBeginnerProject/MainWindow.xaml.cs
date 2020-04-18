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
        }

        private void DivButtonClick(object sender, RoutedEventArgs e)
        {
            string input1 = numberField1.Text;
            string input2 = numberField2.Text;
            Int32.TryParse(input1, out int num1);
            Int32.TryParse(input2, out int num2);
            Rechner rechner = new Rechner();
            Result result = rechner.CalcDiv(num1, num2);
            numberField3.Text = result.result.ToString();
            numberField4.Text = result.remain.ToString();
        }
    }
}
