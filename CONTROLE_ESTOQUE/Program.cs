using System;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("===== CONTROLE DO ESPETO =====");

            
            Console.Write("Nome do produto: ");
            string produto = Console.ReadLine();

            
            Console.Write("Quantidade comprada: ");
            int quantidadeComprada = int.Parse(Console.ReadLine());

           
            Console.Write("Quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            if (quantidadeVendida > quantidadeComprada)
            {
                Console.WriteLine("ERRO: Você vendeu mais do que comprou!");
                return;
            }

            
            int estoqueFinal = quantidadeComprada - quantidadeVendida;
            double faturamento = quantidadeVendida * 8.0;

            Console.WriteLine("\n===== RELATÓRIO DO DIA =====");
            Console.Write("\nProduto: " + produto);
            Console.Write("\nComprado: " + quantidadeComprada);
            Console.Write("\nVendido: " + quantidadeVendida);
            Console.Write("\nSobra: " + estoqueFinal);
            Console.Write("\nFaturamento: R$ " + faturamento.ToString("F2", CI));
            Console.WriteLine();
        }
    }
}
