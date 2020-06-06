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

namespace Drankregistratie3
{
    /// <summary>
    /// Interaction logic for Dranken.xaml
    /// </summary>
    public partial class Dranken : UserControl
    {
        DataClasses1DataContext db;
        private dranken hetItem;
        public Dranken(dranken hetItem, DataClasses1DataContext db)
        {
            this.db = db;
            this.hetItem = hetItem;
            InitializeComponent();
            txtNaam.Text = hetItem.Naam;
            txtSoort.Text = hetItem.Soort;
            txtPrijs.Text = hetItem.Prijs.ToString();
        }

        private void Wijzig_btn_Click(object sender, RoutedEventArgs e)
        {
            hetItem.Naam = txtNaam.Text;
            hetItem.Soort = txtSoort.Text;
            hetItem.Prijs = Convert.ToDecimal(txtPrijs.Text);
            db.SubmitChanges();
        }

        private void Toevoeg_btn_Click(object sender, RoutedEventArgs e)
        {
            dranken deDrank = new dranken();
            deDrank.Naam = txtNaam.Text;
            deDrank.Soort = txtSoort.Text;
            deDrank.Prijs = Convert.ToDecimal(txtPrijs.Text);
            db.drankens.InsertOnSubmit(deDrank);
            db.SubmitChanges();
        }

        private void Verwijder_btn_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;
            if (Int32.TryParse(hetItem.ID.ToString(), out id))
            {
                var hetProduct = (from dranken in db.drankens
                                  where dranken.ID == id
                                  select dranken).Single();

                db.drankens.DeleteOnSubmit(hetProduct);
                db.SubmitChanges();
            }
        }
    }
}
