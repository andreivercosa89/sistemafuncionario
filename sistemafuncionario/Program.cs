using System;

namespace sistemafuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp=1;
            do
            {

                Funcionario funcionario = new Funcionario();

                Console.WriteLine("\nInforme o nome do funcionario: ");
                funcionario.Nome = Console.ReadLine();

                Console.WriteLine("\nInforme o salario: ");
                funcionario.Salario = Double.Parse(Console.ReadLine());


                Console.WriteLine("\nO Novo salario do Funcionario {0} e {1}.", funcionario.Nome, funcionario.novoSalario());
                Console.WriteLine("\nDeseja Continuar \n1 - Sim\n2 - nao");
                resp = Int32.Parse(Console.ReadLine());
            } while (resp == 1);

        }
    }
}
