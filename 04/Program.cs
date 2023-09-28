//4.Faça um programa que leia um valor n, inteiro e positivo,
//calcule e mostre a seguinte soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + … +1 / n.

int numeroIniciador, numeroFinalizador;


Console.WriteLine("Digite o número Inicial: ");
numeroIniciador = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o número Final: ");
numeroFinalizador = Convert.ToInt32(Console.ReadLine());


    while (numeroIniciador != numeroFinalizador +1)
    {
        Console.WriteLine( "S " + 1 + "/" + numeroIniciador );

        numeroIniciador++;
    }
