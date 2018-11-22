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
using System.Windows.Shapes;

namespace PIZZAProject
{


    /// <summary>
    /// Interaction logic for Reciept.xaml
    /// </summary>
    public partial class Reciept : Window
    {
        public float hst;
        public float final;



        public Reciept()
        {
            InitializeComponent();
            UserN1.Content = "Welcome" + "   " + MainWindow.Name;

            totalb.Content = Window2.totaal ;

            HstTx.Content = (Window2.totaal * (13.00f))/100;

            totalAftTx.Content = (Window2.totaal * 0.13 )+ Window2.totaal ;



        }

        private void Neworder_Click(object sender, RoutedEventArgs e)
        {
            Window2 win3 = new Window2();
            win3.Show();
            this.Hide();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
          

        }

        
    }
}
