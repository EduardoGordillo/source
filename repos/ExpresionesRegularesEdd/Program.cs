using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ExpresionesRegularesEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // metodo 1
            // busqueda de expresion en un texto

            string texto = "La casa del casamentero";
            string exp = "casa";

            MatchCollection encontrado = Regex.Matches(texto, exp);

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);

            }
            Console.WriteLine("-------------------");



            // metodo 2
            // busqueda de una palabra especifica (solo si esta al final)

            texto = "El estudiante es un casa nova en la escuela";
            exp = " casa ";

            Regex expReg = new Regex(exp);
            encontrado = expReg.Matches(texto);

            foreach (Match e in encontrado )
            {
                Console.WriteLine(e);

            }
            Console.WriteLine("-----------------");

            texto = "Saludos al mas campeon";
            exp = " ca.";// el punto significa que cualquier otro  caracter puede estar en lugar del punto
            MatchesExp( texto, exp);
            
            
            // uso de clases de caracteres, se una [] para contener los caracteres
            texto = "hola Naco";
            exp = "N[ie]c"; // [n] n= son los caracteres que puede contener entre los caracteres de incio y fin
            MatchesExp(texto, exp);

            // con un rango
            // nico, neco, nocu, naco

            texto = "Hola Nmco";
            exp = "N[a-u]c"; // revisara entre el rango que existe a - u de todo el alfabeto
            MatchesExp(texto, exp);


            // uso del complemento
            // noco, nico
            texto = "hola Nico";
            exp = "N[^ie]c";// buscara todos los caracateres exceptuando lo que esta des de ^
            MatchesExp(texto, exp);
            /// para saber si la expresoin regular estar en el final
            texto = "De      Nicosiored es mi canal favorito Nic";
            exp = "N[ia]c$"; // se añane del simbolo de $ para revisar si la expresion esta  al final y ni un caracter masde la declaracion de la expresion regular
            MatchesExp(texto, exp);

            /// para un elemento opcional
            texto = "Hola  Edu es mi canal favorito "; 
            exp = "E[du]d?u"; // se añade eñ ? para un valor que puede estar o no estar presente antes del signo
            MatchesExp(texto, exp);

            // verificar si la expresion tiene alguna coincidencia despues de cierta posicion
            texto = "De Youtube  Nicosiored es mi canal favorito";
            exp = "N[ia]c";
            expReg = new Regex(exp);

            if (expReg.IsMatch(texto, 5))
            {
                Console.WriteLine("Si tiene");
            }
            else
            {
                Console.WriteLine("No tiene");

            }
            Console.WriteLine("--------------");

            // cuantificador 
            // busca que existan elementos n de esos elementos
            texto = "Holaa Edd 289";
            exp = "[0-9]{2,3}"; // aqui estamos en el rango de 0-9 que buuscara las posiciones {2} que has cuantificado
            MatchesExp(texto, exp);

            //alternaciones 
            texto = "Yo se programar C#";
            exp = "(C#|Java|Python )";// puede buscar entre las opciones que tiene delimitadas entre los | | | 
            MatchesExp(texto, exp);

            // split
            // dividir un texto en cadenas dependiendo de la expresion regular
            texto = "Este es un test de separacion, division";
            exp = " "; 

            string[] cadenas = Regex.Split(texto, exp);
            foreach (string c in cadenas)
                Console.WriteLine(c);


            //reemplazar un texto con otro
            texto = "Yo hablo ingles y no soy ingles";
            expReg = new Regex("ingles");
            string reemplazo = "español";
            string resultado = expReg.Replace(texto, reemplazo);
            Console.WriteLine(resultado);
            Console.WriteLine(texto);
        }


        public static void MatchesExp(string pTexto, string pExp)
        {
            MatchCollection encontrado = Regex.Matches(pTexto, pExp);

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("---------------");
        }
    }
}
