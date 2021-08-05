using System;
using DIO.Series.Servicos;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            SerieServico serieServico = new SerieServico();
            string opcaoUsuario = serieServico.ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        serieServico.ListarSeries();
                        break;
                    case "2":
                        serieServico.InserirSerie();
                        break;
                    case "3":
                        serieServico.AtualizarSerie();
                        break;
                    case "4":
                        serieServico.ExcluirSerie();
                        break;
                    case "5":
                        serieServico.VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\nPor favor, digite uma opção válida");
                        break;
                }

                opcaoUsuario = serieServico.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
    }
}
