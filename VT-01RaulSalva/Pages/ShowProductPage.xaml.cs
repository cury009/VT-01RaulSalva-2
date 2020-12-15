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
using VT_01RaulSalva.ProductClass;

namespace VT_01RaulSalva.Pages
{
    /// <summary>
    /// Lógica de interacción para ShowProductPage.xaml
    /// </summary>
    public partial class ShowProductPage : Page
    {
        public ProductHandler productHandler;
        public Producto producto;
        public int pos;
        public ShowProductPage(ProductHandler productHandler)
        {
            InitializeComponent();
            this.productHandler = productHandler;
            comboProduct.DataContext = productHandler;
            pos = comboProduct.SelectedIndex;
            buttonsPanel.Visibility = Visibility.Hidden;
            
        }

        private void comboProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            producto = (Producto)comboProduct.SelectedItem;
            productDataGrid.DataContext = producto;
            pos = comboProduct.SelectedIndex;
            buttonsPanel.Visibility = Visibility.Visible;
        }
         
        //BORRAR
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.myNavigationFrame.NavigationService.Navigate(new NewOrModifyProductPage("Modificar producto", productHandler, (Producto)producto.Clone(), pos));
        }

        //MODIFICAR
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

