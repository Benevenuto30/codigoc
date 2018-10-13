using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOrdenado
{
    class Program
    {
        static void Main(string[] args)
        {
            String resposta;
            Boolean controle = true;

            while (controle) { 

            int[] vet = new int[5];
            for (int i = 0; i < vet.Length; i++) {
                Console.WriteLine("Digite o "+(i+1)+"º número");
                vet[i] = int.Parse(Console.ReadLine());   
            }
            Array.Sort(vet);
            Console.WriteLine("Vetor ordenado: ");
            for (int i = 0; i < vet.Length; i++)
            {
               Console.WriteLine(vet[i]);                             
            }
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
