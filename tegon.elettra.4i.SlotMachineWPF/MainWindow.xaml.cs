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

using elettra.tegon._4i.SlotMachineLibreria;
namespace tegon.elettra._4i.SlotMachineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SlotMachineLib s = new SlotMachineLib(10);
        bool b1 = false;
        bool b2 = false;
        bool b3 = false;
        int cont = 3;


        public MainWindow()
        {
            InitializeComponent();

        }

        private void giri()
        {
            if (cont == 3)
            {
                s.Monete--;
                cont = 0;

            }
        }
        private void btnSlot_Click(object sender, RoutedEventArgs e)
        {
            giri();
            cont++;
            if (b1 == true)
            {
                if (b2 == true)
                {
                    s.carte("12");
                }
                else if (b3 == true)
                {
                    s.carte("13");
                }
                else
                {
                    s.carte("1");
                }

            }
            else if (b2 == true)
            {

                if (b3 == true)
                {
                    s.carte("23");
                }
                else
                {
                    s.carte("2");
                }
            }
            else if (b3 == true)
            {
                s.carte("3");
            }
            else
            {
                s.carte();
            }


            DesAlt.Text = Convert.ToString(s.Val1);
            CentAlt.Text = Convert.ToString(s.Val2);
            SinAlt.Text = Convert.ToString(s.Val3);

            SinBass.Text = Convert.ToString(s.Monete);


        }
        private void btnBlock1_CLick(object sender, RoutedEventArgs e)
        {
            if (b1 == false)
            {

                b1 = true;
            }
            else
            {
                b1 = false;
            }
        }
        private void btnBlock2_CLick(object sender, RoutedEventArgs e)
        {
            if (b2 == false)
            {

                b2 = true;
            }
            else
            {
                b2 = false;
            }
        }
        private void btnBlock3_CLick(object sender, RoutedEventArgs e)
        {
            if (b3 == false)
            {

                b3 = true;
            }
            else
            {
                b3 = false;
            }
        }
        private void btnritiro_CLick(object sender, RoutedEventArgs e)
        {
            s.cambioMonete();
        }
    }
}   

