using System;

namespace VT_01RaulSalva.Pages
{
    public class User : ICloneable
    {
        public String nombre { set; get; }
        public String telefono { set; get; }
        public DateTime fechaAlta { set; get; }

        public User(string nombre, string telefono, DateTime fechaAlta)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaAlta = fechaAlta;
        }
        public User()
        {
            this.nombre = "";
            this.telefono = "";
            this.fechaAlta = DateTime.Now;
        }

        public override string ToString()
        {
            return nombre;
        }

        public object Clone()
        {
            return this.MemberwiseClone();

        }
    }
}