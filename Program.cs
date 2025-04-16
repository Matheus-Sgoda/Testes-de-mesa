using System;

class Program
{
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
                    Console.WriteLine("Informe qual exercicio Você deseja:");
                    Console.WriteLine("1 - EX 01");
                    Console.WriteLine("2 - EX 02");
                    Console.WriteLine("3 - EX 03");
                    var opcao_1 = Console.ReadLine();

                    switch (opcao_1)
                    {   
                        case "1":
                            Mesa01_1.EX01();
                            break;
                        
                        case "2":
                            Mesa01_2.EX02();
                            break;
                            
                        case "3":
                            Mesa01_3.EX03();  
                            break;
                        default:
                            Console.WriteLine("Caracter informado não suportado.");
                            break;
                    }
                    break;
                
                case "2":
                    Console.WriteLine("Informe qual exercicio Você deseja:");
                    Console.WriteLine("1 - EX 01");
                    Console.WriteLine("2 - EX 02");
                    Console.WriteLine("3 - EX 03");
                    Console.WriteLine("4 - EX 04");
                    Console.WriteLine("5 - EX 05");
                    var opcao_2 = Console.ReadLine();

                    switch (opcao_2)
                    {   
                        case "1":
                            Mesa02_1.EX01();
                            break;
                        
                        case "2":
                            Mesa02_2.EX02();
                            break;
                            
                        case "3":
                            Mesa02_3.EX03();  
                            break;

                        case "4":
                            Mesa02_4.EX04();  
                            break;    

                        case "5":
                            Mesa02_5.EX05();  
                            break;    

                        default:
                            Console.WriteLine("Caracter informado não suportado.");
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("Informe qual exercicio Você deseja:");
                    Console.WriteLine("1 - EX 01");
                    Console.WriteLine("2 - EX 02 E 03");
                    
                    var opcao_3 = Console.ReadLine();

                    switch (opcao_3)
                    {   
                        
                        case "1":
                            Mesa03_01.EX01();
                            break;
                        
                        case "2":
                            Mesa03_02_03.EX02_03();
                            break;

                        default:
                            Console.WriteLine("Caracter informado não suportado.");
                            break;
                    }
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
        } while (refaser > 0);
    }
}