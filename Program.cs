﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
        }
    }
}
