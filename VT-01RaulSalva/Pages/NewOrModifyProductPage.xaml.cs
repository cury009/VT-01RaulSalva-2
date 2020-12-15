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
    /// Lógica de interacción para NewOrModifyProductPage.xaml
    /// </summary>
    public partial class NewOrModifyProductPage : Page
    {
        public ProductHandler productoHandler;
        public Producto producto;
        public int pos;
        public bool verify;

        public NewOrModifyProductPage(ProductHandler productoHandler)
        {
            this.productoHandler = productoHandler;
        }
        // constructor de nuevo
        public NewOrModifyProductPage(string title, ProductHandler productoHandler)
        {
            InitializeComponent();
            titleNewOrModify.Text = title;
            this.productoHandler = productoHandler;
            this.verify = false;
            producto = new Producto();
            this.productoGrid.DataContext = producto;
        }

        //CONSTRUCTOR DE MODIFICAR
        public NewOrModifyProductPage(string title, ProductHandler productoHandler, Producto producto, int pos)
        {
            InitializeComponent();
            titleNewOrModify.Text = title;
            this.productoHandler = productoHandler;
            this.producto = producto;
            this.pos = pos;
            this.productoGrid.DataContext = producto;
            this.verify = true;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (verify)
            {
                productoHandler.ModifyProduct(producto, pos);
            }
            else
            {
                //String nombre = txt_Nombre.Text;
                //String telefono = txt_Telefono.Text;
                //DateTime fechaAlta = (DateTime)txt_fechaAlta.SelectedDate;
                //User user = new User(nombre, telefono, fechaAlta);
                productoHandler.AddProduct(producto);

            }


            MainWindow.myNavigationFrame.NavigationService.Navigate(new MainPage());


        }
    }
}
