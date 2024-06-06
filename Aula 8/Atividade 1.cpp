#include <iostream>
using namespace std;

int main()
{
    int numeros[10];
    int pares[10];
    int impares[10];
    
    cout<<"Digite 10 números inteiros"<<endl;
    
    for (int i=0; i<10; i++) {
        cin>>numeros[i];
    }
    
    for(int i=0;i<10;i++) {
        
        if(numeros[i]%2 == 0) {
            
            pares[i] = numeros[i];
            
        } else {
            
            impares[i] = numeros[i];
            
        }
        
    }
    
    cout<<"Os números pares são: "<<endl;
    for(int i=0;i<10;i++){
        
        cout<<pares[i]<<endl; 
        
    }
    
    cout<<"E os números ímpares são: "<<endl;
    for(int i=0;i<10;i++){
        
        cout<<impares[i]<<endl; 
        
    }
    
    return 0;
}