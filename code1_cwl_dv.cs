using System; //módulo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld{
    class Program{ //inicio do programa
        static void Main(string[] args) { //p.exe

            /*Int - negativo ou positivos -15 15
            Float - negativo ou positivos com virgula -15.5 15.5 >> double e decimal
            Bool - verdadeiro ou falso
            String - "texto"
            Char - 'a' caracter
            Var - qualquer tipo, o c# sabe qual é o tipo pelo que é escrito a frente
            Dynamic - igual var mas pode mudar o TIPO dela a qualquer momento

            pode/deve A-Z a-z
            pode 0-9 >sem< ser o primeiro caracter da variavel
            não pode ter @ $ .
            apenas _
            não pode nomes como "class" "using" "static" (nomes da sintex do cs)*/

            int segundaGuerraMundial = 1942; //declaração de variável tipo int
            float meu_salario = 1050.80f; //declaração de variável float
            string cor_fav = "Amarelo"; //declaração de variável string
            bool sGM_aconteceu = true; //declaração de variável bool
            char letra = 'A'; //declaração de variável char
            var teste = "teste var"; // declaração de variável
            dynamic num = 909;

            Console.WriteLine("Hello, World!"); //Apresenta um texto no console
            Console.WriteLine("My name is Marianna Ghiraldelli\n");

            Console.WriteLine("Ano da segunda Guerra Mundial:\n" + segundaGuerraMundial + "\n");
            //apresenta a variável no console
            Console.WriteLine("Minha cor favorita é:\n" + cor_fav + "\n");
            Console.WriteLine("Meu salário é de:\n" + meu_salario + "\n");
            Console.WriteLine("A segunda Guerra Mundial aconteceu?\n" + sGM_aconteceu + "\n");
            Console.WriteLine("O caracter é:\n"+letra + "\n");
            Console.WriteLine("Teste =\n"+teste + "\n");
            Console.WriteLine("O número é =\n"+num + "\n\n");

            meu_salario = 3413.90f; //altera o valor da variável
            cor_fav = "preto";
            num = 189.89;

            Console.WriteLine("Meu novo salário é:\n" + meu_salario + "\n");
            Console.WriteLine("Minha nova cor favorita é:\n" + cor_fav+"\n");
            Console.WriteLine("O novo número é:\n"+num+"\n\n");

            num = "mari";

            Console.WriteLine("'Num' agora virou uma palavra:\n" + num);
        } 
    }
}
