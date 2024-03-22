using System;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Insira um número: ");
    int num = int.Parse(Console.ReadLine());
    int somador = 0;
    
    string digitos = (num * num).ToString();
    
    for (int i = 0; i<digitos.Length; i++) {
        
        int digito = int.Parse(digitos[i].ToString());
        somador += digito;
        
    }
    
    Console.WriteLine($"A soma dos dígitos do quadrado desse número é: {somador}");
    
  }
}