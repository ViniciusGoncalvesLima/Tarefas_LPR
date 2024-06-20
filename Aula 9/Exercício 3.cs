using System;
class HelloWorld {
    
    public struct livro {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public double NumeroPaginas;
        public float Preco;
    }
    static void Main() {
        livro[] estoque = new livro[3];
        Console.WriteLine("Insira os dados dos livros:");
        for (int i=0; i<3; i++) {
            
            livro Livro = new livro();
            Console.Write("Título:");
            Livro.Titulo = Console.ReadLine();
            Console.Write("Autor:");
            Livro.Autor = Console.ReadLine();
            Console.Write("Ano de publicação:");
            Livro.AnoPublicacao = int.Parse(Console.ReadLine());
            Console.Write("Número de páginas:");
            Livro.NumeroPaginas = double.Parse(Console.ReadLine());
            Console.Write("Preço:");
            Livro.Preco = float.Parse(Console.ReadLine());
            if(i!=2){
                Console.WriteLine("Próximo livro:");
            }
            estoque[i] = Livro;
            
        }
        
        float valorTotal = 0;
        double paginasTotal = 0;
        double mediaPaginas = 0;
        
        foreach (livro tal in estoque) {
            
            valorTotal += tal.Preco;
            paginasTotal += tal.NumeroPaginas;
            Console.WriteLine($"paginas total: {tal.NumeroPaginas}");
            Console.WriteLine($"paginas total: {paginasTotal}");
            
        }
        
        mediaPaginas = paginasTotal/estoque.Length;
        Console.WriteLine($"O valor total dos livros é de: R${valorTotal}");
        Console.WriteLine($"A média de páginas dos livros é de: {mediaPaginas}");
        
    }
}