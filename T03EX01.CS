public class Mesa03
{
    public static void EX()
    {
    
        Console.WriteLine("+=================================================+");
        Console.WriteLine("Informe o valor que você tem agora:");
        decimal inicial = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nInforme a taxa de juros:");
        decimal taxa = decimal.Parse(Console.ReadLine());
        taxa = taxa / 100;

        Console.WriteLine("\nInforme a quantidade de anos:");
        int anos = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDeseja fazer uma retirada ?:\n0 - Não desejo retirar\nDigite em quantos meses você deseja retirar.");
        int retirada = int.Parse(Console.ReadLine());
        
        
        var data_atual = DateTime.Today;
        
        decimal retirada_valor = 0;
        
        if (retirada > 0)
        {
            Console.WriteLine("\nInforme quanto deseja retirar:");
            retirada_valor = decimal.Parse(Console.ReadLine());
        }

        int meses = anos * 12;
        decimal rendaAcumulada = inicial;
        decimal rendLiquido = 0;

        Console.WriteLine("+============================================================+");
        Console.WriteLine("MÊS\tTAXA_JUROS\tRENDIMENTO\tREND.LIQUIDO\tRENDA_ACUMULADA");
        Console.WriteLine("+============================================================+");

        Console.WriteLine($"0|\t{taxa:P2}|\t{0:C2}|\t{0:C2}|\t{rendaAcumulada:C2}");

        for (int i = 1; i <= meses; i++)
        {
            // Calcula o rendimento do mês atual
            decimal rendimento = rendaAcumulada * taxa;
            
            // Adiciona o rendimento à renda acumulada
            rendaAcumulada += rendimento;
            
            // Calcula o rendimento líquido (total acumulado - valor inicial)
            rendLiquido +=  rendimento;
            
            // Realiza a retirada se for o mês especificado
            if (i == retirada)
            {
                rendaAcumulada -= retirada_valor;
                Console.WriteLine($"\n+=============================================+\n-{retirada_valor:C2} retirado no mês {i}\n+=====================================================+");
            }

            Console.WriteLine($"{i}|\t{taxa:P2}|\t{rendimento:C2}|\t{rendLiquido:C2}|\t{rendaAcumulada:C2}");
        }
    



    } 
}