using System;

namespace VerificacaoSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "cachorro";
            string userinput;

            do
            {
                Console.WriteLine("Digite a senha");
                userinput = Console.ReadLine();
                Console.Clear();
            } while (userinput != senha);

            Console.WriteLine("Senha correta");
        }
    }
}
