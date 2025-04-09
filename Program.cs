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

    static void EX02()
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

    static void EX03()
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
                    EX03();
                break;
                
                default:
                    Console.WriteLine("Caracter invalido.");
                break;
            }
            Console.WriteLine("\n|Deseja ver outro teste de mese ?|");
            Console.WriteLine("|0 - Encerrar programa           |");
            Console.WriteLine("|1 - Escolher outro teste de mesa|\n");
            var input = Console.ReadLine();
            //teste
            int.TryParse(input, out refaser);
        }while (refaser>0);
    }
}
