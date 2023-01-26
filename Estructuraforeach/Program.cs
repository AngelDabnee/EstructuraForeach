using System;

namespace estructuraDeControlforeach// Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {   //La estructura foreach, nos permite recorrer una variable y mostrar sus letras 
            //o numeros dependiendo de que necesitemos. 
            Console.WriteLine("Hola mundo");
            string amigo = "";
            Console.WriteLine("Captura el nombre de tu amigo");
            amigo = Console.ReadLine();
            foreach (char letra in amigo)
            {   //Imprimimos el amigo que capturaste de manera letra por letra separado por una coma
                Console.Write(letra + ",");
            }
            Console.ReadKey();
        }

    }
}