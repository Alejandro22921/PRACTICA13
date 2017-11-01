using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMegaCable
{
    public class Cliente
    {

        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        Paquete paquete;
        public Paquete Paquete
        {
            get { return paquete; }
            set { paquete = value; }
        }

        public Cliente(string nombre, string direccion, Paquete paquete)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.paquete = paquete;
        }



    }
}
