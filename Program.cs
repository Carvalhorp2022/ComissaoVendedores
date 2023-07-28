using System;

namespace CalculoComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados de entrada
            Console.WriteLine("Digite a identificação do vendedor: ");
            string identificacao = Console.ReadLine();

            Console.WriteLine("Digite o código da peça: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Digite o preço unitário da peça: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            // Cálculo da comissão
            double totalVenda = precoUnitario * quantidadeVendida;
            double comissao = totalVenda * 0.05;

            // Exibição dos resultados
            Console.WriteLine("Identificação do vendedor: " + identificacao);
            Console.WriteLine("Código da peça: " + codigo);
            Console.WriteLine("Preço unitário da peça: " + precoUnitario.ToString("F2"));
            Console.WriteLine("Quantidade vendida: " + quantidadeVendida);
            Console.WriteLine("Total da venda: " + totalVenda.ToString("F2"));
            Console.WriteLine("Comissão do vendedor: " + comissao.ToString("F2"));
        }
    }
}
