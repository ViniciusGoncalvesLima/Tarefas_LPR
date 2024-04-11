#include <iostream>
using namespace std;

void exe1() {
    
cout << "using System;" << endl;
cout << "class HelloWorld {" << endl;
cout << "static void Main() {" << endl;

cout << "int contador = 0, acumulador = 0;" << endl;

cout << "Console.WriteLine('Quantos números serão fornecidos?');" << endl;
cout << "int quant = int.Parse(Console.ReadLine());" << endl;
cout << "int contagem = quant;" << endl;

cout << "while (contagem > 0) {" << endl;

cout << "Console.WriteLine('Insira um número para adicionar à média: ');" << endl;
cout << "contador = int.Parse(Console.ReadLine());" << endl;

cout << "if(contador%2 == 0) {" << endl;
cout << "acumulador += contador;" << endl;
cout << "}" << endl;

cout << "contagem--;" << endl;

cout << "}" << endl;

cout << "double media = acumulador / quant;" << endl;
cout << "Console.WriteLine($'{media},{acumulador},{quant}');" << endl;
cout << "Console.WriteLine($'A média dos {quant} números é: {media}');" << endl;

cout << "}" << endl;
cout << "}" << endl;
    
}

void exe3() {
    
cout << "#include <iostream>" << endl;
cout << "using namespace std;" << endl;

cout << "int main()" << endl;
cout << "{" << endl;
cout << "    int resultado;" << endl;
cout << "    const int max = 500;" << endl;
    
cout << "    for (int num_select = 50; num_select<=max; num_select++) {" << endl;
        
cout << "        if (num_select%3 == 0) {" << endl;
            
cout << "            if (num_select%2 == 1) {" << endl;
                
cout << "                resultado += num_select;" << endl;
cout << "            }" << endl;
cout << "        }" << endl;
        
cout << "    }" << endl;
    
cout << "    cout << 'A soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500 é: ' << resultado << endl;" << endl;
cout << "    return 0;" << endl;
cout << "}" << endl;
    
}

void exe4() {
    
cout << "using System;" << endl;
cout << "class HelloWorld {" << endl;
cout << "  static void Main() {" << endl;
    
cout << "    Console.WriteLine('Insira um número: ');" << endl;
cout << "    int num = int.Parse(Console.ReadLine());" << endl;
cout << "    int somador = 0;" << endl;
    
cout << "    string digitos = (num * num).ToString();" << endl;
    
cout << "    for (int i = 0; i<digitos.Length; i++) {" << endl;
        
cout << "        int digito = int.Parse(digitos[i].ToString());" << endl;
cout << "        somador += digito;" << endl;
        
cout << "    }" << endl;
    
cout << "    Console.WriteLine($'A soma dos dígitos do quadrado desse número é: {somador}');" << endl;
    
cout << "  }" << endl;
cout << "}" << endl;
    
}

int main(){
    
    int opcao = 1;
    while (opcao > 0 && opcao < 5 && opcao != 2) {
    cout << "Qual exercício você gostaria de ver a resposta?" << endl;
    cout << "1. Exercício 1)" << endl;
    cout << "3. Exercício 3)" << endl;
    cout << "4. Exercício 4)" << endl;
    cin >> opcao;
    
    switch(opcao) {
        
        case 1:
        exe1();
        break;
        
        case 3:
        exe3();
        break;
        
        case 4:
        exe4();
        break;
        
        default:
        cout << "Selecione uma opção válida!" << endl;
        break;
        
    }
    }
}