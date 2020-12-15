using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT_01RaulSalva.Pages;
using VT_01RaulSalva.ProductClass;

namespace VT_01RaulSalva
{
    public class ProductHandler
    {
        public ObservableCollection<Producto> productoList { get; set; }

        public ProductHandler()
        {
            this.productoList = new ObservableCollection<Producto>();
        }

        public void AddProduct(Producto product)
        {
            productoList.Add(product);
        }

        public void ModifyProduct(Producto producto, int pos)
        {
            productoList[pos] = producto;
        }
        public void RemoveProduct(int pos)
        {
            productoList.RemoveAt(pos);
        }



    }
}