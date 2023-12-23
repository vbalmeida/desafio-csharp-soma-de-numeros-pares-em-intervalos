using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_csharp_soma_de_numeros_pares_em_intervalos.Models
{
class Program
{
    static void Main()
    {
    int limiteInferior = int.Parse(Console.ReadLine());
    int limiteSuperior = int.Parse(Console.ReadLine());

    int somaPares = 0;


    for(int i = limiteInferior;  i <= limiteSuperior; i++ ) 
    {
        if ( i % 2 == 0)
        {
            somaPares += i;
        }
    }
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}
}