namespace Exercicio_2.Classes
{
    public class ataque : Jogador
    {
        public override string CalcularAposenta()
        {
            int aposenta = 35 - this.idade;
            return $"Falta {aposenta} anos para o jogador se aposentar";
        }
    }
}