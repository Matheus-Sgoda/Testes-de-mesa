public class Mesa01_3 {
    public static void EX03()
    {
        int a=7;
        int b=a-6;
        int []v= new int[6];
        Console.WriteLine("\n\n");
        Console.WriteLine("+-----------------------------------+");
        while (b<a)
        {
            v[b]=b+a;
            Console.WriteLine($"Indice:{b} do vetor={v[b]}");
            b=b+2;
        }
        Console.WriteLine("+-----------------------------------+");
    }
}