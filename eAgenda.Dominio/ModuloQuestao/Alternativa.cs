using System;

namespace Testes_da_Mariana.Dominio.ModuloQuestao
{
    public class Alternativa
    {
        public string Descricao { get; set; }
        public bool Correta { get; set; }
        public char Letra { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
