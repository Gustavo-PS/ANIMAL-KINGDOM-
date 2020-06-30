using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    public static class ArvoreBinaria
    {
        private static Nodo raiz = null; // raiz da árvore
        private static int qtdeNodosInternos = 0; // qtde de nos internos

        static Lista resultado; // utilizada na listagem dos nodos - MUDAR

        private static int maiorProfundidadeEncontrada = 0; // não necessário
        private static int qtdeNodosExternos = 0; // não necessário


        /// <summary>
        /// Retorna a qtde de nós internos
        /// </summary>
        /// <returns>Quantidade de elementos inseridos na árvore</returns>
        public static int QtdeNodosInternos() // devolve a qtde de nós internos
        {
            return qtdeNodosInternos;
        }

        /// <summary>
        /// Insere um valor na árvore. Não aceita valores repetidos!!!
        /// </summary>
        /// <param name="valor">valor a ser inserido</param>
        public static void Insere(Animal valor) // insere um valor int
        {
            Nodo no_aux;
            if (qtdeNodosInternos == 0) // árvore vazia!
            {
                // árvore vazia, devemos criar o primeiro Nodo, que será a raiz
                no_aux = new Nodo();
                raiz = no_aux;
                qtdeNodosExternos += 2;
            }
            else
            {
                qtdeNodosExternos++;
                // localiza onde deve ser inserido o novo nó.
                no_aux = PesquisaValor(valor, raiz, new ComparadorNome()); //pesquisar pelo nome
                if (no_aux.EhInterno())
                {
                    throw new Exception("Este valor já existe na árvore!!!!");
                }
            }


            // este era um Nodo externo e portanto não tinha filhos.
            // Agora ele passará a ser interno, portanto devemos criar outros 2
            // nodos externos (filhos) para ele.
            no_aux.SetValor(valor);
            no_aux.SetNoEsquerda(Nodo.CriaNoExterno(no_aux));
            no_aux.SetNoDireita(Nodo.CriaNoExterno(no_aux));
            qtdeNodosInternos++;
        }

        public static int TotalNodosExternos()
        {
            return qtdeNodosExternos;
        }


        /// <summary>
        /// Pesquisa um nodo na árvore e devolve o nodo. Caso não encontre, devolve o nodo
        /// externo onde a pesquisa parou.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        private static Nodo PesquisaValor(Animal valor, Nodo no, IComparer comparador)
        {
            if (no == null)
                return null;
            else if (no.EhExterno())
                return no; // não achou!
            else if (no.GetValor().Nome == valor.Nome)//comparador = 0
                return no;
            else if (comparador.Compare(valor, no.GetValor()) > 0)    //comparar o tamanho de dois Nomes
                return PesquisaValor(valor, no.GetNoDireita(),new ComparadorNome());
            else
                return PesquisaValor(valor, no.GetNoEsquerda(), new ComparadorNome());
        }


        /// <summary>
        /// Remove um valor da árvore
        /// </summary>
        /// <param name="valor"></param>
        public static void Remove(Animal valor)
        {
            //primeiro, procuramos o nodo que tem o valor:
            Nodo noQueSeraApagado = PesquisaValor(valor, raiz, new ComparadorNome());

            if (noQueSeraApagado == null || noQueSeraApagado.EhExterno())
                throw new Exception("Valor não existe na árvore");
            else
            {
                // um dos filhos é um nó externo
                if (noQueSeraApagado.GetNoEsquerda().EhExterno() ||
                noQueSeraApagado.GetNoDireita().EhExterno())
                {
                    ExcluiComNodoExterno(noQueSeraApagado);
                }
                else
                {
                    ExcluiSemNodoExterno(noQueSeraApagado);
                }
            }

            if (qtdeNodosInternos == 0)
                qtdeNodosExternos = 0;
        }

        /// <summary>
        /// Exclui um nodo que abaixo dele possua, ao menos, 1 nodo exteno.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private static void ExcluiComNodoExterno(Nodo noQueSeraApagado)
        {
            qtdeNodosExternos--;
            qtdeNodosInternos--;
            //descobre quem será o nodo que irá ficar no lugar do que foi apagado
            Nodo nodo_substituto;
            if (noQueSeraApagado.GetNoEsquerda().EhInterno())
                nodo_substituto = noQueSeraApagado.GetNoEsquerda();
            else
                nodo_substituto = noQueSeraApagado.GetNoDireita();
            // substitui o apagado pelo novo nodo
            Nodo PaiNodoApagado = noQueSeraApagado.GetNoPai();
            //altera o pai do novo substituto
            nodo_substituto.SetNoPai(PaiNodoApagado);
            //o pai do nodo substituto também deve ter sua referência de filho corrigida.
            //mas primeiro precisamos saber o no apagado er a raiz, que neste caso não tem pai.
            if (PaiNodoApagado != null)
            {
                if (PaiNodoApagado.GetNoDireita() == noQueSeraApagado)
                    PaiNodoApagado.SetNoDireita(nodo_substituto);
                else
                    PaiNodoApagado.SetNoEsquerda(nodo_substituto);
            }
            else
                raiz = nodo_substituto;
        }
        /// <summary>
        /// Pesquisa o próximo nodo Interno seguindo o percurso interfixado.
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        private static Nodo PesquisaNodoInternoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return null;
            Nodo retorno = PesquisaNodoInternoInterfixado(no.GetNoEsquerda());
            if (retorno == null)
                return no;
            else
                return retorno;
        }

        /// <summary>
        /// Exclui um nodo que abaixo dele não há nodos externos.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private static void ExcluiSemNodoExterno(Nodo noQueSeraApagado)
        {
            //encontra o nodo substituto
            Nodo NodoSubstituto = PesquisaNodoInternoInterfixado(noQueSeraApagado.GetNoDireita());
            Console.Write("Nodo substituto: " + NodoSubstituto.GetValor());
            //Altera o valor do nodo que será removido pelo valor do nodo substituto
            noQueSeraApagado.SetValor(NodoSubstituto.GetValor());
            //Remove o nodo substituto
            ExcluiComNodoExterno(NodoSubstituto);
        }


       
        public static bool Pesquisa(Animal animal)
        {
            Nodo nodo = PesquisaValor(animal, raiz, new ComparadorNome());
            //return (nodo != null && nodo.GetValor() == numero)
            return (nodo != null && nodo.EhInterno());
        }
        

        public static int CalculaAlturaArvore()
        {
            maiorProfundidadeEncontrada = 0;
            CalculaAltura(raiz);
            return maiorProfundidadeEncontrada;
        }

       
        private static void PercursoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixado(no.GetNoEsquerda());
            resultado.InserirNoFim(no.GetValor());
            PercursoInterfixado(no.GetNoDireita());
        }
        

        /// <summary>
        /// Devolve um string com os elementos da árvore, em ordem crescente
        /// </summary>
        /// <returns></returns>
        public static Lista ListagemInterfixada()
        {
            resultado = new Lista();
            if (qtdeNodosInternos != 0)
                PercursoInterfixado(raiz);
            return resultado;
        }


        private static void PercursoPosFixado(Nodo no)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixado(no.GetNoEsquerda());
            PercursoInterfixado(no.GetNoDireita());
            resultado.InserirNoFim(no.GetValor());
        }

        public static Lista PercursoPosFixado()
        {
            resultado = new Lista();
            if (qtdeNodosInternos != 0)
                PercursoPosFixado(raiz);
            return resultado;
        }


        private static void PercursoPrefixado(Nodo no)
        {
            if (no.EhExterno())
                return;

            resultado.InserirNoFim(no.GetValor());
            PercursoInterfixado(no.GetNoEsquerda());
            PercursoInterfixado(no.GetNoDireita());
        }


        public static Lista PercursoPrefixado()
        {
            resultado = new Lista();
            if (qtdeNodosInternos != 0)
                PercursoPrefixado(raiz);
            return resultado;
        }




        /// <summary>
        /// Calcula a altura
        /// </summary>
        /// <param name="no"></param>
        private static void CalculaAltura(Nodo no)
        {
            if (no.EhExterno())
            {
                //calcular a profundidade deste nodo externo
                Nodo aux = no;
                int qtde = 0;
                while (!aux.NoEhRaiz())
                {
                    qtde++;
                    aux = aux.GetNoPai();
                }

                if (qtde > maiorProfundidadeEncontrada)
                    maiorProfundidadeEncontrada = qtde;
                return;
            }
            CalculaAltura(no.GetNoEsquerda());
            CalculaAltura(no.GetNoDireita());
        }
        
    }
}
