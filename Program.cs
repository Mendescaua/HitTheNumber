//Game acerte o numero gerado aleatorio
Console.WriteLine(@"
▒█░▒█ ░▀░ ▀▀█▀▀ 　 ▀▀█▀▀ █░░█ █▀▀ 　 ▒█▄░▒█ █░░█ █▀▄▀█ █▀▀▄ █▀▀ █▀▀█ 
▒█▀▀█ ▀█▀ ░░█░░ 　 ░▒█░░ █▀▀█ █▀▀ 　 ▒█▒█▒█ █░░█ █░▀░█ █▀▀▄ █▀▀ █▄▄▀ 
▒█░▒█ ▀▀▀ ░░▀░░ 　 ░▒█░░ ▀░░▀ ▀▀▀ 　 ▒█░░▀█ ░▀▀▀ ▀░░░▀ ▀▀▀░ ▀▀▀ ▀░▀▀ 

");
Console.Write("Digite um numero de 1 a 100:");

void game()
{
    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101);

    do
    {
        string numero = Console.ReadLine()!;
        int numeroInt = int.Parse(numero);

        if (numeroInt > 100 || numeroInt < 1)
        {
            Console.WriteLine("Número invalido digite um numero entre 1 a 100");
            continue;
        }
        switch (numeroInt.CompareTo(numeroAleatorio))
        {
            case 0:
                Console.WriteLine($"Parabens, você acertou o numero");
                Console.WriteLine($"Created By Mendes");
                return;
            case -1:
                Console.WriteLine($"Você errou! o numero {numeroInt} e maior doq eu pensei");
                break;
            case 1:
                Console.WriteLine($"Você errou! o numero {numeroInt} e menor doq eu pensei");
                break;
        }

    } while (true);
}
game();