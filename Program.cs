using System;

namespace Exercicio7CustoFinalCarro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double custoFabrica, lucro, impostos, custoFinal, indLucro, indImposto;
            indLucro = 0.28;
            indImposto = 0.45;
			Console.WriteLine("Digite o custo de fábrica do carro: ");
			custoFabrica = Convert.ToDouble(Console.ReadLine());
            lucro = Math.Round(custoFabrica * indLucro, 2);
            impostos = Math.Round(custoFabrica * indImposto, 2);
            custoFinal = custoFabrica + impostos + lucro;
            Console.Write("O custo final do carro é " + custoFinal);
			Console.ReadLine();
        }
    }
}
