using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    class Ordenacao
    {
        public Animal[] Ordena_BubbleSort(Animal[] vetor)
        {
            Animal aux = new Animal();
            bool houvetroca;

            do
            {
                houvetroca = false;

                for (int j = 0; j <= vetor.Length - 2; j++)
                {
                    if (vetor[j].Idade > vetor[j + 1].Idade)
                    {
                        //efetua a troca de valores                      
                        houvetroca = true;
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            while (houvetroca == true);

            return vetor;

        }
    }
}
