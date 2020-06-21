using System;
using System.Collections.Generic;

namespace IraDeKhan
{
    class Program
    {
        static void Main(string[] args)
        {

            string i = "";
            string arena,texto = null;
            int j = 0;

            while (i != "0 0 0")
            {
                arena = Console.ReadLine();
                texto = arena;
                string[] Arena = arena.Split(" ");

                int arena2 = Convert.ToInt32(arena[0]);
                
                while(j < Convert.ToInt32(arena[0]))
                {
                   int j2 = 0;

                }
                    
            }
           
        }
    }
}

//i = ""
//while i != "0 0 0":
//    arena = input()
//    texto = arena
//    arena = arena.split(" ")
//    j = 0
//    instr = arena[2]
//    arena2 = [int(arena[0])]
//    while int (j) < int (arena[0]):
//        j2 = 0
//        mapa = input()
//        for j3 in mapa:
//            arena2[int(j)] = [j3]
//j2 += 1
//        j += 1
//    i = texto
//print(mapa)