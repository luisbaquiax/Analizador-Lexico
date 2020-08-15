using System;
using Gtk;
using Verificador.Verificador;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Lexema lexema = new Lexema("hola a todos");
        lexema.mostrarLexemas();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnVerLexemasClicked(object sender, EventArgs e)
    {

    }
}
