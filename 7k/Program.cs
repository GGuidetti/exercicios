using System;

namespace _7k
{
    class Program
    {
        static void Main(string[] args)
        {//Elabore um algoritmo que calcule a idade média de 5 alunos.
            alunos alunos = new alunos();
            alunos.obter();
            Console.WriteLine(alunos.media);
        }
    }

    class alunos{

       
    int aluno1 = 0;
    int aluno2 = 0;
    int aluno3 = 0;
    int aluno4 = 0;
    int aluno5 = 0;
    public int media;

    public void obter(){
    Console.WriteLine("Qual sua idade?");
    aluno1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual sua idade?");
    aluno2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Qual sua idade?");
    aluno3 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Qual sua idade?");
    aluno4 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Qual sua idade?");
    aluno5 = int.Parse(Console.ReadLine()); 

    this.calcule(); 
    
    
}


    public void calcule(){
   
  
    this.media = (aluno1 + aluno2 +aluno3 + aluno4 + aluno5) /5;
    

}}}
