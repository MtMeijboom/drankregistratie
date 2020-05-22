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
    /// Interaction logic for IDophalen.xaml
    /// </summary>
    public partial class IDophalen : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IDophalen()
        {
            InitializeComponent();
                       
        }


        private void IDzoeken1_Click(object sender, RoutedEventArgs e)
        {
            string sWaarde = IDzoekentext.Text;

            //Lijst waar hij zoekt op Naam

            var list = db.drankens.Where(p => p.Naam.Contains(sWaarde)).ToList();
            lijst1.ItemsSource = list;
        }
    }
}
