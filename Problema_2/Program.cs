Console.Write("Ingrese el número inicial (i): ");
int i = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de números primos a calcular (n): ");
int n = int.Parse(Console.ReadLine());

int[] primos = CalcularNumerosPrimos(i, n);

Console.WriteLine($"Los primeros {n} números primos a partir de {i} son:");
foreach (int primo in primos)
{
    Console.WriteLine(primo);
}

static int[] CalcularNumerosPrimos(int start, int count)
{
    int[] primes = new int[count];
    int foundPrimes = 0;
    int number = start;

    while (foundPrimes < count)
    {
        if (EsPrimo(number))
        {
            primes[foundPrimes] = number;
            foundPrimes++;
        }
        number++;
    }

    return primes;
}

static bool EsPrimo(int numero)
{
    if (numero <= 1) return false;
    if (numero == 2) return true;
    if (numero % 2 == 0) return false;

    for (int i = 3; i <= Math.Sqrt(numero); i += 2)
    {
        if (numero % i == 0) return false;
    }

    return true;
}
