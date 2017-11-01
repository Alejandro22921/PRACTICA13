using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMegaCable
{
    public class Paquete
    {
        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Paquete(string descripcion, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
