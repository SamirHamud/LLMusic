using System;

namespace LLMusic
{
    class Lista
    {
        public No _cabeca, _cauda;
        public void Insere(string guarda)
        {
            No novoNo = new No();
            novoNo.Valor = guarda;

            if (_cabeca == null)
            {
                _cabeca = novoNo;
            }
            else
            {
                _cauda.Proximo = novoNo;
            }
            _cauda = novoNo;
        }

        //Retirar elemento do fim da lista
        public void retiraFim()
        {
            if (_cabeca == null)
                return;

            if (_cabeca.Proximo == null)
            {
                Console.WriteLine("Elemento retirado: " + _cabeca.Valor);
                _cabeca = null;
            }
            else
            {
                No ultimo = _cabeca.Proximo;
                No penultimo = _cabeca;

                while (ultimo.Proximo != null)
                {
                    penultimo = ultimo;
                    ultimo = ultimo.Proximo;
                }
                penultimo.Proximo = null;
                Console.WriteLine("Elemento retirado: " + ultimo.Valor);
            }
            this.exibir();
        }
        // Retira qualquer elemento.
        public void retiraSelecionado(int indice)
        {
            if (indice == 0)
            {
                retiraInicio();
                return;
            }

            No temporario = _cabeca;
            int i = 0;
            No anterior = null;

            while (temporario != null)
            {
                if (i == indice)
                {
                    anterior.Proximo = temporario.Proximo;
                    return;
                }
                else
                {
                    i++;
                    anterior = temporario;
                    temporario = temporario.Proximo;
                }
            }
        }

        //Retirar elemento do inicio da lista
        public void retiraInicio()
        {
            if (_cabeca != null)
            {
                Console.WriteLine("Elemento retirado: " + _cabeca.Valor);
                // ele seta a cabeça como o proximo elemento e mata o antigo valor que tinha guardado nessa variavel
                _cabeca = _cabeca.Proximo;
            }
            exibir();
        }

        //Exibir elementos da lista
        public void exibir()
        {
            if (_cabeca != null)
            {
                No temp = _cabeca;
                while (temp != null)
                {
                    Console.Write(temp.Valor + "  ");
                    temp = temp.Proximo;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nLista vazia");
            }
        }
    }
}
