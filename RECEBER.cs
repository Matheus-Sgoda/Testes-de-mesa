public class Receber
{
    
    public static (double valorInicial, double taxaMensal, int meses, int dias) ColetarDados()
    {
        Console.WriteLine("+=================================================+");
        Console.Write("Informe o valor que você tem agora: ");
        if (!double.TryParse(Console.ReadLine(), out double valorInicial) || valorInicial <= 0)
        {
            Console.WriteLine("Valor inválido.");
            return (0, 0, 0, 0); // Retorna valores zerados em caso de erro
        }

        Console.Write("Informe a taxa de juros mensal (em %): ");
        if (!double.TryParse(Console.ReadLine(), out double taxaMensal) || taxaMensal < 0)
        {
            Console.WriteLine("Taxa inválida.");
            return (0, 0, 0, 0);
        }

        Console.Write("Informe a quantidade de meses: ");
        if (!int.TryParse(Console.ReadLine(), out int meses) || meses < 0)
        {
            Console.WriteLine("Quantidade de meses inválida.");
            return (0, 0, 0, 0);
        }

        Console.Write("Informe a quantidade de dias adicionais: ");
        if (!int.TryParse(Console.ReadLine(), out int dias) || dias < 0)
        {
            Console.WriteLine("Quantidade de dias inválida.");
            return (0, 0, 0, 0);
        }

        // Retorna todos os valores coletados como uma tupla
        return (valorInicial, taxaMensal, meses, dias);
    }
}