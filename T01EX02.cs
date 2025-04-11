public class Mesa01_2 {
    public static void EX02()
    {
        int a = 2;
        int[] v = new int[7];
        Console.WriteLine("\n\n");
        Console.WriteLine("+-----------------------------------+");
        while (a < 6)
        {
            v[a] = 10 * a;
            Console.WriteLine($"Indice:{a} do vetor={v[a]}");
            a += 1;
            
        }
        Console.WriteLine("+-----------------------------------+");   
    }
}