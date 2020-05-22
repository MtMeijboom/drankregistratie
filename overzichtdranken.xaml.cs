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
    /// Interaction logic for overzichtdranken.xaml
    /// </summary>
    public partial class overzichtdranken : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public overzichtdranken()
        {
            InitializeComponent();

            lijst.ItemsSource = db.drankens.ToList();
        }
    }
}
