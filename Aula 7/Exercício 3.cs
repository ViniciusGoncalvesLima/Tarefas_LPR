using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Bem-vindo ao Joguinho da Marvel!");
    Console.WriteLine("Selecione uma das opções abaixo: ");
    Console.WriteLine("1. Cadastrar herói");
    Console.WriteLine("2. Selecionar equipe");
    Console.WriteLine("3. Exibir equipe");
    Console.WriteLine("4. Sair do Joguinho da Marvel");
    int opcao = int.Parse(Console.ReadLine());
    
    switch(opcao) {
        
        case 1:
        cadastrarHeroi();
        break;
        
        case 2:
        selecionarEquipe();
        break;
        
        case 3:
        exibirEquipe();
        break;
        
        case 4:
        Console.WriteLine("Saindo do Joguinho da Marvel...");
        sair = true;
        break;
        
        default:
        
        break;
        
    }
    
  }
}