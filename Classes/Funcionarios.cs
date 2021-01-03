using System;
namespace AulaPOO_PolimosrfismoSobrecarga.Classes
{
    public class Funcionarios
    {
        public string Name { get; set; }

        public string [] lista = { "Paulo", "Tsuka", "Daniel", "Fábio", "Isadora" };

        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine( lista[indice] );
        }

        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca)
                {
                    Console.WriteLine( "Resultado da busca : " + item );
                }
            }
        }
    }
}