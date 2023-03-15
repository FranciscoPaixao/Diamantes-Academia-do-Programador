namespace Diamantes_Academia_do_Programador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                Console.Write("Informe um numero impar: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("O numero nao e impar!");
                }
                else
                {
                    break;
                }
            }
            int meio = (num / 2) + 1;
            int quantidadeHashtag = 0;
            for (int i = 0; i < meio; i++)
            {
                quantidadeHashtag++;
                Console.WriteLine("");
                for (int j = 0; j < num; j++)
                {
                    if (j >= meio - quantidadeHashtag && j < meio + quantidadeHashtag - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            quantidadeHashtag = meio;
            for (int i = meio; i < num; i++)
            {
                quantidadeHashtag--;
                Console.WriteLine("");
                for (int j = 0; j < num; j++)
                {
                    if (j >= meio - quantidadeHashtag && j < meio + quantidadeHashtag - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            while (true) ;
        }

    }
}