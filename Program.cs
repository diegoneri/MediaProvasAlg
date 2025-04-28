Console.Clear();
double P1, P2, P3, L1, L2, L3, L4, L5, L6, media;
const double MEDIA_APROVACAO = 6.0;

Console.Write("Informe a nota da Lista 01:");
L1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 02:");
L2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 03:");
L3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 04:");
L4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 05:");
L5 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 06:");
L6 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P1:");
P1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P2:");
P2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Informe a nota da P2:");
P3 = Convert.ToDouble(Console.ReadLine());

media = 0;

//Console.WriteLine($"Média: {media:N1}");

bool aprovado = media >= MEDIA_APROVACAO;

if (aprovado)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Aprovado!!!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Reprovado!!");
}

Console.ResetColor();


