﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Insira o número da matrícula do aluno: ");
            aluno.matricula = Console.ReadLine();
            Console.WriteLine("Insira o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Insira a nota da primeira prova do aluno: ");
            aluno.prova1 = Console.ReadLine();
            Console.WriteLine("Insira a nota da segunda prova do aluno: ");
            aluno.prova2 = Console.ReadLine();
            Console.WriteLine("Insira a nota do trabalho do aluno: ");
            aluno.trabalho = Console.ReadLine();

            aluno.calcMedia();
            aluno.calcFinal();

            Console.WriteLine($"O aluno teve uma média de {aluno.media} pontos");

        }
    }
}
