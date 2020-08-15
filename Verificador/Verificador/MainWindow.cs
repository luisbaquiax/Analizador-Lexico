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
        Lexema lexema = new Lexema("hola a todos 22222 3156aaa465 soy otra cadena 151546 0vvv0001");
        lexema.mostrarLexemas();
    }
}
