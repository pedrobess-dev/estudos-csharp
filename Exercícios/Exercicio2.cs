public class Exercicio2
{
    public static void Executar()
    {
        double[] notas = new double[3];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota {i + 1}:");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double media = (notas[0] + notas[1] + notas[2]) / 3;

        Console.WriteLine($"Média: {media}");
    }
}