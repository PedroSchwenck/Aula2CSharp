// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

int num1 = 20;
int num2 = 11, result;

Somador soma;
soma = new Somador();
result = soma.Soma(num1, num2);

Console.WriteLine(result);



//Conversor conversor = new Conversor();
Console.WriteLine($"A soma dos números {num1} e {num2} é igual à {result}");

double n1 = 12.0;
Console.WriteLine("A medida {0} metros corresponde à {1} milimetros",n1,Conversor.MetrosMilimetros(n1));