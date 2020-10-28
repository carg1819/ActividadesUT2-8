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

namespace ActividadesUT2_8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombretxtBox.Tag = nomayudatxtBlock;
            apellidotxtBox.Tag = apellayudatxtBlock;
        }

        private void stringTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBlock aviso = (sender as TextBox).Tag as TextBlock;
            if (e.Key == Key.F1)
            {
                aviso.Visibility = Visibility.Visible;
            }
            else if(e.Key == Key.F2)
            {
                aviso.Visibility = Visibility.Hidden;
            }
        }


        private void intTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !int.TryParse((sender as TextBox).Text, out _))
            {
                edadayudatxtBlock.Visibility = Visibility.Visible;
            }
            else if (e.Key == Key.F2 && int.TryParse((sender as TextBox).Text, out _))
            {
                edadayudatxtBlock.Visibility = Visibility.Hidden;
            }
        }

        
    }
}
