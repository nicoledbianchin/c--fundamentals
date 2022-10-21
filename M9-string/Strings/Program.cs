using System;
using System.Text;

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
            Indices();
            MetodosAdicionais();
            Builder();
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

        static void Indices(){
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("e")); // 3, pois devolve a posição da primeira aparição da letra
            Console.WriteLine(texto.LastIndexOf("e")); // 20, devolve a posição da última aparição da letra
            Console.WriteLine(texto.IndexOf("h")); // -1, pois não tem essa letra
            Console.WriteLine("");
        }

        static void MetodosAdicionais(){
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToUpper()); // converte tudo para maiúsculo
            Console.WriteLine(texto.ToLower()); // converte tudo para minúsculo
            Console.WriteLine("");

            Console.WriteLine(texto.Insert(11, "AQUI ")); // Este aqui texto é um teste
            Console.WriteLine(texto.Remove(5, 6)); // Este é um teste
            Console.WriteLine("");

            Console.WriteLine(texto.Length); // 21
            Console.WriteLine("");

            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Replace("e", "X")); // faz replace em todas as strings
            Console.WriteLine("");

            var divisao = texto.Split(" "); // divide a string em todo lugar que tem espaço, e cria uma lista com cada pedaço da string
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);
            Console.WriteLine("");

            var resultado = texto.Substring(5, 5); // texto
            Console.WriteLine(resultado);
            Console.WriteLine("");

            Console.WriteLine(texto.Trim()); // remove os espaços do começo e do fim
            Console.WriteLine("");
        }

        static void Builder(){
            // utilizado para construir strings complexas ou muito grandes, pois evita a criação de várias cópias da variável e diminui a necessidade de memórias
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            Console.WriteLine(texto);
        }
    
    }
}
