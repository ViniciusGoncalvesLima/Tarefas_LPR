#include <iostream>
#include <list>
using namespace std;

int main()
{
    
    list<int> numeros;
    list<int> numerosApag;
    
    srand (time(NULL));
    
    for(int i=0; i<100; i++) {
        
        numeros.push_back(rand());
        
    }
    
    numeros.sort();
    cout << "Lista dos 100 números aleatórios em ordem crescente:" << endl;
    cout << "" << endl;
    
    for (int numero : numeros) {
        
        cout << numero << endl;
        
    }
    
    cout << "" << endl;
    cout << "Lista dos números sem os pares:" << endl;
    cout << "" << endl;
    
    int maior = 0;
    
    for (int numero : numeros) {
        
        if (numero%2 == 0) {
            
            numerosApag.push_back(numero);
            
        } else {
            
            cout << numero << endl;
            if (numero > maior) {
                
                maior = numero;
                
            }
            
        }
        
    }
        
        for (int numeroapag : numerosApag) {
                
            numeros.remove(numeroapag);
            
        }
    
    cout << "" << endl;
    cout << "Números repetidos:" << endl;
    cout << "" << endl;
    
    int numeroant = -1;
    bool repetiu = false;
    
    for (int numero : numeros) {
        
        if (numero == numeroant) {
            
            cout << numero << endl;
            repetiu = true;
            
        }
        
        numeroant = numero;
    }
    
    if (!repetiu) {
        
        cout << "Sem repetições de números" << endl;
        
    }
    
}