int num = 0, max = 0, count = 0;

Console.Write("Digite um numero: ");
num = int.Parse(Console.ReadLine());

Console.Write("Digite um numero maximo de incrementos: ");
max = int.Parse(Console.ReadLine());


Console.WriteLine("Com do while: ");
count = num;
do
{
    Console.WriteLine(count);
    count++;
}
while (count <= max + num);

Console.WriteLine("Com while: ");
count = num;
while (count <= max + num)
{
    Console.WriteLine(count);
    count++;
}

Console.WriteLine("Com for: ");
for (count = num; count <= num + max; count++) {
    Console.WriteLine(count);
}
