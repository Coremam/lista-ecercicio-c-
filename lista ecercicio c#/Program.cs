
int salarioBruto, ir = 0, valorHora, horasTrabalhadas;
decimal sindicato, salarioLiquido, descontos = 0;

Console.WriteLine("Digite o valor da hora trabalhada: ");
valorHora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

salarioBruto = horasTrabalhadas * valorHora;


if (salarioBruto <= 900)
{
    ir = 0;
}
else
{
            if (salarioBruto <= 1500)
            {
                descontos = (int)(salarioBruto * 0.05);
                ir = 5;
            }
  
            else if (salarioBruto <= 2500)
            {
                descontos = (int)(salarioBruto * 0.10);
                ir = 10;
            }
    
            if(salarioBruto > 2500 )
            {
                descontos = (int)(salarioBruto * 0.20);
                ir = 20;
            }

}


sindicato = (int)(salarioBruto * 0.03);
salarioLiquido = (int)(salarioBruto - sindicato - descontos);


Console.WriteLine("Salário bruto (" + valorHora + "x" + horasTrabalhadas + ")" + "              :R$ "+salarioBruto);
Console.WriteLine("( – ) IR (" + ir + "%)                             : R$  " + descontos);
Console.WriteLine("( – ) Sindicato(3% )                : R$     " + sindicato);
Console.WriteLine("FGTS ( 11%)                            : R$ " + salarioBruto * 0.11);
Console.WriteLine("Total de descontos                : R$  " + descontos + sindicato);
Console.WriteLine("Salário Líquido                       : R$ " + salarioLiquido);