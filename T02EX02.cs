public class Mesa02_2
{
    public static void EX02()
    {
        Console.WriteLine("+=================================================+"); 
        Console.WriteLine("Informe o valor que você tem agora:");
        decimal inicial = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nInforme a taxa de juros:");
        decimal taxa = decimal.Parse(Console.ReadLine());
        taxa = taxa / 100;
        
        Console.WriteLine("\nInforme a quantidade de meses:");
        int meses = int.Parse(Console.ReadLine());
        
        decimal rendaAcumulada = inicial;

        Console.WriteLine("+============================================================+");
        Console.WriteLine("\tMÊS\tTAXA_JUROS\tRENDIMENTO\tREND.LIQUIDO\tRENDA_ACUMULADA");
        Console.WriteLine("+============================================================+");
        
        Console.WriteLine($"\t0\t{taxa:P2}  \t\t {0:C2}    \t{0:C2}    \t{inicial:C2}");
        
        for (int i = 1; i <= meses; i++)
        {
            //calculo da renda 
            decimal resultado = inicial * (decimal)Math.Pow((1 + (double)taxa), i);
            //calculo do rendimento 
            decimal rendimento = i == 1 ? resultado - inicial : resultado - (inicial * (decimal)Math.Pow((1 + (double)taxa), i - 1));
            //calculo do rendimento total 
            decimal rendLiquido = resultado - inicial;
            
            rendaAcumulada = resultado;
            
            Console.WriteLine($"\t{i}\t{taxa:P2} \t\t {rendimento:C2}\t{rendLiquido:C2}\t{rendaAcumulada:C2}");
        }
    }
}