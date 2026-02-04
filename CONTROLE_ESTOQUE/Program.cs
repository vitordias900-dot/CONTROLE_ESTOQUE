using System;
using System.Globalization;

namespace Programa
{
    class Produto
    {
        public string Nome;
        public int Comprado;
        public int Vendido;


        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("===== CONTROLE DO ESPETO =====");

            List<Produto> lista = new List<Produto>();

            bool continuar = true;

            while (continuar)
            {
                Console.Write("\nPRODUTO: ");
                string nome = Console.ReadLine();

                Console.Write("QUANTIDADE COMPRADA: ");
                int comprado = int.Parse(Console.ReadLine());

                Console.Write("QUANTIDADE VENDIDA: ");
                int vendido = int.Parse(Console.ReadLine());

                Produto p = new Produto();
                p.Nome = nome;
                p.Comprado = comprado;
                p.Vendido = vendido;

                lista.Add(p);

                Console.Write("\nDeseja cadastrar outro produto? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.ToUpper() == "N")
                {
                    continuar = false;
                }
            }


            Console.WriteLine("\n===== RELATÓRIO DO DIA =====");

            double faturamentoTotal = 0;
            int sobraTotal = 0;

            foreach (Produto p in lista)
            {
                int sobra = p.Comprado - p.Vendido;
                double faturamento = p.Vendido * 8.0;
           

                sobraTotal = sobraTotal + sobra;
                faturamentoTotal = faturamentoTotal + faturamento;

                Console.WriteLine("\nProduto: " + p.Nome);
                Console.WriteLine("Comprado: " + p.Comprado);
                Console.WriteLine("Vendido: " + p.Vendido);
                Console.WriteLine("Sobra: " + sobra);
                Console.WriteLine("Faturamento: R$ " + faturamento.ToString("F2", CI));
                Console.WriteLine("------------------------");
                
            }

            Console.WriteLine("\nTOTAL DO DIA = R$ " + faturamentoTotal.ToString("F2", CI));
            Console.WriteLine("SOBRA TOTAL = " + sobraTotal);
        }
    }
}
