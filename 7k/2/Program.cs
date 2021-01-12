using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {//Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
            Recebendo Recebendo = new Recebendo();
            Recebendo.perguntando();
            Console.WriteLine(Recebendo.array[5]);
            Console.WriteLine(Recebendo.array[0]);
            Console.WriteLine(Recebendo.array[1]);
            Console.WriteLine(Recebendo.array[2]);
            Console.WriteLine(Recebendo.array[3]);
            Console.WriteLine(Recebendo.array[4]);
            
            
        }
    }

    class Recebendo{
        int pessoa1;
        int pessoa2;
        int pessoa3;
        int pessoa4;
        int pessoa5;
 
        string spessoa1;
        string spessoa2;
        string spessoa3;
        string spessoa4;
        string spessoa5;

        public string[] array = new string[6];
        
        public void perguntando(){
        Console.WriteLine("Qual sua idade");
        int pessoa1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu nome");
        string spessoa1 = Console.ReadLine();
        
       
        Console.WriteLine("Qual sua idade");
        int pessoa2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu nome");
        string spessoa2 = Console.ReadLine();

        Console.WriteLine("Qual sua idade");
        int pessoa3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu nome");
        string spessoa3 = Console.ReadLine();

        Console.WriteLine("Qual sua idade");
        int pessoa4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu nome");
        string spessoa4 = Console.ReadLine();
        
        Console.WriteLine("Qual sua idade");
        int pessoa5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu nome");
        string spessoa5 = Console.ReadLine();
       
  
     if (pessoa1>=18 || pessoa2>=18  || pessoa3>=18  || pessoa4>=18  || pessoa5>=18 )
     {
         Console.WriteLine("O(s) maiores de idade são: ");
     }

     else
     {
         Console.WriteLine("Não há maiores de idade dentre os nomes informados!");
     }
            if (pessoa1>=18){
                array [0] = spessoa1;
                
            }





             if (pessoa2>=18){
                array [1] = spessoa2;
                
            }





             if (pessoa3>=18){
                array [2] = spessoa3;
                
            }





             if (pessoa4>=18){
                array [3] = spessoa4;
                
            }






             if (pessoa5>=18){
                array [4] = spessoa5;
                
            }
           

            



    }
       
}}
