public class Exercicio1
{
    public static void Executar()
    {
        Console.Write("Primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Resultado: " + (num1 + num2));
    }
}