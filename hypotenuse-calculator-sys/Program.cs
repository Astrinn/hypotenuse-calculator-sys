using System;

namespace hypotenuseCalc
{

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.Clear();
        Console.WriteLine("==== Bem vindo a Hypotenuse Calculator ====");
        Console.WriteLine("");
        Console.WriteLine("1- Calcular");
        Console.WriteLine("2- Sair");
        Console.WriteLine("");
        Console.WriteLine("Selecione a opcao desejada:");

        short res = short.Parse(Console.ReadLine());
        switch (res)
        {
            case 1 : hypotenuseCalc(); break;
            case 2 : System.Environment.Exit(0); break;
        }

    }

    static void hypotenuseCalc(){
        Console.Clear();
        Console.WriteLine("==== Digite o valor de c1(cateto oposto): ====");
        Console.WriteLine("");

        float c1 = float.Parse(Console.ReadLine());

        Console.WriteLine("==== Digite o valor de c2(cateto adjacente): ====");
        Console.WriteLine("");

        float c2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado1 = c1 * c1 + c2 * c2;
        double resultadoFinal = Math.Sqrt(resultado1);

        Console.WriteLine("=== O resultado eh : ===");
        Console.WriteLine(resultadoFinal);
        Console.ReadKey();
        Menu();

    }
}

}