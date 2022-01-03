using System;

namespace IRU_online_judge
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0, resposta, aux=0;
            int entrada = Convert.ToInt32(Console.ReadLine());
            while(entrada>0){
                entrada--;
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i=1; i<=n; i++){
                    for(int j=1; j<=i; j++){
                      if(i%j == 0){
                        count++;
                      }  
                    }
                    if(count%2 != 0){
                        aux++;
                        Console.WriteLine(count);
                    }
                    count=0;             
                }
                    resposta = n - aux;
                    Console.WriteLine($"resposta: {resposta}");
                    aux=0;
            }
        }
    }
}