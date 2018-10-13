using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoMaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            String resposta;
            Boolean controle = true;
            int maior = 0;
            int smaior=0;
            while (controle)
            {

                int[] vet = new int[5];
                for (int i = 0; i < vet.Length; i++)
                {
                    Console.WriteLine("Digite o " + (i + 1) + "º número");
                    vet[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < vet.Length; i++) {
                    if (vet[i] > maior) {
                        maior = vet[i];
                    }
                }

                for (int i = 0; i < vet.Length; i++)
                {
                    if (vet[i] != maior)
                    {
                        if (vet[i] > smaior)
                        { smaior = vet[i]; }
                    }
                }

                Console.WriteLine("O segundo maior número do vetor é: "+smaior);

                Console.WriteLine("Digite S para continuar ou N para sair");
                resposta = Console.ReadLine();
                if (resposta.ToUpper().Equals("S"))
                {
                    controle = true;
                }
                else if (resposta.ToUpper().Equals("N"))
                {
                    controle = false;
                }
                              
            }
            
        }

    }
}
