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
using Verificador.Verificador;

namespace Analizador
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Lexema lexema;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerLexemas_Click(object sender, RoutedEventArgs e)
        {
            this.lexema = new Lexema(this.txtOracion.Text);
            this.txtArea.Text = this.lexema.listaPalabras() + "\n" + this.lexema.listNumeros()
                + "\n" + this.lexema.mostrarCaracteres()
                + "\n" + this.lexema.mostrarMoneda();
            this.txtOracion.Text = "";
            Console.WriteLine(this.lexema.listaPalabras());
            Console.WriteLine(this.lexema.listNumeros());
            Console.WriteLine(this.lexema.listaPalabras());

        }
    }
}
