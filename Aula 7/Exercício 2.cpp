#include <iostream>
#include <string>
using namespace std;

void exe1() {
    
int contador = 0, acumulador = 0;

cout << "Quantos números serão fornecidos?" << endl;
int quant;
cin >> quant;

int contagem = quant;

while (contagem > 0) {

cout << "Insira um número para adicionar à média: " << endl;
cin >> contador;

if(contador%2 == 0) {
acumulador += contador;
}

contagem--;

}

double media = acumulador / quant;
cout << "A média dos " << quant << " números é: " << media << endl;;
    
}

void exe3() {
    
    int resultado;
    const int max = 500;
    
    for (int num_select = 50; num_select<=max; num_select++) {
        
        if (num_select%3 == 0) {
            
            if (num_select%2 == 1) {
                
                resultado += num_select;
            }
        }
        
    }
    
    cout << "A soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500 é: " << resultado << endl;
    
}

void exe4() {
    
    int num;
    cout << "Insira um número: " << endl;
    cin >> num;
    int somador = 0;
    
    string digitos = to_string(num * num);
    
    for (int i = 0; i<digitos.length(); i++) {
        
        int digito = digitos[i] - '0';
        somador += digito;
        
    }
    
    cout << "A soma dos dígitos do quadrado desse número é: " << somador << endl;
    
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