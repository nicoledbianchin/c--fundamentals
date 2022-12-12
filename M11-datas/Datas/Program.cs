using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Data.Common;
using System.Text;
using System.Runtime.CompilerServices;
using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Introdução");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            IntroDatas();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nObter valor");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ObterValorDeData();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nFormatação");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Formatacao();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nPadrão de formatação");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            PadraoFormatacao();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nAdicionando valores");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            AdicionandoValores();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nComparando");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Comparando();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nCultureInfo");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            CultureInformation();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nTimezone");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Timezone();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nTimespan");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Timespan();
        }

        static void IntroDatas()
        {
            var data = new DateTime();
            Console.WriteLine(data);

            var dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);
        }

        static void ObterValorDeData()
        {
            var data = new DateTime(2020, 10, 12, 8, 30, 16);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }

        static void Formatacao()
        {
            var data = DateTime.Now;

            var formatada = String.Format("{0:yyyy}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:MM}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:M}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:dd}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:yyyy-MM-dd HH:mm:ss zz}", data);
            Console.WriteLine(formatada);
        }

        static void PadraoFormatacao()
        {
            var data = DateTime.Now;

            var formatada = String.Format("{0:t}", data); // short time pattern
            Console.WriteLine(formatada);

            formatada = String.Format("{0:d}", data); // data em números
            Console.WriteLine(formatada);

            formatada = String.Format("{0:D}", data); // data por extenso
            Console.WriteLine(formatada);

            formatada = String.Format("{0:g}", data); // data e hora
            Console.WriteLine(formatada);

            formatada = String.Format("{0:f}", data); // data e hora por extenso
            Console.WriteLine(formatada);

            formatada = String.Format("{0:r}", data); // data e hora por extenso abreviado
            Console.WriteLine(formatada);

            formatada = String.Format("{0:s}", data); 
            Console.WriteLine(formatada);

            formatada = String.Format("{0:u}", data); // padrão universal
            Console.WriteLine(formatada);
        }

        static void AdicionandoValores()
        {
            var data = DateTime.Now;

            data.AddDays(12);
            Console.WriteLine(data);

            // o método não altera o objeto, só retorna             
            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine(data.AddYears(1));
            
            Console.WriteLine(data.AddDays(12));

            Console.WriteLine(data.AddDays(-6));
        }

        static void Comparando()
        {
            var data = DateTime.Now;

            if(data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            if(data == DateTime.Now)
            {
                Console.WriteLine("É igual"); // não funciona pois compara até os milissegundos, nunca será igual
            }

        }

        static void CultureInformation()
        {
            
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D"));
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
            
            Console.WriteLine(" ");

            Console.WriteLine(DateTime.Now.ToString("d"));
            Console.WriteLine(DateTime.Now.ToString("d", pt));
            Console.WriteLine(DateTime.Now.ToString("d", br));
            Console.WriteLine(DateTime.Now.ToString("d", en));
            Console.WriteLine(DateTime.Now.ToString("d", de));
            Console.WriteLine(DateTime.Now.ToString("d", atual));
        }

        static void Timezone()
        {
            var data = DateTime.UtcNow; // universal

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(data);

            Console.WriteLine(data.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(data, timeZoneAustralia);
            Console.WriteLine(horaAustralia);

            // lista todos os timezones
            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(data, timezone));
            //     Console.WriteLine("_________");
            // }
        }

        static void Timespan()
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }
    }
}
