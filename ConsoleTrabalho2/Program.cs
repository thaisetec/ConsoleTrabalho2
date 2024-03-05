using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrabalho2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário fixo: ");
            double fixo = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de peças vendidas: ");
            int qtde = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da comissão por peça: ");
            double comissao = double.Parse(Console.ReadLine());
            Console.Write("Informe a kilometragem percorrida: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor por km percorrido: ");
            double valor_km=double.Parse(Console.ReadLine());
            double salario_final = fixo + (qtde*comissao) +(km * valor_km);
            Console.WriteLine("Salário final do vendedor: " + salario_final.ToString("C"));
        }
    }
}
