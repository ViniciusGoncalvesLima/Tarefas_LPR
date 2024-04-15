using System;

int main()
{
    string heroi1 = "Disponível", heroi2 = "Disponível", heroi3 = "Disponível", heroi4 = "Disponível", heroi5 = "Disponível";
    int poder1, poder2, poder3, poder4, poder5;
    int pontuacao1, pontuacao2, pontuacao3, pontuacao4, pontuacao5;
    int quantHerois;
    bool sair = true;

    Console.WriteLine("Bem-vindo(a) ao Joguinho da Marvel!");
    menuPrincipal();
    
}

void menuPrincipal()
{

    Console.WriteLine("Para continuar selecione uma das opções a seguir:");

    while (sair)
    {


        Console.WriteLine("1. Cadastrar herói;");
        Console.WriteLine("2. Excluir herói");
        Console.WriteLine("3. Selecionar equipe;");
        Console.WriteLine("4. Exibir equipe");
        Console.WriteLine("5. Sair");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {

            case 1:

                cadastrarHeroi();
                break;

            case 2:

                excluirHeroi();
                break;

            case 3:

                selecionarEquipe();
                break;

            case 4:

                exibirEquipe();
                break;

            case 5:

                Console.WriteLine("Saindo do Joguinho da Marvel...");
                sair = false;
                break;

            default:

                Console.WriteLine("Selecione uma opção válida!");
                break;

        }
    }

}

void cadastrarHeroi()
{

    Console.WriteLine("Hora de cadastrar seu herói!");
    
    if (heroi1 == "Disponível")
    {

        Console.Write("Primeiro coloque o nome do herói: ");
        heroi1 = Console.ReadLine();
        Console.Write("Agora insira o poder dele: ");
        poder1 = int.Parse(Console.ReadLine());
        Console.Write("E por último, coloque sua pontuação: ");
        pontuacao1 = int.Parse(Console.ReadLine());
        quantHerois++;

    } 
    else if (heroi2 == "Disponível")
    {

        Console.Write("Primeiro coloque o nome do herói: ");
        heroi2 = Console.ReadLine();
        Console.Write("Agora insira o poder dele: ");
        poder2 = int.Parse(Console.ReadLine());
        Console.Write("E por último, coloque sua pontuação: ");
        pontuacao2 = int.Parse(Console.ReadLine());
        quantHerois++;

    }
    else if (heroi3 == "Disponível")
    {

        Console.Write("Primeiro coloque o nome do herói: ");
        heroi3 = Console.ReadLine();
        Console.Write("Agora insira o poder dele: ");
        poder3 = int.Parse(Console.ReadLine());
        Console.Write("E por último, coloque sua pontuação: ");
        pontuacao3 = int.Parse(Console.ReadLine());
        quantHerois++;

    }
    else if (heroi4 == "Disponível")
    {

        Console.Write("Primeiro coloque o nome do herói: ");
        heroi4 = Console.ReadLine();
        Console.Write("Agora insira o poder dele: ");
        poder4 = int.Parse(Console.ReadLine());
        Console.Write("E por último, coloque sua pontuação: ");
        pontuacao4 = int.Parse(Console.ReadLine());
        quantHerois++;

    }
    else if (heroi5 == "Disponível")
    {

        Console.Write("Primeiro coloque o nome do herói: ");
        heroi5 = Console.ReadLine();
        Console.Write("Agora insira o poder dele: ");
        poder5 = int.Parse(Console.ReadLine());
        Console.Write("E por último, coloque sua pontuação: ");
        pontuacao5 = int.Parse(Console.ReadLine());
        quantHerois++;

    } else
    {

        Console.WriteLine("Você atingiu o limite de 5 heróis!");

    }

}

void excluirHeroi();
{

    Console.WriteLine("Qual herói você deseja excluir?");
    Console.WriteLine($"1. {heroi1}");
    Console.WriteLine($"2. {heroi2}");
    Console.WriteLine($"3. {heroi3}");
    Console.WriteLine($"4. {heroi4}");
    Console.WriteLine($"5. {heroi5}");
    Console.WriteLine("Pressione outro caracter para sair");
    int excluir = int.Parse( Console.ReadLine());

    switch ( excluir )
    {

        case 1:

            if (heroi1 == "Disponível")
            {

                Console.WriteLine("Sem heróis nesta opção, selecione algum herói válido para excluir!");

            }
            else
            {

                heroi1 = "Disponível";
                quantHerois--;
            }
            break;

        case 2:

            if (heroi2 == "Disponível")
            {

                Console.WriteLine("Sem heróis nesta opção, selecione algum herói válido para excluir!");

            }
            else
            {

                heroi2 = "Disponível";
                quantHerois--;
            }
            break;

        case 3:

            if (heroi3 == "Disponível")
            {

                Console.WriteLine("Sem heróis nesta opção, selecione algum herói válido para excluir!");

            }
            else
            {

                heroi3 = "Disponível";
                quantHerois--;
            }
            break;

        case 4:

            if (heroi4 == "Disponível")
            {

                Console.WriteLine("Sem heróis nesta opção, selecione algum herói válido para excluir!");

            }
            else
            {

                heroi4 = "Disponível";
                quantHerois--;
            }
            break;

        case 5:

            if (heroi5 == "Disponível")
            {

                Console.WriteLine("Sem heróis nesta opção, selecione algum herói válido para excluir!");

            }
            else
            {

                heroi5 = "Disponível";
                quantHerois--;
            }
            break;

        default:

            break;
    }

}

void selecionarEquipe();
{

    if (quantHerois >= 3) {
        
        Console.WriteLine("Hora de selecionar sua equipe!");
        Console.WriteLine("")

}

void exibirEquipe();
{



}

void calcularPontuacaoTotal();
{



}