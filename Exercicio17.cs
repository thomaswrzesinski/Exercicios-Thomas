using System;

class program{
        public static void Main(String[] args){

            string nome;
            double salario, anosDeEmpresa;

            Console.Write(">> Digite seu nome: \n>> ");
            nome = Console.ReadLine();

            Console.Write("\n>> Digite a quantos anos você trabalha na empresa: \n>> ");
            anosDeEmpresa = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n>> Digite seu salário para calcularmos o aumento: \n>> ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (anosDeEmpresa <= 3 && anosDeEmpresa > 0)
            {
                salario = salario * 1.03;
                Console.WriteLine("\nSeu salário com aumento será de: R$" + salario + ".00");
            }else if (anosDeEmpresa > 3 && anosDeEmpresa <= 10)
            {
                salario = salario * 1.125;
                Console.WriteLine("\nSeu salário com aumento será de: R$" + salario + ".00");
            }else if (anosDeEmpresa > 10)
            {
                salario = salario * 1.20;
                Console.WriteLine("\nSeu salário com aumento será de: R$" + salario + ".00");
            }

            Console.WriteLine("\n>> Pressione Enter para sair... ");
            Console.ReadLine();

        }
}

// C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe VariaveisBoleanas.cs
// cd C:\Users\free\Documents\Aula