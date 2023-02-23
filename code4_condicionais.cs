//Condicionais
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            > maior
            < menor
            >= maior igual
            <= menor igual
            == comparação
            != diferença

            10 > 5    - true
            10 < 5    - false
            10 >= 10  - true
            10 <= 20  - true
            10 == 8   - false
            10 != 11  - true
            
            var idade > condicional > se idade >= 18 > true > se idade <18 > false
            */

            int a = 5;
            int b = 10;

            if (10 > 2) //if == "se"
            //se isso for verdade
                Console.WriteLine("Verdade!");//execute isso
            else //else == "se não"
            //se não
                Console.WriteLine("Mentira!");//execute isso



            if (10 > 20)
                Console.WriteLine("Verdade!");
            else
                Console.WriteLine("Mentira!");


            if (10 >= 10)
                Console.WriteLine("Verdade!");
            else
                Console.WriteLine("Mentira!");


            if (10 > 20)
                Console.WriteLine("Verdade!");
            else if (10 != 10)
                Console.WriteLine("Verdade!");
            else if (10 < 10)
                Console.WriteLine("Verdade!");
            else
                Console.WriteLine("Mentira!");

            //podemos comparar dados enviados pelo usuário também.

            if (b > a)
                Console.WriteLine(b + " é maior que " + a);
            else
                Console.WriteLine(b + " não é maior que " + a);


        }
    }
}