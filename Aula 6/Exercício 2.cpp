#include <iostream>
#include <random>
using namespace std;

int main()
{
    
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    int chute, tentativas = 0;
    int acertou = 0;
    
    cout<<"Olá! Um número aleatório de 1 a 100 foi selecionado, qual o seu chute?"<<endl;
    cin>>chute;
    
    while(acertou == 0) {
    
    if(chute>valorInteiro) {
        
        cout<<"Chutou alto! Tente novamente."<<endl;
        cin>>chute;
        
    } else if (chute<valorInteiro) {
        
        cout<<"Chutou baixo! Tente novamente."<<endl;
        cin>>chute;
        
    } else {
        
        cout<<"Você acertou!!! Parabéns!"<<endl;
        acertou = 1;
        
    }
    
    tentativas++;
    
    }
    if (tentativas == 1) {
        
        cout<<"Incrível! Você acertou de primeira!!!"<<endl;
        
    } else {

    cout<<"Você levou " << tentativas << " tentativas para acertar. Consegue fazer melhor?"<<endl;
    
    }
    return 0;
}