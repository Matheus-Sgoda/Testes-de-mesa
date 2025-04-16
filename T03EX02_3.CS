using System;
using System.Collections.Generic;

public class Mesa03_02_03
{
    public static void EX02_03()
    {
       
        var dadosColetados = Receber.ColetarDados();
        
        // Verifica se os dados são válidos
        if (dadosColetados.valorInicial == 0)
        {
            return; 
        }

        // Extrai os valores da tupla
        double valorInicial = dadosColetados.valorInicial;
        double taxaMensal = dadosColetados.taxaMensal;
        int meses = dadosColetados.meses;
        int dias = dadosColetados.dias;

        // Coleta informações sobre retirada
        int retiradaMes = 0;
        decimal retiradaValor = 0;

        Console.WriteLine("\nDeseja fazer uma retirada?");
        Console.WriteLine("0 - Não desejo retirar");
        Console.Write("Ou informe em qual mês deseja retirar: ");
        if (!int.TryParse(Console.ReadLine(), out retiradaMes) || retiradaMes < 0)
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

        // Chama o método da calculadora para realizar os cálculos
        List<ResultadoMensal> resultados = CalculadoraJuros.CalcularRendimento(
            valorInicial, taxaMensal, meses, dias, retiradaMes, retiradaValor);

        // Chama o método para exibir os resultados em formato de tabela
        ExibidorResultados.MostrarTabela(resultados, retiradaMes, retiradaValor);
    }
}