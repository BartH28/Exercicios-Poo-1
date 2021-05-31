using System;
using Exercicio_2.Classes;

namespace Exercicio_2
{
    class Program
    {
        static ataque a = new ataque();
        static void Main(string[] args)
        {
            Console.WriteLine("Saiba o Tempo que seu Jogador predileto ira se aposentar");

            ataque a = new ataque();
            defesa d = new defesa();
            meio m = new meio();

            m.Imprimir();

            bool retorno = false;

            do
            {
                Console.WriteLine("Qual a posição do jogador ? (m = meio | d = defesa | a = ataque)");

                string reposta = Console.ReadLine().ToUpper();

                switch (reposta)
                {
                    case "M":
                        retorno = false;
                        m.CalcularIdade();
                        Console.WriteLine($@"
Nome - {m.Nome}
Ano de Nascimento - {m.DataDeNascimento}
Nacionalidade - {m.Nacionalidade}
Altura - {m.Altura} 
Peso - {m.Peso}            
                        ");
                        Console.WriteLine(m.CalcularAposenta());
                        break;
                    case "D":
                        retorno = false;
                        d.CalcularIdade();
                        Console.WriteLine($@"
Nome - {d.Nome}
Ano de Nascimento - {d.DataDeNascimento}
Nacionalidade - {d.Nacionalidade}
Altura - {d.Altura} 
Peso - {d.Peso}            
                        ");
                        Console.WriteLine(d.CalcularAposenta());
                        break;
                    case "A":
                        retorno = false;
                        a.CalcularIdade();
                        Console.WriteLine($@"
Nome - {a.Nome}
Ano de Nascimento - {a.DataDeNascimento}
Nacionalidade - {a.Nacionalidade}
Altura - {a.Altura} 
Peso - {a.Peso}            
                        ");
                        Console.WriteLine(a.CalcularAposenta());
                        break;
                    default:
                        Console.WriteLine("Valor invalido digite novamente");
                        retorno = true;
                        break;
                }
            } while (retorno);

        }
    }
}
