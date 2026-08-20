public class Exercicio9
{
    public static void Executar()
    {
        double[] numeros = new double[5];
        double maior = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Insira o {i + 1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());

            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine($"Maior número: {maior}");
    }
}