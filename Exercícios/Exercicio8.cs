public class Exercicio8
{
    public static void Executar()
    {
        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{num} X {i} = {num * i}");
        }
    }
}