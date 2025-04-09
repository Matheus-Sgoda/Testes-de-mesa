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

        Console.Write(a);
        Console.Write(b);
        Console.Write(aux);
        Console.Write(c);

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
        int[] v = new int[10];

        while (a <= 6)
        {
            v[a] = 10 * a;
            a += 1;
        }
        
        for (int i = 0; i <10; i++)
        {
            Console.WriteLine(v[i]);
        }
    }



    static void Main()
    {
        int refaser;
        
        do 
        {
            Console.WriteLine("\n|Informe qual Teste de mesa voce deseja ver:|");
            Console.WriteLine("|1 - Teste de mesa 01|");
            Console.WriteLine("|2 - Teste de mesa 02|");
            Console.WriteLine("|3 - Teste de mesa 03|\n");
            var opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    EX01();
                break;
                
                case "2":
                    EX02();
                break;

                case "3":
                    EX02();
                break;
                
                default:
                    Console.WriteLine("Caracter invalido.");
                break;
            }
            Console.WriteLine("\n|Deseja ver outro teste de mese ?|");
            Console.WriteLine("|0 - Encerrar programa           |");
            Console.WriteLine("|1 - Escolher outro teste de mesa|\n");
            var input = Console.ReadLine();
            int.TryParse(input, out refaser);
        }while (refaser>0);
    }
}
