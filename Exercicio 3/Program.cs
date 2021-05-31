using System;
using Exercicio_3.Classes;


namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            maquinaDeCasa m = new maquinaDeCasa();

            Console.WriteLine("Cafeteira Tabajaras Plus++");

            bool retorno = false;

            do
            {
                Console.WriteLine($@"
Café com a açucar ou sem açucar?

1 - com açucar
2 - sem açucar
3 - sair
            ");
                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        retorno = true;
                        Console.WriteLine("Digite a quantidade de açucar que você deseja adiciona no café");
                        int grama = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Café com {grama} gramas de açucar adicionado\n");
                        Console.WriteLine(m.FazerCafe(grama));
                        break;
                    case "2":
                        Console.WriteLine(m.FazerCafe());
                        Console.WriteLine($"Café com sem açucar adicionado\n");
                        retorno = true;
                        break;
                    case "3":
                        Console.WriteLine("Tchauzinho volte sempre :3");
                        retorno = false;
                        break;
                    default:
                        retorno = true;
                        Console.WriteLine("Sua opcão foi invalida, Digite novamento");
                        break;
                }

            } while (retorno);

        }
    }
}
