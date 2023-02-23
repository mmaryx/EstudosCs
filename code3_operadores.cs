//Operadores Aritiméticos
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
            float soma = 20 + 20; //declarando variáveis
            float mult = 20 * 20;
            float sub = 20 - 20;
            float div = 20 / 20;

            Console.WriteLine("20 + 20 = "+soma); //apresentando o resultado das operações
            Console.WriteLine("20 x 20 = "+mult);
            Console.WriteLine("20 / 20 = "+div);
            Console.WriteLine("20 - 20 = "+sub+"\n\n");

            float num1 = 5.0f; //declarando novas variáveis 
            int num2 = 2;   

            soma = num1 + num2; //alterando o valor das variáveis soma/sub/mult e div
            sub = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("A soma entre os números 5 e 2 é= " +soma+ "\n"); //apresentando o resultado das operações
            Console.WriteLine("A subtração entre os números 5 e 2 é= " + sub + "\n");
            Console.WriteLine("A múltiplicação entre os números 5 e 2 é= " + mult + "\n");
            Console.WriteLine("A divisão entre os números 5 e 2 é= " + div + "\n");

            int teste = 2 + 2 * 10; //a linguagem segue as regras da matemática (* e / é prioridade, resolvido primeiro)

            //int teste = (2 + 2) * 10; > os () deram ênfase a soma, então o resultado será 40.

            Console.WriteLine(teste);
        }
    }
}