using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Guids();
            Interpolacao();
            Comparacao();
        }


        static void Guids(){
            Guid identificadorUnico = Guid.NewGuid();
            Console.WriteLine("Guid: " + identificadorUnico);

            Guid identificadorPersonalizado = new Guid("9d36e228-9ece-4f49-8252-4a7cb15b2bfc");
            Console.WriteLine("Guid personalizado: " + identificadorPersonalizado);

            string parteIdentificador = identificadorUnico.ToString().Substring(0, 8);
            Console.WriteLine("Primeiros 8 caracteres do Guid: " + parteIdentificador);
            Console.WriteLine("");
        }

        static void Interpolacao(){
            double preco = 10.2;

            string interpolacaoSimples = "Preço: " + preco; // price automaticamente convertido para string
            Console.WriteLine("Interpolação simples: " + interpolacaoSimples);

            string format = string.Format("Preço: {0}, com desconto: {1}", preco, 8);
            Console.WriteLine("String format: " + format);

            string interpolarCifrao = $"Preço: {preco}";
            Console.WriteLine("Interpolar com $: " + interpolarCifrao);

            Console.WriteLine("");
        }

        static void Comparacao(){
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // 0 = iguais
            Console.WriteLine(texto.CompareTo("testando")); // 1 = diferentes
            Console.WriteLine("");

            Console.WriteLine(texto.Contains("a")); // true = contém
            Console.WriteLine(texto.Contains("h")); // false = não contém
            Console.WriteLine(texto.Contains("testando", StringComparison.OrdinalIgnoreCase)); // true, pois ignora maiúsculo
            Console.WriteLine("");
            
            // Console.WriteLine(texto.Contains(null)); erro pois não é uma comparação válida

            Console.WriteLine(texto.StartsWith("Tes")); // true
            Console.WriteLine(texto.EndsWith("O")); // false
            Console.WriteLine("");

            // Equals existe em vários outros objetos do C#, os dois objetos devem ser exatamente iguais
            Console.WriteLine(texto.Equals("Testando")); // true
            Console.WriteLine(texto.Equals("testando")); // false
            Console.WriteLine("");
        }
    
    }
}
