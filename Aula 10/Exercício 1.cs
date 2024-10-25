using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    
    List <string> nomes = new List<string>();
    List <string> nomesOrdem = new List<string>();
    List <string> nomesRemovidos = new List<string>();
    
    Console.WriteLine("Quanto nomes serão inseridos?");
    int quant = int.Parse(Console.ReadLine());
    Console.Write("Insira um nome: ");
    
    int maior = 0;
    
    for(int i=0; i<quant; i++) {
        
        if(i==0){
        } else if(i!=quant-1){
            Console.Write("Insira um outro nome: ");
        } else {
            Console.Write("Insira o último nome: ");
        }
        string anem = Console.ReadLine();
        nomes.Add(anem);
        
        if(anem.Length > maior) {
            
            maior = anem.Length;
            
        }
        
    }
    
    int tamanhoant = 0;
            
            for(int j=1; j<=maior; j++) {
                
                for(int i=0; i<quant; i++) {
                
                    if(j==nomes[i].Length) {
                        
                        nomesOrdem.Add(nomes[i]);
                        
                    }
                    
                    if(nomesOrdem.Count == quant) {
                        break;
                    }
                }
                
            }
            
            int total = quant;
        
        while (total != 0) {
            
            foreach(string nome in nomesOrdem) {
            if (nome.Length!=tamanhoant) {
                Console.Write($"{nome}, ");
                total--;
                nomesRemovidos.Add(nome);
            }
            
            tamanhoant = nome.Length;
            
            }
            Console.WriteLine("");
            tamanhoant = 0;
            
            foreach(string tiranome in nomesRemovidos) {
                
                nomesOrdem.Remove(tiranome);
                
            }
            
        }
    
  }
}