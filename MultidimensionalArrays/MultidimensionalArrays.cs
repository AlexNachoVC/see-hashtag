﻿namespace MultidimensionalArrays
{
    public class MultidimensionalArraysClass
    {
        public static void Explore()
        {
            string[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     { "Corvette", "Camaro", "Silverado" },
                                     { "Corolla", "Camry", "Rav-4" }
                                   };

            parkingLot[0, 2] = "Fusion";

            /*foreach(string car in parkingLot)
            {
                Console.WriteLine(car);
            }*/

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}