public class Exercicio6
{
    public static void Executar()
    {
        Console.Write("Insira a nota: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota > 6)
        {
            Console.WriteLine("Aprovado");
        }
        else if (nota >= 4)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}