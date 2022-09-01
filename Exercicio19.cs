using System;

class Exercicio19
{
    static void Main(string[] args)
	{ 
        double valorImovel, salario, prestacao;
        
        
         Console.WriteLine("Digite o valor do imóvel desejado:");
         valorImovel = int.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite quanto você ganha:");
         salario = int.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite em quantas prestações voce quer pagar:");
         prestacao = int.Parse(Console.ReadLine());

         salario = salario * 0.70;
         prestacao = valorImovel / prestacao;
        
        if (prestacao > salario)
        {
            Console.WriteLine("\nNão será possível comprar.\n");
        }else{
            Console.WriteLine("\nSerá possível.\n");
        }

     
      Console.WriteLine("Digite Enter para sair..");
      Console.ReadLine();
    }
}

// Made by @prod.fezin