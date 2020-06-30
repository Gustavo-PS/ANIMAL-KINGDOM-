using System;
using N2___Animais.ANIMAIS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    public class Lista
    {
        NodoLista primeiro = null; // ponteiro para o primeiro elemento da lista
        int qtde = 0;
        int tamanho = 0;

        public int Tamanho()
        {
            return qtde;
        }
        #region MÉTODOS DE INSERÇÃO
        private void InserirNaPosicao(NodoLista anterior, Animal valor)
        {
            NodoLista novo = new NodoLista();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (qtde == 0)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtde++;
        }

        public void InserirNoInicio(Animal valor)
        {
            InserirNaPosicao(null, valor);
        }

        public void InserirNoFim(Animal valor) 
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                NodoLista aux = primeiro;

                while (aux.Proximo != null)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, valor);
            }


        }

        public void InserirNaPosicao(Animal valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {                 //descobre qual é o nodo anterior ao que será incluído 
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

               InserirNaPosicao(aux, valor);
            }
        }

        #endregion

        public void RemoverDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");

            if (posicao == 0)
                primeiro = primeiro.Proximo;
            else
            {                 //descobre qual é o nodo anterior que será excluido     
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                aux.Proximo = aux.Proximo.Proximo;
            }
            qtde--;
        }

        #region MÉTODOS DE LISTAGEM

        /// <summary>
        /// Lista todos os animais cadastrados
        /// </summary>
        /// <returns></returns>
        public string ListarGeral()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            return r;
        }

        public Animal[] RetornaAnimais()
        {
            Animal[] r = new Animal[qtde];
            NodoLista aux = primeiro;
            int count = 0;
            while (aux != null)
            {
                r[count++] = aux.Dado;
                aux = aux.Proximo;
            }
            return r;
        }

        /// <summary>
        /// Lista apenas mamíferos
        /// </summary>
        /// <returns></returns>
        public string ListarMamifero()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if(aux.Dado is Mamifero)
                    r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ MAMÍFEROS CADASTRADOS!!";
            return r;
        }

        /// <summary>
        /// Lista apenas oviparos
        /// </summary>
        /// <returns></returns>
        public string ListarOviparo()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IOviparo)
                    r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ OVÍPAROS CADASTRADOS!!";
            return r;
            
        }

        /// <summary>
        /// Lista apenas animais aquáticos
        /// </summary>
        /// <returns></returns>
        public string ListarAquaticos()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IAquatico)
                    r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ ANIMAIS AQUÁTICOS CADASTRADOS!!";
            return r;

        }

        /// <summary>
        /// Lista apenas animais que voam 
        /// </summary>
        /// <returns></returns>
        public string ListarAnimaisVoam()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IVoar)
                    r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ ANIMAIS QUE VOAM CADASTRADOS!!";
            return r;

        }

        /// <summary>
        /// Lista apenas predadores
        /// </summary>
        /// <returns></returns>
        public string ListarPredadores()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IPredador)
                    r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ PREDADORES CADASTRADOS!!";
            return r;

        }

        /// <summary>
        /// Lista por ordem de idade
        /// </summary>
        /// <returns></returns>
        public string ListarIdade()
        {
            NodoLista aux = primeiro;
            string r = string.Empty;
            Animal[] vetorAnimal = new Animal[qtde];
            int i = 0;
            while(aux!= null)
            {
                vetorAnimal[i] = aux.Dado;
                i++;
                aux = aux.Proximo;
            }
            Ordenacao ordena = new Ordenacao();

            foreach(Animal a in ordena.Ordena_BubbleSort(vetorAnimal))
            {
                r += a.ToString() + Environment.NewLine;
            }
            return r;
        }


        public void Listar(NodoLista e)
        {
            if (e != null)
                Console.WriteLine(e.Dado);
            if (e.Proximo != null)
                Listar(e.Proximo);
        }


        #region CRIAÇÃO DE VETORES POR ANIMAL

        public string[] VetorPorAnimal(string TipoAnimal)
        {
            NodoLista aux = primeiro;
            string[] vetorAnimal = new string[qtde];
            int i = 0;
            while (aux != null)
            {                     
                if(TipoAnimal == "baleia")
                {
                    if(aux.Dado is Baleia)
                    {
                        vetorAnimal[i]= aux.Dado.Nome;
                    }
                }else if (TipoAnimal == "cachorro")
                {
                    if (aux.Dado is Cachorro)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "gato")
                {
                    if (aux.Dado is Gato)
                    {
                        vetorAnimal[i]= aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "coruja")
                {
                    if (aux.Dado is Coruja)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "elefante")
                {
                    if (aux.Dado is Elefante)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "galinha")
                {
                    if (aux.Dado is Galinha)
                    {
                        vetorAnimal[i]= aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "gaviao")
                {
                    if (aux.Dado is Gaviao)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "leao")
                {
                    if (aux.Dado is Leao)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "morcego")
                {
                    if (aux.Dado is Morcego)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "ornitorrinco")
                {
                    if (aux.Dado is Ornitorrinco)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "pato")
                {
                    if (aux.Dado is Pato)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "pinguim")
                {
                    if (aux.Dado is Pinguim)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "pombo")
                {
                    if (aux.Dado is Pombo)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }
                else if (TipoAnimal == "tartaruga")
                {
                    if (aux.Dado is Tartaruga)
                    {
                        vetorAnimal[i] = aux.Dado.Nome;
                    }
                }


                i++;
                aux = aux.Proximo;
            }
            return vetorAnimal;

        }
        #endregion

        /// <summary>
        /// pesquisar animal pelo nome
        /// </summary>
        /// <param name="nomeAnimal"></param>
        /// <returns> objeto da classe animal</returns>
        public Animal PesquisaAnimal(string nomeAnimal)
        {
            NodoLista aux = primeiro;                    
            while (aux != null)
            {
                if (aux.Dado.Nome == nomeAnimal)
                    return aux.Dado;
                aux = aux.Proximo;
            }
            return null;
        }

        #endregion
    }
}
