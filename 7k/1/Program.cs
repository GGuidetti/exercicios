﻿using System;

namespace _1
{
  class Program2
    {
        static void Main(string[] args)
        {// Crie um algoritmo que verifique se um número informado é par ou impar
            count count = new count();
            count.numeros();
            
        }
    }

    class count{
        int numero;

        public void numeros(){
        Console.WriteLine("Digite um numero");
        numero = int.Parse(Console.ReadLine());

        this.parimpar();
    }
        public void parimpar(){
        int x = numero % 2;    
        if (x==0)
        {
            Console.WriteLine("é par");
            
        }
        else
        {
            Console.WriteLine("num é par");
        }
    }

}}
