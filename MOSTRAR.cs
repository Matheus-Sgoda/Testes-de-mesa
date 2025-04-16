public class ExibidorResultados
{
    public static void MostrarTabela(List<ResultadoMensal> resultados, int retiradaMes = 0, decimal retiradaValor = 0)
    {
        
        Console.WriteLine("\nMês | Data        | Valor Anterior | Juros no Período | Valor Acumulado");
        Console.WriteLine("--------------------------------------------------------------------------");
        
    
        foreach (var resultado in resultados)
        {
       
            if (resultado.Retirada > 0)
            {
                Console.WriteLine("\n+========================================================+");
                Console.WriteLine($"Retirada de :R${resultado.Retirada}");
                Console.WriteLine("+========================================================+");
            }
            
            Console.WriteLine($"{resultado.Mes,3} | {resultado.Data:dd/MM/yyyy} | " +
                              $"R$ {resultado.ValorAnterior:F2}       | " +
                              $"R$ {resultado.JurosNoPeriodo:F2}         | " +
                              $"R$ {resultado.ValorAcumulado:F2}");
        }
        

        if (resultados.Count > 0)
        {
            var inicial = resultados[0];
            var final = resultados[resultados.Count - 1];
            double rendimentoTotal = final.ValorAcumulado - inicial.ValorAcumulado;
            double percentualRendimento = (final.ValorAcumulado / inicial.ValorAcumulado - 1) * 100;
            
            Console.WriteLine("\n+=================================================+");
            Console.WriteLine("RESUMO DO INVESTIMENTO:");
            Console.WriteLine("+=================================================+");
            Console.WriteLine($"Valor inicial: R$ {inicial.ValorAcumulado:F2}");
            Console.WriteLine($"Valor final: R$ {final.ValorAcumulado:F2}");
            Console.WriteLine($"Rendimento total: R$ {rendimentoTotal:F2} ({percentualRendimento:F2}%)");
            
            if (retiradaMes > 0)
            {
                Console.WriteLine($"Valor retirado no mês {retiradaMes}: R$ {retiradaValor:F2}");
            }
        }
    }
}