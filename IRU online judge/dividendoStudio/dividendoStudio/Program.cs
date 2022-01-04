using System;

namespace dividendoStudio
{
	class Program
	{
		static void Main(string[] args)
		{
            int resposta = 0, count = 0;
            int entrada = Convert.ToInt32(Console.ReadLine());
            while (entrada > 0)
            {
                entrada--;
                int n = Convert.ToInt32(Console.ReadLine());
                resposta = n;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count % 2 != 0)
                    {//se entrar é impar
                        resposta = resposta - 1;
                    }
                    count = 0;
                }
                Console.WriteLine(resposta);
            }
        }
	}
}
