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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void drankeninvoer_Click(object sender, RoutedEventArgs e)
        {
            dranken deDrank = new dranken();
            deDrank.Naam = dranknaam.Text;
            deDrank.Soort = dranksoort.Text;
            deDrank.Prijs = Convert.ToDecimal(drankprijs.Text);
            db.drankens.InsertOnSubmit(deDrank);
            db.SubmitChanges();
        }
    }
}
