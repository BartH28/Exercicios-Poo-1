namespace Exercicio_2.Classes
{
    public class defesa : Jogador
    {
        public override string CalcularAposenta()
        {
            int aposenta = 40 - this.idade;
            return $"Falta {aposenta} anos para o jogador se aposentar";
        }
    }
}