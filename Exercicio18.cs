using System;

   class Programa{

    static void Main(string[] args)
	{ 
        int comprimento1, comprimento2, comprimento3;
        
        
         Console.Write("Digite um lado do triângulo: \n>> ");
         comprimento1 = int.Parse(Console.ReadLine());

         Console.Write("Digite o outro lado do triângulo: \n>> ");
         comprimento2 = int.Parse(Console.ReadLine());

         Console.Write("Digite o último lado do triângulo: \n>> ");
         comprimento3 = int.Parse(Console.ReadLine());


         if(comprimento1 == comprimento2 && comprimento1 == comprimento3){
            Console.WriteLine("\n\n>> Este triângulo é equilátero.");

            }else if(comprimento1 == comprimento2  && comprimento1 != comprimento3){
                Console.WriteLine("\n\n>> Este triângulo é isóceles.");
            }else{
                Console.WriteLine("\n\n>> Este triângulo é escaleno.");
            }
     

         
         Console.WriteLine("Pressione Enter para sair..");
         Console.ReadLine();
    }
	}