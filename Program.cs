using System.Diagnostics;

Console.Clear();
double notaUm, notaDois, media;
const double MEDIA_APROVACAO = 6.0;

Console.Write("Informe a nota da P1:");
notaUm = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P2:");
notaDois = Convert.ToDouble(Console.ReadLine());

media = (notaUm + notaDois) / 2;

Console.WriteLine($"Média: {media:N1}");

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


