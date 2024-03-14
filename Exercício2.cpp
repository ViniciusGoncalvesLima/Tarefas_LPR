#include <iostream>
using namespace std;

int main()
{
    
    int numa, numb;
    
    cout<<"Insira um número inteiro: " << endl;
    cin >> numa;
    cout<<"Insira mais um número inteiro: " << endl;
    cin >> numb;
    
    if (numa >= numb) {
        
        if (numa % numb == 0) {
            
            cout << "São múltiplos!" << endl;
            
        } else {
            
            cout << "Não são múltiplos!" << endl;
            
        }
        
    } else {
        
        if (numb % numa == 0) {
            
            cout << "São múltiplos!" << endl;
            
        } else {
            
            cout << "Não são múltiplos!" << endl;
            
        }
        
    }

    return 0;
}