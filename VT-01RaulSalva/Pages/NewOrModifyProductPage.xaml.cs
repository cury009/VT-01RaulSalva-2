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

        private bool Validation()
        {

            bool validate = true;

            foreach (UIElement element in productoGrid.Children)
            {

                if (element is TextBox)
                {
                    TextBox textBox = (TextBox)element;

                    if (textBox.Text.Equals(""))
                    {
                        textBox.BorderBrush = new SolidColorBrush(Colors.Red);
                        validate = false;
                    }
                    else
                    {
                        textBox.BorderBrush = new SolidColorBrush(Colors.LightGray);
                    }
                }

            }

            return validate;
        } //validacion
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (verify)
            {
                productoHandler.ModifyProduct(producto, pos);
            }
            else
            {
                String referencia = txt_Ref.Text;
                String tipo = txt_Tipo.Text;

                String marca = txt_Marca.Text;
                String precio = txt_Precio.Text;
                String stock = txt_Stock.Text;

                DateTime fechaAlta = (DateTime)txt_fechaAlta.SelectedDate;
                if(Validation())
                {
                    Producto producto = new Producto(referencia, tipo, marca, precio, stock, fechaAlta);
                    productoHandler.AddProduct(producto);

                    MainWindow.myNavigationFrame.NavigationService.Navigate(new MainPage());
                    
                }
                

            }
            
        }

        
    }
}
