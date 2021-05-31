using System;

namespace Exercicio_2.Classes
{
    public class meio : Jogador
    {
        public override string CalcularAposenta()
        {
            int aposenta = 38 - this.idade;
            return $"Falta {aposenta} anos para o jogador se aposentar";
        }
    }
}