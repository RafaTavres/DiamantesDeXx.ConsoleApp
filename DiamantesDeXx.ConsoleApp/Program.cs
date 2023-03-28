using System.Reflection.Metadata.Ecma335;

namespace DiamantesDeXx.ConsoleApp
{
    internal class Program
    {
        static int resultado = 1;
        static int numeroDigitado;
        static int espacos;
        static void Main(string[] args)
        {
            const string SAIR = "S";
            string resposta = "";

            while (resposta.ToUpper() != SAIR)
            {
                PegaOsNumeroDigitado();

                if (numeroDigitado % 2 == 0)
                {
                    MensagemDeErro("Numero deve ser ímpar:");
                    continue;
                }
                else
                EscreveParteDeCimaDoDIamante();
                EscreveParteDebaixoDoDIamante();
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

            }

        }
        static void EscreveParteDebaixoDoDIamante()
        {
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
        }
        static void EscreveParteDeCimaDoDIamante()
        {
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
        }
        static void PegaOsNumeroDigitado()
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine("Numero Ímpar: ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());
            espacos = (numeroDigitado - 1) / 2;
        }
        static void MensagemDeErro(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }        
 }
