using System;
namespace Verificador.Verificador
{
    public class Lexema
    {
        private String oracion;
        private String[] palabras = new string[10];
        private String[] listaNumeros = new String[10];
        private String[] listaCaracteres = new String [10];
        private String[] monedaGuatemala = new string[2];
          
        public Lexema(String oracion)
        {
            this.oracion = oracion;
        }

        public void mostrarLexemas() {

            String texto = this.oracion;
            String[] palabras = texto.Split(' ');
           
            for (int i = 0; i < (palabras.Length-1); i++) {
                esPalabra(palabras[i]);
                esNumero(palabras[i]);
                esCadenaCualquiera(palabras[i]);
            }
            Console.WriteLine(listaPalabras());
            Console.WriteLine(listNumeros());
            Console.WriteLine(mostrarCaracteres());
        }

        public void verSiEsMondeaGuatemala(String subcadena) { 
            
        }

        public Boolean esPalabra(String subcadena)
        {
            int contador = 0;
            char[] cadenitas = subcadena.ToCharArray();
            for (int i = 0; i < cadenitas.Length; i++) {
                if ((cadenitas[i] == 'a' )|| (cadenitas[i] == 'A')
                    || (cadenitas[i] == 'b') || (cadenitas[i] == 'B')
                    || (cadenitas[i] == 'c') || (cadenitas[i] == 'C')
                    || (cadenitas[i] == 'd') || (cadenitas[i] == 'D')
                    || (cadenitas[i] == 'e') || (cadenitas[i] == 'E')
                    || (cadenitas[i] == 'f') || (cadenitas[i] == 'F')
                    || (cadenitas[i] == 'g') || (cadenitas[i] == 'G')
                    || (cadenitas[i] == 'h') || (cadenitas[i] == 'H')
                    || (cadenitas[i] == 'i') || (cadenitas[i] == 'I')
                    || (cadenitas[i] == 'j') || (cadenitas[i] == 'J')
                    || (cadenitas[i] == 'k') || (cadenitas[i] == 'K')
                    || (cadenitas[i] == 'l') || (cadenitas[i] == 'L')
                    || (cadenitas[i] == 'm') || (cadenitas[i] == 'M')
                    || (cadenitas[i] == 'n') || (cadenitas[i] == 'N')
                    || (cadenitas[i] == 'o') || (cadenitas[i] == 'O')
                    || (cadenitas[i] == 'p') || (cadenitas[i] == 'P')
                    || (cadenitas[i] == 'q') || (cadenitas[i] == 'Q')
                    || (cadenitas[i] == 'r') || (cadenitas[i] == 'R')
                    || (cadenitas[i] == 's') || (cadenitas[i] == 'S')
                    || (cadenitas[i] == 't') || (cadenitas[i] == 'T')
                    || (cadenitas[i] == 'u') || (cadenitas[i] == 'U')
                    || (cadenitas[i] == 'v') || (cadenitas[i] == 'V')
                    || (cadenitas[i] == 'w') || (cadenitas[i] == 'W')
                    || (cadenitas[i] == 'x') || (cadenitas[i] == 'X')
                    || (cadenitas[i] == 'y') || (cadenitas[i] == 'Y')
                    || (cadenitas[i] == 'z') || (cadenitas[i] == 'Z')
                    ) {
                    contador++;
                   }

            }
            if (cadenitas.Length == contador)
            {
                ingresarPalabra(subcadena);
                return true;
            }
            return false;
        }

