using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void soma()
        {
            Console.Clear();
            Console.WriteLine("Soma de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"Resultado da soma é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Subtração de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado da subtração é {resultado}");
        }
        enum Menu { Soma=1,Subtracao,Divisao,Multiplicacao,Potencia,Raiz,Sair}
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo a minha primeira calculadora!");
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisão" +
                    "\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair!");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case Menu.Soma:
                        soma();
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                }
                Console.Clear();
            }
            

        }
    }
}
