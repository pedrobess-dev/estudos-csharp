public class Exercicio10
{
    public static void Executar()
    {
        while (true)
        {
            Console.Write("\nInsira o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            retorno1:
            Console.WriteLine("\nEscolha a operação:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            Console.Write("Operação: ");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                Console.WriteLine($"\nResultado: {num1 + num2}");
            }
            else if (operacao == 2)
            {
                Console.WriteLine($"\nResultado: {num1 - num2}");
            }
            else if (operacao == 3)
            {
                Console.WriteLine($"\nResultado: {num1 * num2}");
            }
            else if (operacao == 4)
            {
                Console.WriteLine($"\nResultado: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("\nOperação inválida!");
                goto retorno1;
            }

            retorno2:
            Console.WriteLine("\nRealizar nova operação?\n1 - Sim\n2 - Não");
            Console.Write("Resposta: ");
            int decisao = int.Parse(Console.ReadLine());

            if (decisao == 1)
            {
                continue;
            }
            else if (decisao == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nResposta inválida!");
                goto retorno2;
            }
        }
    }
}