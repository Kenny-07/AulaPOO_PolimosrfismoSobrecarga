using System;
using AulaPOO_PolimosrfismoSobrecarga.Classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionarios fun = new Funcionarios();

           fun.Mostrar();
           fun.Mostrar("Daniel");
           fun.Mostrar(4);

           Console.Beep();

        }
    }
}
