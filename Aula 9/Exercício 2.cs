using System;
class HelloWorld {
    
    public struct livro {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public int NumeroPaginas;
        public float Preco;
    }
    static void Main() {
        livro[] estoque = new livro[3];
        Console.WriteLine("Insira os dados dos livros:");
        for (int i=0; i<3; i++) {
            
            Console.Write("Título:");
            estoque[i] = new livro {Titulo = Console.ReadLine()};
            Console.Write("Autor:");
            estoque[i] = new livro {Autor = Console.ReadLine()};
            Console.Write("Ano de publicação:");
            estoque[i] = new livro {AnoPublicacao = int.Parse(Console.ReadLine())};
            Console.Write("Número de páginas:");
            estoque[i] = new livro {NumeroPaginas = int.Parse(Console.ReadLine())};
            Console.Write("Preço:");
            estoque[i] = new livro {Preco = float.Parse(Console.ReadLine())};
            if(i!=3){
                Console.WriteLine("Próximo livro:");
            }
            
        }
        
        float valorTotal = 0;
        int paginasTotal = 0;
        double mediaPaginas = 0;
        
        foreach (livro tal in estoque) {
            
            valorTotal += tal.Preco;
            paginasTotal += tal.NumeroPaginas;
            mediaPaginas = paginasTotal/estoque.Length;
            
        }
        
        Console.WriteLine($"O valor total dos livros é de: R${valorTotal}");
        Console.WriteLine($"A média de páginas dos livros é de: R${mediaPaginas}");
        
    }
}