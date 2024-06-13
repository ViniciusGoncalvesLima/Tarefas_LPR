using System;
class TraiTchuCóuRom {
  static void Main() {
      
    int[,] matriz1 = new int[3, 3], matriz2 = new int[3, 3], matriz3 = new int[3, 3];
      
    Console.WriteLine("Insira os valores da primeira matriz:");
    for(int i=0;i<9;i++) {
            
            matriz1[i%3,i/3] = int.Parse(Console.ReadLine());
        
    }
    
    Console.WriteLine("Insira os valores da segunda matriz:");
    for(int i=0;i<9;i++) {
            
            matriz2[i%3,i/3] = int.Parse(Console.ReadLine());
        
    }
    
    for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                matriz3[i, j] = 0;
                for (int k = 0; k < 3; k++) {
                    matriz3[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }
    
    for (int i=0;i<9;i++) {
        
        Console.Write($"{matriz3[i%3,i/3]} ");
        if(i==2 || i==5 || i==8) {
            Console.WriteLine();
        }
        
    }
    
  }
}