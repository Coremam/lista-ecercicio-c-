int  valorFatorial, produto;

Console.WriteLine("Digite o valor a ser fatorado: ");
valorFatorial = Convert.ToInt32(Console.ReadLine());

produto = valorFatorial;

while (valorFatorial != 0)
{ 
    Console.WriteLine(produto + "!" + valorFatorial + "*" +(valorFatorial = valorFatorial -1)) ;
}