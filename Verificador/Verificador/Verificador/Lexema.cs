using System;
namespace Verificador.Verificador
{
    public class Lexema
    {
        private String oracion;
       

        public Lexema(String oracion)
        {
            this.oracion = oracion;
        }

        public void mostrarLexemas() {

            String texto = this.oracion;
            String[] palabras = texto.Split(' ');
            for (int i = 0; i < palabras.Length; i++) {
                Console.WriteLine(palabras[i]); 
            }
        }

        public Boolean verLetras(String subcadena)
        {
            char[] cadenitas = subcadena.ToCharArray;
            foreach (int i = 0; i < cadenitas.Length; i++) {
                if (cadenitas[i] == 'a' || (cadenitas[i] == 'A') { 
                }
            };
        }

    }
}
