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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        float sizeprice = 0;

        public int pann=0 ;
        public int count;
        public float addon=0;
        public static float totaal=0;
       


        public Window2()
        {

            InitializeComponent();



           

            UserN.Content = "Welcome" + "   " + MainWindow.Name;



        }

        public void addons()
        {
            Console.WriteLine("checked");
            count++;
            if (count > 3)
            {
                int extras = count - 3;
                addon = extras * 1;
            }
            else

            {
                addon = 0;
                

            }

            total.Content = (sizeprice + addon + pann).ToString() + "$";
            totaal = sizeprice + addon + pann;
        }
    
        public void removeaddons()
        {
            Console.WriteLine("unchecked");
            
            Console.WriteLine("before removing " + count);
            count--;
            if (count > 3)
            {
                int extras = count - 3;
                addon= extras * 1;
            }
            else

            {
                addon = 0;
               

            }

            total.Content = (sizeprice + addon + pann).ToString() + "$";
            totaal = sizeprice + addon + pann;
        }


        private void Medium_Checked(object sender, RoutedEventArgs e)
        {
            if (medium.IsChecked == true )


            {
                
                sizeprice = 8;

                total.Content = (sizeprice + addon + pann).ToString() + "$";
                totaal = sizeprice + addon + pann;
            }
           
        }

        private void Large_Checked(object sender, RoutedEventArgs e)
        {
            if (large.IsChecked == true)
            {
                sizeprice = 12;
                
                total.Content = (sizeprice + addon + pann).ToString() + "$";
                totaal = sizeprice + addon + pann;

            }
           
        }

        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            if (small.IsChecked == true)
            {
                sizeprice = 5;
                total.Content = (sizeprice + addon + pann).ToString() + "$";
                totaal = sizeprice + addon + pann;
            }
           
        }

        private void Thin_Checked(object sender, RoutedEventArgs e)
        {
            if (thin.IsChecked==true)
            {
                pann = 0;
                total.Content = (sizeprice + addon + pann).ToString() + "$";
                totaal = sizeprice + addon + pann;
            }
        }

        private void Pan_Checked(object sender, RoutedEventArgs e)
        {
             if ( pan.IsChecked == true )

            {
                pann = 2;
                total.Content = (sizeprice + addon + pann).ToString() + "$";
                totaal = sizeprice + addon + pann;
            }
            else
            {
                pann = 0;
                totaal = totaal - 2;
                total.Content = (sizeprice + addon + pann).ToString() + "$";
            }
            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            small.IsChecked = false;
            medium.IsChecked = false;
            large.IsChecked = false;
            thin.IsChecked = false;
            thick.IsChecked = false;
            pan.IsChecked = false;
            
            GreenOlive.IsChecked = false;
            BlackOlive.IsChecked = false;
            SGPepper.IsChecked = false;
            SRPepper.IsChecked = false;
            mashroom.IsChecked = false;
            RedOnion.IsChecked = false;
            pepproni.IsChecked = false;
            tomato.IsChecked = false;
            hotP.IsChecked = false;
            total.Content = " ";
            totaal = 0;

         //   MessageBox.Show(totaal.ToString());

        }

        private void GreenOlive_Checked(object sender, RoutedEventArgs e)
        {


            if (GreenOlive.IsChecked == true)
        {
                addons();
        }
            else
            {
                removeaddons();
            }
          
        }

        private void BlackOlive_Checked(object sender, RoutedEventArgs e)
        {
            if (BlackOlive.IsChecked == true)
            {
                addons();
            }
            else
            {
                removeaddons();
            }
        }

        private void SGPepper_Checked(object sender, RoutedEventArgs e)
        {
            if (SGPepper.IsChecked == true)
            {
                addons();
            }
            else
            {
                removeaddons();
            }
        }

        private void SRPepper_Checked(object sender, RoutedEventArgs e)
        {
            if(SRPepper.IsChecked==true)
            {
                addons();

            }
            else
            {
                removeaddons();

            }
        }

        private void Mashroom_Checked(object sender, RoutedEventArgs e)
        {
            if (mashroom.IsChecked == true)
            {
                addons();

            }
            else
            {
                removeaddons();

            }
        }

        private void RedOnion_Checked(object sender, RoutedEventArgs e)
        {
            if (RedOnion.IsChecked == true)
            {
                addons();

            }
            else
            {
                removeaddons();

            }
        }

        private void Pepproni_Checked(object sender, RoutedEventArgs e)
        {
            if (pepproni.IsChecked == true)
            {
                addons();

            }
            else
            {
                removeaddons();

            }
        }

        private void Tomato_Checked(object sender, RoutedEventArgs e)
        {
            if (tomato.IsChecked == true)
            {
                addons();

            }
            else
            {
                removeaddons();

            }
        }

        private void HotP_Checked(object sender, RoutedEventArgs e)
        {
            if (hotP.IsChecked == true)
            {
                addons();

            }
            else
            {
                removeaddons();

            }
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            Reciept R = new Reciept();
            R.Show();
            this.Hide();

        }

        private void Thick_Checked(object sender, RoutedEventArgs e)
        {
            if (thick.IsChecked==true)
            {
                pann = 0;
                total.Content =
                total.Content = (sizeprice + addon + pann).ToString() + "$";
                totaal = sizeprice + addon + pann;
            }
        }
    }
}
    


