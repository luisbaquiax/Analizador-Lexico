using System;
using Gtk;
using Verificador.Verificador;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnVerLexemasClicked(object sender, EventArgs e)
    {
        Lexema lexema = new Lexema("hola a todos 22222 a2s3q5w soy otra cadena 151546 w6e9e1");
        lexema.mostrarLexemas();
    }
}
