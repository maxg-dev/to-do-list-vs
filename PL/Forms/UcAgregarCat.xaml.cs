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
using BLL;

namespace PL.Forms
{
    /// <summary>
    /// Lógica de interacción para UcAgregarCat.xaml
    /// </summary>
    public partial class UcAgregarCat : UserControl
    {
        CategoriaBLL categoriabll = new CategoriaBLL();

        public UcAgregarCat()
        {
            InitializeComponent();
        }

        private void BtnAgregarCat_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombreCat.Text.Trim();
            categoriabll.Add(nombre);

            MessageBox.Show("Categoría agregada :)", "Nueva Categoría", MessageBoxButton.OK, MessageBoxImage.Information);
            txtNombreCat.Text = string.Empty;

        }
    }
}
