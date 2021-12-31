using System;

namespace IRU_online_judge
{
    class Program
    {
        static void Main(string[] args)
        {
            int count0=0,count1=0,count2=0,count3=0,count4=0,count5=0,count6=0,count7=0,count8=0,count9=0;
            string a = Console.ReadLine();
            int lengthA = a.Length;
            
            string b = Console.ReadLine();
            int lengthB = (b.Length);

            int intA = Int32.Parse(a);
            int intB = Int32.Parse(b);

            for(int i=intA, j=0; i<=intB && j<=lengthA; i++,j++){
                int aux = 10*10;
                aux = aux % 10;

                switch(aux) {
                    case 0:
                        count0 = count0 + 1; 
                        break;
                    case 1:
                        count1 = count1 + 1;
                        break;
                    case 2:
                        count2 = count2 + 1;
                        break;
                    case 3:
                        count3 = count3 + 1;
                        break;
                    case 4:
                        count4 = count4 + 1;
                        break;
                    case 5:
                        count5 = count5 + 1;
                        break;
                    case 6:
                        count6 = count6 + 1;
                        break;
                    case 7:
                        count7 = count7 + 1;
                        break;
                    case 8:
                        count8 = count8 + 1;
                        break;
                    case 9:
                        count9 = count9 + 1;
                        break;
                    default:
                        Console.WriteLine("Merda");
                        break;
                }
            }
            Console.WriteLine($"{count0} {count1} {count2} {count3} {count4} {count5} {count6} {count7} {count8} {count9}");
        }
    }
}
/*Diana escreverá uma lista com todos os inteiros positivos entre A e B, inclusive, na base decimal e sem zeros à esquerda. Ela quer saber quantas vezes cada um dos dígitos irá ser usado.

Entrada
Cada caso de teste é dado em uma única linha que contém dois inteiros A e B (1 ≤ A ≤ B ≤ 108). O último caso de teste é seguido por uma linha contendo dois zeros.
Saída
Para cada caso de teste, imprima uma única linha com 10 inteiros representando o número de vezes que cada dígito é usado ao escrever todos os inteiros entre A e B, inclusive, na base decimal e sem zeros à esquerda. Escreva a contagem de cada dígito em ordem crescente do 0 até o 9.*/