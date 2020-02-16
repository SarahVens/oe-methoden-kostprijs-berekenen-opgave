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

namespace MethodenKostprijsBerekenen.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        //Methoden
        #region Methoden
        double BerekenTotaalPrijs(double dagPrijs, int aantaldagen)
        {
            double totalePrijs;
            totalePrijs = dagPrijs * aantaldagen;
            return totalePrijs;
        } 
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        //eventhandlers
        #region Event Handlers
        private void btnBerekenTotaalPrijs_Click(object sender, RoutedEventArgs e)
        {
            double dagPrijs = double.Parse(txtDagPrijs.Text);
            int aantalDagen = int.Parse(txtAantalDagen.Text);
            double totalePrijs;
            totalePrijs = BerekenTotaalPrijs(dagPrijs, aantalDagen);
            lblTotaalPrijs.Content = totalePrijs.ToString("0.00");
        }

        private void sldAantalDagen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            txtAantalDagen.Text = sldAantalDagen.Value.ToString("0");
        } 
        #endregion
    }
}
