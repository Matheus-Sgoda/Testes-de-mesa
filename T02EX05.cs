public class Mesa02_5
{
    public static void EX05()
    {
        Console.WriteLine("+=================================================+");
        Console.WriteLine("Informe o valor futuro:");
        decimal resultado = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("\nInforme a taxa de juros:");
        decimal taxa = decimal.Parse(Console.ReadLine());
        taxa = taxa / 100;

        Console.WriteLine("\nInforme o tempo em anos:");
        double anos = double.Parse(Console.ReadLine());
        
        double meses = anos * 12;
        Console.WriteLine("+============================================================+");
        Console.WriteLine("\tMÊS\tTAXA_JUROS\tVALOR INICIAL\tVALOR FINAL");
        Console.WriteLine("+============================================================+");
        
        decimal inicial = resultado / (decimal)Math.Pow((1 + (double)taxa), meses);
            
        Console.WriteLine($"\t{meses}\t{taxa:P2}\t{inicial:C2}\t{resultado:C2}");
    }
}