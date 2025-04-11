public class Mesa01_1 {
    public static void EX01()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        int aux = c;
        c = c - 40;
        int[] v = new int[4];
        Console.WriteLine("\n+-----------------------------------+");
        Console.WriteLine($"A é: " + a);
        Console.WriteLine($"B é: " + b);
        Console.WriteLine($"C1 é: " + aux);
        Console.WriteLine($"C2 é: " + c);
        Console.WriteLine("+-----------------------------------+\n");
        for (int i = 0; i < v.Length; i++)
        {
            if (i == 3)
            {
                v[i] = a + b + c;
                Console.WriteLine($"V[{i}]=V");
            }
            else
            {
                Console.WriteLine($"V[{i}]=F");
            }
        }
        Console.WriteLine("\n+-----------------------------------+");
    }
}