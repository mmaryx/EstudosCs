using System; //módulo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class Program{ //inicio do programa
        static void Main(string[] args)
        {
            //Constante = uma "variável" que não pode mudar o valor
            //Geralmente usado para valores importantes que não podem ser mudados

            //const float PI = 3.14159265359f;
            //PI = 2.2 > não pode

            string nome = ""; //declaração de variável

            Console.WriteLine("Escreva seu nome:\n"); //pedindo dados ao usuário
            nome = Console.ReadLine(); //lendo o dado
            Console.WriteLine("Seu nome é: "+nome); //apresentando o dado
        }
  
}
