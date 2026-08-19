public class Exercicio3
{
    public static void Executar()
    {
        Console.Write("Insira um número: ");
        double num = double.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Par");
        } 
        else
        {
            Console.WriteLine("Ímpar");
        }
    }
}