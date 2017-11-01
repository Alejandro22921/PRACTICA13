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

namespace AplicacionMegaCable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Paquete> listaPaquetes = new List<Paquete>()
            { new Paquete("Basic", 100.0),
              new Paquete("Medium", 150.0),
              new Paquete("Premium", 400.0), };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbPaquete.ItemsSource = listaPaquetes;
            cmbPaquete.DisplayMemberPath = "Descripcion";
            cmbPaquete.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Paquete paquete = (Paquete)cmbPaquete.SelectedItem;
                Cliente cliente = new Cliente(txtNombre.Text, txtDireccion.Text, paquete);
                listaClientes.Add(cliente);
                MessageBox.Show("Cliente Añadido Exitosamente :)");
            }catch(Exception){}
        }

        private void txtBuscarNombre_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                List<Cliente> aux;
                aux = listaClientes.FindAll(delegate(Cliente c) { return c.Nombre.Contains(txtBuscarNombre.Text); });
                DGClientes.ItemsSource = aux;
                DGClientes.Items.Refresh();
            }
        }

        private void DGClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNombreInfo.Text = listaClientes.ElementAt(DGClientes.SelectedIndex).Nombre;
            txtPaqueteInfo.Text = listaClientes.ElementAt(DGClientes.SelectedIndex).Paquete.Descripcion;
            txtTotalInfo.Text = Convert.ToString(Convert.ToDouble(listaClientes.ElementAt(DGClientes.SelectedIndex).Paquete.Precio) * (1.15));

        }
    }
}
