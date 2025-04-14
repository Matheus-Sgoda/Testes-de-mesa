using System;

public class Mesa03
{
    public static void EX()
    {
        decimal retiradaValor = 0;
        double valorAtual;

        Console.WriteLine("+=================================================+");
        Console.Write("Informe o valor que você tem agora: ");
        if (!double.TryParse(Console.ReadLine(), out double valorInicial) || valorInicial <= 0)
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

        Console.Write("Informe a taxa de juros mensal (em %): ");
        if (!double.TryParse(Console.ReadLine(), out double taxaMensal) || taxaMensal < 0)
        {
            Console.WriteLine("Taxa inválida.");
            return;
        }

        Console.Write("Informe a quantidade de meses: ");
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

        Console.WriteLine("\nDeseja fazer uma retirada?");
        Console.WriteLine("0 - Não desejo retirar");
        Console.Write("Ou informe em qual mês deseja retirar: ");
        if (!int.TryParse(Console.ReadLine(), out int retiradaMes) || retiradaMes < 0)
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        if (retiradaMes > 0)
        {
            Console.Write("Informe quanto deseja retirar: ");
            if (!decimal.TryParse(Console.ReadLine(), out retiradaValor) || retiradaValor < 0)
            {
                Console.WriteLine("Valor de retirada inválido.");
                return;
            }
        }

        DateTime dataAtual = DateTime.Today;
        double taxaAnual = taxaMensal * 12;
        double taxaDiaria = 1 + (taxaAnual / 100) / 365;

        valorAtual = valorInicial;

        Console.WriteLine("\nMês | Data        | Valor Anterior | Juros no Período | Valor Acumulado");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine($" 0  | {dataAtual:dd/MM/yyyy} | R$ {valorInicial:F2}       | R$ 0.00             | R$ {valorInicial:F2}");

        for (int mes = 1; mes <= meses; mes++)
        {
            DateTime dataAnterior = dataAtual;
            dataAtual = dataAtual.AddMonths(1);
            int diasNoPeriodo = (dataAtual - dataAnterior).Days;

            double valorAnterior = valorAtual;
            valorAtual = valorAtual * Math.Pow(taxaDiaria, diasNoPeriodo);
            double jurosNoPeriodo = valorAtual - valorAnterior;

            if (mes == retiradaMes)
            {
                valorAtual -= (double)retiradaValor;
                if (valorAtual < 0) valorAtual = 0;
                Console.WriteLine("\n+========================================================+");
                Console.WriteLine($"Retirada de :R${retiradaValor}");
                Console.WriteLine("\n+========================================================+");

            }

            Console.WriteLine($"{mes,3} | {dataAtual:dd/MM/yyyy} | R$ {valorAnterior:F2}       | R$ {jurosNoPeriodo:F2}         | R$ {valorAtual:F2}");
        }

        // Aplica os dias adicionais se houver
        if (dias > 0)
        {
            double valorAnterior = valorAtual;
            valorAtual *= Math.Pow(taxaDiaria, dias);
            double jurosDias = valorAtual - valorAnterior;

            DateTime dataFinal = dataAtual.AddDays(dias);
            Console.WriteLine($"{meses + 1,3} | {dataFinal:dd/MM/yyyy} | R$ {valorAnterior:F2}       | R$ {jurosDias:F2}         | R$ {valorAtual:F2}");
        }
    }
}
