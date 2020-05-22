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

namespace drankregistratie
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl1 uc = new UserControl1();
            overzichtdranken.Children.Clear();
            overzichtdranken.Children.Add(uc);
        }

        private void overzicht_dranken_Click(object sender, RoutedEventArgs e)
        {
            overzichtdranken uc = new overzichtdranken();
            overzichtdranken.Children.Clear();
            overzichtdranken.Children.Add(uc);
        }

        private void ID_ophalen_Click(object sender, RoutedEventArgs e)
        {
            IDophalen uc = new IDophalen();
            overzichtdranken.Children.Clear();
            overzichtdranken.Children.Add(uc);
        }
    }
}
