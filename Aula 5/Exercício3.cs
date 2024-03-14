using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Bem-vindo ao RPG!");
    Console.WriteLine("O que você gostaria de ser?");
    Console.WriteLine("1. Guerreira");
    Console.WriteLine("2. Mago");
    Console.WriteLine("3. Arqueira");
    int opcao = int.Parse(Console.ReadLine());
    
    switch (opcao) {
        
        case 1: Console.WriteLine("Você é um guerreiro! Suas habilidades são:");
        Console.WriteLine("Ataque Pesado e Defesa Total");
        break;
        
        case 2: Console.WriteLine("Você é um mago! Suas habilidades são:");
        Console.WriteLine("Bola de Fogo e Escudo de Gelo");
        break;
        
        case 3: Console.WriteLine("Você é um arqueiro! Suas habilidades são:");
        Console.WriteLine("Flecha Precisa e Disparo Triplo");
        break;
        
        default: Console.WriteLine("Escolha uma opção válida!");
        break;
        
    }
    
  }
}