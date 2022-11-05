int Inicio = 0;
Console.ForegroundColor = ConsoleColor.White;
System.Console.Write("Números pares entre 0 e ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
while (Inicio <= numeroDigitado)
{
       System.Console.Write($"{Inicio} ");
    Inicio += 2;
}

Console.ResetColor();
System.Console.WriteLine();