        public void esCadenaCualquiera(String subcadena)
        {
            int contador = 0;
            Console.WriteLine(">>>>>>>>>> "+subcadena+" >>>>>>>>>>>");
            char[] cadenitas = subcadena.ToCharArray();
            for (int i = 0; i < cadenitas.Length; i++){
               if ((cadenitas[i] == 'a') || (cadenitas[i] == 'A')
                    || (cadenitas[i] == 'b') || (cadenitas[i] == 'B')
                    || (cadenitas[i] == 'c') || (cadenitas[i] == 'C')
                    || (cadenitas[i] == 'd') || (cadenitas[i] == 'D')
                    || (cadenitas[i] == 'e') || (cadenitas[i] == 'E')
                    || (cadenitas[i] == 'f') || (cadenitas[i] == 'F')
                    || (cadenitas[i] == 'g') || (cadenitas[i] == 'G')
                    || (cadenitas[i] == 'h') || (cadenitas[i] == 'H')
                    || (cadenitas[i] == 'i') || (cadenitas[i] == 'I')
                    || (cadenitas[i] == 'j') || (cadenitas[i] == 'J')
                    || (cadenitas[i] == 'k') || (cadenitas[i] == 'K')
                    || (cadenitas[i] == 'l') || (cadenitas[i] == 'L')
                    || (cadenitas[i] == 'm') || (cadenitas[i] == 'M')
                    || (cadenitas[i] == 'n') || (cadenitas[i] == 'N')
                    || (cadenitas[i] == 'o') || (cadenitas[i] == 'O')
                    || (cadenitas[i] == 'p') || (cadenitas[i] == 'P')
                    || (cadenitas[i] == 'q') || (cadenitas[i] == 'Q')
                    || (cadenitas[i] == 'r') || (cadenitas[i] == 'R')
                    || (cadenitas[i] == 's') || (cadenitas[i] == 'S')
                    || (cadenitas[i] == 't') || (cadenitas[i] == 'T')
                    || (cadenitas[i] == 'u') || (cadenitas[i] == 'U')
                    || (cadenitas[i] == 'v') || (cadenitas[i] == 'V')
                    || (cadenitas[i] == 'w') || (cadenitas[i] == 'W')
                    || (cadenitas[i] == 'x') || (cadenitas[i] == 'X')
                    || (cadenitas[i] == 'y') || (cadenitas[i] == 'Y')
                    || (cadenitas[i] == 'z') || (cadenitas[i] == 'Z')
                    || (cadenitas[i] == '0') || (cadenitas[i] == '5')
                    || (cadenitas[i] == '1') || (cadenitas[i] == '6')
                    || (cadenitas[i] == '2') || (cadenitas[i] == '7')
                    || (cadenitas[i] == '3') || (cadenitas[i] == '8')
                    || (cadenitas[i] == '4') || (cadenitas[i] == '9')
                    ) {
                    contador++;
                    Console.WriteLine(contador);
                    if (cadenitas.Length == contador)
                    {
                        ingresarCadenaDeCaracteres(subcadena);
                        //return true;
                       
                    }
                }
                }
            Console.WriteLine(cadenitas.Length+" largo subcadena");

            //return false;
        }


        public Boolean esNumero(String subcadena)
        {
            int contador = 0;
            char[] cadenitas = subcadena.ToCharArray();
            for (int i = 0; i < cadenitas.Length; i++)
            {
                if ((cadenitas[i] == '0') || (cadenitas[i] == '5')
                    || (cadenitas[i] == '1') || (cadenitas[i] == '6')
                    || (cadenitas[i] == '2') || (cadenitas[i] == '7')
                    || (cadenitas[i] == '3') || (cadenitas[i] == '8')
                    || (cadenitas[i] == '4') || (cadenitas[i] == '9')
                    )
                {
                    contador++;
                }

            }

           if (cadenitas.Length == contador)
            {
                ingresarNumero(subcadena);
                return true;
            }

            return false;
        }



        public void ingresarPalabra(String palabra) {
            for (int i = 0; i< this.palabras.Length; i++)
            {
                if (palabras[i]==null) {
                    palabras[i] = palabra;
                    return;
                }
            }
        }

        public void ingresarNumero(String numero)
        {
            for (int i = 0; i < this.listaNumeros.Length; i++)
            {
                if (listaNumeros[i]== null) {
                    listaNumeros[i] = numero;
                    return;
                }
            }
        }

        public void ingresarCadenaDeCaracteres(String cadena)
        {
            for (int i = 0; i< this.listaCaracteres.Length; i++) 
            {
                 if(listaCaracteres[i] == null) {
                    listaCaracteres[i] = cadena;
                    return;
                 }
            }
        }

        public String listaPalabras()
        {
            String cadenas = "Lista de palabras: \n";
            for (int i =0; i< palabras.Length; i++) {
                if (palabras[i] !=null) {
                    cadenas += palabras[i]+ "\n";
                }
            }
            return cadenas;
        }

        public String listNumeros()
        {
            String cadenas = "Lista de números: \n";
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i] != null)
                {
                    cadenas += listaNumeros[i] + "\n";
                }
            }
            return cadenas;
        }

        public String mostrarCaracteres()
        {
            String cadenas = "Lista de todas las cadenas: \n";
            for (int i = 0; i < listaCaracteres.Length; i++)
            {
                if (listaCaracteres[i] != null)
                {
                    cadenas += listaCaracteres[i] + "\n";
                }
            }
            return cadenas;
        }
    }
}
