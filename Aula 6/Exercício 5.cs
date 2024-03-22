using System;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Bem-vindo ao simulador de treinamento de um Jedi!");
    Console.WriteLine("Insira quantas horas de treinamento você quer executar por dia: ");
    int horasPorDia = int.Parse(Console.ReadLine());
    
    while (horasPorDia>24) {
        
        Console.WriteLine("Insira um valor válido. Lembre-se de que o dia tem no máximo 24 horas!");
        horasPorDia = int.Parse(Console.ReadLine());
        
    }
    
    int diasTreino = 1000/horasPorDia;
    int semanasTreino = diasTreino/5;
    int mesesTreino = semanasTreino/(9/2);
    
    Console.WriteLine("Para alcançar 1000 horas de treino, você treinará por {0} dias, que equivalem a {1} semanas, que equivalem a {2} meses", diasTreino, semanasTreino, mesesTreino);
    
  }
}