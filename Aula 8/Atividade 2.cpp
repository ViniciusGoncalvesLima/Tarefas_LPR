#include <iostream>
using namespace std

int main()
{
    int numeros[10]
    int valor
    int total = 0
    
    cout<<"Digite 10 números inteiros"<<endl
    
    for (int i=0; i<10; i++) {
        cin>>numeros[i]
    }
    
    cout<<"Qual valor você gostaria de pesquisar?"<<endl
    cin>>valor
    
    for(int i=0;i<10;i++) {
        
        if(numeros[i] == valor) {
            
            cout<<"O valor "<<valor<<" aparece na posição: "<<i<<endl
            total++
            
        }
        
        if(i==9 && total!=0){
            
            cout<<"O valor "<<valor<<" aparece "<<total<<" vezes"
            
        } if(i==9 && total==0){
            
            cout<<"O valor "<<valor<<" não aparece nenhuma vez"
            
        }
        
    }
    
    return 0;
}