using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    
    List <string> nomes = new List<string>();
    List <string> nomesOrdem = new List<string>();
    
    Console.WriteLine("Quanto nomes serão inseridos?");
    uint quant = uint.Parse(Console.ReadLine());
    Console.Write("Insira um nome: ");
    
    for(int i=0; i<quant; i++) {
        
        if(i==0){
        } else if(i!=quant-1){
            Console.Write("Insira um outro nome: ");
        } else {
            Console.Write("Insira o último nome: ");
        }
        string anem = Console.ReadLine();
        nomes.Add(anem);
        
    }
    
    int tamanho, tamanhoant = 0;
    
    while(nomes.Count != 0) {
        
        foreach(string nome in nomes) {
        
        tamanho = nome.Length;
        if(tamanho >= tamanhoant){
            nomesOrdem.Add(nome);
        } else {
            
            for(int i=0; i<=nomesOrdem.Count; i++) {
                
                if(tamanho<nomesOrdem[i].Length) {
                    
                    nomesOrdem.Insert(i, nome);
                    
                }
                
            }
            
        }
        tamanhoant = tamanho;
        nomes.Remove(nome);
        
        }
    }
        
        foreach(string nome in nomesOrdem) {
        
        tamanho = nome.Length;
        do{
            
            Console.Write($"{nome}");
            
        } while(tamanho==tamanhoant);
        tamanhoant = tamanho;
        nomes.Remove(nome);
        
        }
        Console.WriteLine("");
    
  }
}