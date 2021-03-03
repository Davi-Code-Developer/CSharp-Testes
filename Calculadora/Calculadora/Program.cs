using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Soma()
        {
            bool teste = true;
            float resultado;
            List<float> soma = new List<float>();
            Console.Clear();
            Console.WriteLine("+++++Soma+++++");
            if (teste == true)
            {
                Console.WriteLine("Digite um numero");
                float a = float.Parse(Console.ReadLine());
                if(a != 0)
                {
                    soma.Add(a);
                }
                else
                {
                    teste = false;
                    foreach (float numero in soma)
                    {
                        resultado = +numero;
                        Console.WriteLine($"A soma dos numeros é: {resultado}");
                    }
                }               
                
            }
            
            
            
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Subtração de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            float b = float.Parse(Console.ReadLine());
            float resultado = a - b;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Divisao de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Multiplicação de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            float b = float.Parse(Console.ReadLine());
            float resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.Clear();
            Console.WriteLine("Potencia de um numero");
            Console.WriteLine("Digite a base da potencia");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente da potencia");
            float b = float.Parse(Console.ReadLine());
            double resultado = Math.Pow(a,b);
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("Raiz de um numero");
            Console.WriteLine("Digite o numero");
            float a = float.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da raiz é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
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
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
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
