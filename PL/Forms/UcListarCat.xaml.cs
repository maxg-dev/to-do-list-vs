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
    /// Lógica de interacción para UcListarCat.xaml
    /// </summary>
    public partial class UcListarCat : UserControl
    {
        CategoriaBLL categoriabll = new CategoriaBLL();

        public UcListarCat()
        {
            InitializeComponent();

            lstCategorias.ItemsSource = categoriabll.GetAll();
        }
    }
}
