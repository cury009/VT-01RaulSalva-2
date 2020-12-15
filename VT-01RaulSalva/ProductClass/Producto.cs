using System;

namespace VT_01RaulSalva.ProductClass
{   
    public class Producto : ICloneable
{
    public String referencia { set; get; }
    public String Tipo { set; get; }
    public String marca { set; get; }
    public String precio { set; get; }
    public String stock { set; get; }
    public DateTime fechaAlta { set; get; }

    public Producto(string referencia, string tipo, string marca, string precio, string stock, DateTime fechaAlta)
    {
        this.referencia = referencia;
        this.Tipo = tipo;
        this.marca = marca;
        this.precio = precio;
        this.stock = stock;
        this.fechaAlta = fechaAlta;
    }
    public Producto()
    {
        this.referencia = "";
        this.Tipo = "";
        this.marca = "";
        this.precio = "";
        this.stock = "";
        this.fechaAlta = DateTime.Now;
    }

    public override string ToString()
    {
        return referencia;
    }

    public object Clone()
    {
        return this.MemberwiseClone();

    }
}
}