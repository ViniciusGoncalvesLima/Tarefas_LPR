#include <iostream>
using namespace std;

int reverso(int reverse) {
    
    int retorno = 0;
    
    while (reverse) {
        
        retorno *= 10;
        retorno += reverse%10;
        reverse/=10;
        
    }
    
    cout << "O reverso do número inserido é: " << retorno << endl;
    return retorno;
    
}

int main()
{
    int num;
    
    cout << "Insira um número" << endl;
    cin >> num; 
    
    reverso(num);

    return 0;
}