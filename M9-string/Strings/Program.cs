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

    }
}
