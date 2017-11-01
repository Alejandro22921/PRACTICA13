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
        List<Cliente> listaCliente = new List<Cliente>();
        List<Paquete> listaPaquete = new List<Paquete>()
            { new Paquete("Basic", 100.0),
              new Paquete("Medium", 150.0),
              new Paquete("Premium", 400.0), };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbPaquete.ItemsSource = listaPaquete;
            cmbPaquete.DisplayMemberPath = "Descripcion";
            cmbPaquete.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Paquete paquete = (Paquete)cmbPaquete.SelectedItem;
            Cliente cliente = new Cliente(txtNombre.Text, txtDireccion.Text, paquete);
            listaCliente.Add(cliente);
            MessageBox.Show("Exito :)");
        }

        private void txtBuscarNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                List<Cliente> aux;
                string buscarNombre = txtBuscarNombre.Text;
                aux = listaCliente.FindAll(delegate(Cliente c) { return c.Nombre.Contains(buscarNombre); });
                DGClientes.DataContext = aux;
            }
        }
    }
}
