#include <iostream>
using namespace std;

int main()
{
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
    return 0;
}