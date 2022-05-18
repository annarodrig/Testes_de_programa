int opcao;
double numero;
double resultado;

do
{
    Console.WriteLine("SELECIONE UMA OPÇÃO");
    Console.WriteLine("1- CALCULAR O DOBRO DO NÚMERO");
    Console.WriteLine("2- CALCULAR A TABUADA DO NÚMERO");
    Console.WriteLine("0- SAIR");

    opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 1)
    {
        Console.Clear();
        Console.Write("Insira um número:");
        numero = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        resultado = numero * 2;
        Console.WriteLine($"O resultado foi:{resultado} ");
        
    }
    else if (opcao == 2)
    {
        Console.Clear();
        Console.Write("Insira um número:");
        numero = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            resultado = numero * i;
            Console.WriteLine(resultado);
        }
    }

} while (opcao != 0);
Environment.Exit(0);
