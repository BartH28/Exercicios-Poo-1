using System;

namespace Exercicio_1.Classes
{
    public class Serviço : Elevadorcs
    {
        public int numeroCaixas;
        public string mCaixas(){
            Console.WriteLine("Aqui voce podera alterar o numero de caixa do Elevador de serviço");
            Console.WriteLine("Digite o numero de caixas que tera no elevador de Serviço");
            numeroCaixas = int.Parse(Console.ReadLine());
            return $@"O numero de caixas no elevador é {numeroCaixas}";
        }

        
    }
}