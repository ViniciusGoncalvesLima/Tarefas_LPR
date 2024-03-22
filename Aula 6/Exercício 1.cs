using System;
class HelloWorld {
static void Main() {

int contador = 0, acumulador = 0;

Console.WriteLine("Quantos números serão fornecidos?");
int quant = int.Parse(Console.ReadLine());
int contagem = quant;

while (contagem > 0) {

Console.WriteLine("Insira um número para adicionar à média: ");
contador = int.Parse(Console.ReadLine());

if(contador%2 == 0) {
acumulador += contador;
}

contagem--;

}

double media = acumulador / quant;
Console.WriteLine($"{media},{acumulador},{quant}");
Console.WriteLine($"A média dos {quant} números é: {media}");

}
}