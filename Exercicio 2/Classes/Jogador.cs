using System;

namespace Exercicio_2.Classes
{
    public abstract class Jogador
    {
        public string Nome;
        public int DataDeNascimento;
        public string Nacionalidade;
        public string Altura;
        public string Peso;
        public int idade;

        public virtual void Imprimir(){
            Console.WriteLine("Digite o nome do jogador: \n");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento do jogador: \n");
            DataDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nacionalidade do jogador: \n");
            Nacionalidade = Console.ReadLine();
            Console.WriteLine("Digite a altura do jogador: \n");
            Altura = Console.ReadLine();
            Console.WriteLine("Digite o peso do jogador: \n");
            Peso = Console.ReadLine();
        }



        public virtual void CalcularIdade(){
            idade =  DateTime.Now.Year - DataDeNascimento ;
        }

        public virtual string CalcularAposenta(){
            
            return "";
        }
    }
}