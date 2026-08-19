public class Exercicio4
{
    public static void Executar()
    {
        double[] num = new double[2];

        for (int i = 0; i < num.Length; i++)
        {
            Console.Write($"Informe o {i + 1}º número: ");
            num[i] = double.Parse(Console.ReadLine());
        }

        if (num[0] > num[1])
        {
            Console.WriteLine($"{num[0]} é maior que {num[1]}");
        }
        else
        {
            Console.WriteLine($"{num[1]} é maior que {num[0]}");
        }
    }
}