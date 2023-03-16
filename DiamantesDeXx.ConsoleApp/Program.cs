using System.Reflection.Metadata.Ecma335;

namespace DiamantesDeXx.ConsoleApp
{
    internal class Program
    {
        /*
         Dado um número ímpar, exiba um diamante desenhado com a letra ‘x’.
         No diamante acima, o número é 21, pois há 21 colunas e 21 ‘x’ na linha central.
         */
        static void Main(string[] args)
        {
            const string SAIR = "S";
            string resposta = "";

                while (resposta.ToUpper() != SAIR)
                {

                int resultado = 1;
                Console.WriteLine("\n------------------");
                Console.WriteLine("Numero Ímpar: ");              
                int nm1 = Convert.ToInt32(Console.ReadLine());
                int espacos = (nm1 - 1) / 2;

                if (nm1 % 2 == 0)
                {
                    Console.WriteLine("Numero deve ser ímpar:");
                    continue;
                }
                else

                    for (int i = 1; espacos > 0; i++)
                    {

                        for (int j = 1; j <= espacos; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 1; j <= resultado; j++)
                        {
                            Console.Write("X");
                        }

                        espacos--;
                        resultado += 2;
                        Console.WriteLine("");

                    }

                for (int i = 1; resultado > 0; i++)
                {

                    for (int j = 1; j <= espacos; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= resultado; j++)
                    {
                        Console.Write("X");
                    }

                    espacos++;
                    resultado -= 2;
                    Console.WriteLine("");
                }

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

            }
            Console.ReadLine();
        }
     }        
 }
