using System;
class AiMeAriAPeiFon {
  static void Main() {
    
    int[,] distancias = { {0, 524, 521, 882}, {524, 0, 434, 586}, {521, 434, 0, 429}, {882, 586, 429, 0} };
    string[] cidades = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};
    int distancia1, distancia2;
    
    Console.WriteLine("Insira o nome de uma cidade:");
    string cidade = Console.ReadLine();
    Console.WriteLine("Insira o nome de outra cidade:");
    string cidade2 = Console.ReadLine();
        
    if (cidade == cidade2) {
    
    Console.WriteLine("As cidades inseridas são a mesma.");
    
    }
    
    for (int i=0;i<4;i++) {
        if (cidade == cidades[i] || cidade2 == cidades[i]) {
        
        
        
        }
    }

  }
}