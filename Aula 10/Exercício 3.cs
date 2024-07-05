using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HelloWorld
{
    static void Main()
    {

        Dictionary<string, int> idadeDasPessoas = new Dictionary<string, int>();
        Dictionary<string, int> idadeExcluida = new Dictionary<string, int>();


        Console.WriteLine("Quantas pessoas serão analisadas?");
        int X = int.Parse(Console.ReadLine());

        for (int i = 0; i < X; i++)
        {

            Console.Write("Insira o nome de uma pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            idadeDasPessoas.Add(nome, idade);

        }

        int idadeTotal = 0;

        foreach (var pessoa in idadeDasPessoas)
        {

            idadeTotal += pessoa.Value;

        }

        float idadeMedia = idadeTotal / idadeDasPessoas.Count;
        Console.WriteLine("Pessoas com idade acima da média:");

        foreach (var pessoa in idadeDasPessoas)
        {

            if (pessoa.Value > idadeMedia)
            {

                Console.WriteLine($"{pessoa.Key}, ");

            }

        }

        int menor = 130, maior = 0;

        foreach (var pessoa in idadeDasPessoas)
        {

            if (pessoa.Value > maior)
            {

                maior = pessoa.Value;

            }
            else if (menor > pessoa.Value)
            {

                menor = pessoa.Value;

            }

        }

        foreach (var pessoa in idadeDasPessoas)
        {

            if (pessoa.Value == maior)
            {

                Console.WriteLine($"A pessoa mais velha é :{pessoa.Key} com {pessoa.Value} anos.");

            }
            else if (menor == pessoa.Value)
            {

                Console.WriteLine($"A pessoa mais nova é :{pessoa.Key} com {pessoa.Value} anos.");

            }

        }

        Console.WriteLine("Insira uma idade para excluir dentre as citadas: ");
        int Y = int.Parse(Console.ReadLine());

        foreach (var pessoa in idadeDasPessoas)
        {

            if (pessoa.Value == Y)
            {

                idadeExcluida.Add(pessoa.Key, Y);

            }

        }

        foreach (var pessoa in idadeExcluida)
        {

            while (X != 0)
            {

                idadeDasPessoas.Remove(pessoa.Key);
                X--;

            }

        }

        foreach (var pessoa in idadeDasPessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Key}, Idade: {pessoa.Value}");
        }

    }
}