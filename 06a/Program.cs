int quantidadeParcelas, valorCarro;
decimal valorFinal = 0, valorParcelas = 0, descontos, acrecimo;

Console.WriteLine("Digite o valor do carro: ");
valorCarro = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de parcelas \n0\n6\n12\n18\n24\n30\n36\n42\n48\n54\n60: ");
quantidadeParcelas = Convert.ToInt32((Console.ReadLine()));

switch (quantidadeParcelas)
{
    case 0:
        {
            descontos = (int)(valorCarro * 0.20);
            valorFinal = valorCarro - descontos;
        }
        break;

    case 6: 
        {
            acrecimo = (int)(valorCarro * 0.03);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 6;
        }
        break;

    case 12:
        {
            acrecimo = (int)(valorCarro * 0.06);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 12;
        }
        break;

    case 18:
        {
            acrecimo = (int)(valorCarro * 0.09);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 18;
        }
        break;

    case 24:
        {
            acrecimo = (int)(valorCarro * 0.12);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 24;
        }
        break;

    case 30:
        {
            acrecimo = (int)(valorCarro * 0.15);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 30;
        }
        break;

    case 36:
        {
            acrecimo = (int)(valorCarro * 0.18);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 36;
        }
        break;

    case 42:
        {
            acrecimo = (int)(valorCarro * 0.21);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 42;
        }
        break;

    case 48:
        {
            acrecimo = (int)(valorCarro * 0.24);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 48;
        }
        break;

    case 54:
        {
            acrecimo = (int)(valorCarro * 0.27);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 54;
        }
        break;

    case 60:
        {
            acrecimo = (int)(valorCarro * 0.30);
            valorFinal = valorCarro + acrecimo;
            valorParcelas = valorFinal / 60;
        }
        break;

}

Console.WriteLine("O valor final: " + valorFinal);
Console.WriteLine("A quantidade de parcelas: " + quantidadeParcelas);
Console.WriteLine("Valor das parcelas é: " + valorParcelas);