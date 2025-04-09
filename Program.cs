public class Mesa01
{
    static void EX01()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        int aux = c;
        c = c - 40;
        int[] v = new int[4];

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(aux);
        Console.WriteLine(c);

        for (int i = 0; i < v.Length; i++)
        {
            if (i == 3)
            {
                v[i] = a + b + c;
                Console.Write("V");
            }
            else
            {
                Console.Write("F");
            }
        }
    }

    static void EX02()
    {
        int a = 2;
        int[] v = new int[5];

        while (a < 6)
        {
            v[a] = 10 * a;
            a += 1;
        }
        Console.WriteLine(a);
    }



    static void Main()
    {
        EX01();
        EX02();

    }
}
