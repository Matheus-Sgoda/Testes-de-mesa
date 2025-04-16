using System;
using System.Collections.Generic;

public class Mesa03_01
{
    public static void EX01()
    {
       
        List<double> valoresIniciais = new List<double>();
        List<double> taxasMensais = new List<double>();
        
        // Coletando os dados para as três entradas
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("+=================================================+");
            Console.WriteLine($"Entrada de dados #{i+1}");
            
            Console.Write("Informe o PRIMEIRO valor que você tem agora: ");
            if (!double.TryParse(Console.ReadLine(), out double valorInicial) || valorInicial <= 0)
            {
                Console.WriteLine("Valor inválido.");
                return;
            }
            valoresIniciais.Add(valorInicial);
            
            Console.Write("Informe a taxa de juros mensal (em %): ");
            if (!double.TryParse(Console.ReadLine(), out double taxaMensal) || taxaMensal < 0)
            {
                Console.WriteLine("Taxa inválida.");
                return;
            }
            taxasMensais.Add(taxaMensal);
        }
        

        // Exibição dos valores coletados em formato de lista
        Console.WriteLine("\n+=================================================+");
        Console.WriteLine("VALORES INICIAIS E TAXAS COLETADOS:");
        Console.WriteLine("+=================================================+");
        
        Console.WriteLine("\nValores Iniciais:");
        for (int i = 0; i < valoresIniciais.Count; i++)
        {
            Console.WriteLine($"- Entrada #{i+1}: R$ {valoresIniciais[i]:F2}");
        }
        
        Console.WriteLine("\nTaxas Mensais:");
        for (int i = 0; i < taxasMensais.Count; i++)
        {
            Console.WriteLine($"- Entrada #{i+1}: {taxasMensais[i]:F2}%");
        }
        
        // Solicita dados comuns para todos os cálculos
        Console.Write("\nInforme a quantidade de meses para o cálculo: ");
        if (!int.TryParse(Console.ReadLine(), out int meses) || meses < 0)
        {
            Console.WriteLine("Quantidade de meses inválida.");
            return;
        }
        
        Console.Write("Informe a quantidade de dias adicionais: ");
        if (!int.TryParse(Console.ReadLine(), out int dias) || dias < 0)
        {
            Console.WriteLine("Quantidade de dias inválida.");
            return;
        }
        
        Console.WriteLine("\n+=================================================+");
        Console.WriteLine("RESULTADOS FINAIS:");
        Console.WriteLine("+=================================================+");
        
        // Processa cada conjunto de dados e exibe apenas o resultado final
        for (int i = 0; i < valoresIniciais.Count; i++)
        {
            double valorInicial = valoresIniciais[i];
            double taxaMensal = taxasMensais[i];
            double valorAtual = valorInicial;
            
            DateTime dataAtual = DateTime.Today;
            double taxaAnual = taxaMensal * 12;
            double taxaDiaria = 1 + (taxaAnual / 100) / 365;
            
            // Calcula juros compostos mês a mês
            for (int mes = 1; mes <= meses; mes++)
            {
                DateTime dataAnterior = dataAtual;
                dataAtual = dataAtual.AddMonths(1);
                int diasNoPeriodo = (dataAtual - dataAnterior).Days;
                
                valorAtual = valorAtual * Math.Pow(taxaDiaria, diasNoPeriodo);
            }
            
            // Aplica os dias adicionais se houver
            if (dias > 0)
            {
                valorAtual *= Math.Pow(taxaDiaria, dias);
                dataAtual = dataAtual.AddDays(dias);
            }
            
            // Exibe apenas o resultado final para cada entrada
            Console.WriteLine($"\nEntrada #{i+1}:");
            Console.WriteLine($"Valor inicial: R$ {valorInicial:F2}");
            Console.WriteLine($"Taxa mensal: {taxaMensal:F2}%");
            Console.WriteLine($"Data final: {dataAtual:dd/MM/yyyy}");
            Console.WriteLine($"Valor final após {meses} meses e {dias} dias: R$ {valorAtual:F2}");
            Console.WriteLine($"Rendimento total: R$ {valorAtual - valorInicial:F2} ({(valorAtual/valorInicial - 1) * 100:F2}%)");
        }
    }
}