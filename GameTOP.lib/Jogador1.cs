using System;
using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public readonly string nome;

        public Jogador1(String _nome)
        {
            nome = _nome;
        }

        public string Chuta()
        {
            return $"{nome} chutou \n";
        }

        public string Corre()
        {
            return $"{nome} correu \n";
        }

        public string Passe()
        {
            return $"{nome} tocou \n";
        }
    }
}