public class Mesa02_1
{
	public static void EX01()
	{
		decimal resultado;

		Console.WriteLine("+=================================================+"); 
		Console.WriteLine("Informe o valor que você tem agora:");
		decimal inicial =decimal.Parse(Console.ReadLine());

		Console.WriteLine("\nInforme a taxa de juros:");

		decimal taxa =decimal.Parse(Console.ReadLine());
		taxa = taxa /100;
		Console.WriteLine("\nInforme a quantidade de meses:");

		int meses =int.Parse(Console.ReadLine());

		Console.WriteLine("+=================================================+");

		resultado = inicial * (decimal)Math.Pow((1 + (double)taxa), meses);
		

		Console.WriteLine($"Resultado dos juros compostos: {resultado:C2}");
	}

}