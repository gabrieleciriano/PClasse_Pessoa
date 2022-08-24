using System;

namespace PClasse_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] CadPessoa = new string[3, 4];


            for(int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 4; c++)
                {
                    if (c == 0)
                    {
                        Console.Write("Informe seu nome: ");
                        CadPessoa[l, c] = Console.ReadLine();

                    }
                    else if (c == 1)
                    {
                        Console.Write("Informe sua Data de Nascimento: ");
                        CadPessoa[l, c] = Console.ReadLine();
                        
                    }
                    else if (c == 2)
                    {
                        Console.Write("Informe seu CPF: ");
                        CadPessoa[l, c] = Console.ReadLine();
                        
                    }
                    else if (c == 3)
                    {
                        Console.Write("Informe seu telefone: ");
                        CadPessoa[l, c] = Console.ReadLine();
                       
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Pessoa pessoa1 = new Pessoa(CadPessoa[0, 0], CadPessoa[0, 1], CadPessoa[0, 2], CadPessoa[0, 3]);
            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine();
            Pessoa pessoa2 = new Pessoa(CadPessoa[1, 0], CadPessoa[1, 1], CadPessoa[1, 2], CadPessoa[1, 3]);
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine();
            Pessoa pessoa3 = new Pessoa(CadPessoa[2, 0], CadPessoa[2, 1], CadPessoa[2, 2], CadPessoa[2, 3]);
            Console.WriteLine(pessoa3.ToString());
        }
    }
}
