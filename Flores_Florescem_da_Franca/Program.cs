using System;

namespace Flores_Florescem_da_Franca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para multiplas frases

            //string[] sentenca = new string[6];
            //string resposta = null;

            //for (int i = 0; sentenca.Length > i; i++)
            //{
            //    sentenca[i] = Console.ReadLine();
            //    string[] palavras = sentenca[i].Split(" ");
            //    if (palavras.Length > 1)
            //    {
            //        for (int x = 0; palavras.Length > x; x++)
            //        {
            //            char[] antiga = null;
            //            char[] separada = palavras[x].ToCharArray();


            //            if (x != 0)
            //            {
            //                antiga = palavras[x - 1].ToCharArray();
            //            }
            //            else
            //            {
            //                antiga = palavras[x].ToCharArray();
            //            }

            //            if (antiga[0] == separada[0])
            //                resposta = "Y";
            //            else
            //            {
            //                resposta = "N";
            //                break;
            //            }

            //        }
            //    }
            //    else
            //        resposta = null;
            //    Console.WriteLine(resposta);
            //}

            //Para uma única frase


            string resposta = null;

            string sentenca = Console.ReadLine();
            sentenca = sentenca.Replace(" ", "_").Trim().ToLower();

            string[] palavras = sentenca.Replace("_", " ").Split(" ");

            for (int x = 0; palavras.Length > x; x++)
            {
                char[] antiga = null;
                char[] separada = palavras[x].ToCharArray();

                if (x != 0)
                {
                    antiga = palavras[x - 1].ToCharArray();
                }
                else
                {
                    antiga = palavras[x].ToCharArray();
                }

                if (antiga[0] == separada[0])
                    resposta = "Y";
                else
                {
                    resposta = "N";
                    break;
                }

            }

            Console.WriteLine(resposta);

        }
    }
}
