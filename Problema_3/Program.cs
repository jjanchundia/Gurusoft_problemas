char ojos = SolicitarCaracter("Ingrese un caracter para los ojos (O): ");
string cejas = SolicitarCadena("Ingrese dos caracteres para las cejas (-): ", 2);
char nariz = SolicitarCaracter("Ingrese un caracter para la nariz (v): ");
string boca = SolicitarCadena("Ingrese tres caracteres para la boca en el orden que se quiere que aparezcan (\\_/): ", 3);
char cabello = SolicitarCaracter("Ingrese un caracter para el cabello ($): ");
string orejas = SolicitarCadena("Ingrese dos caracteres para las orejas (<>): ", 2);
char contorno = SolicitarCaracter("Ingrese un caracter para delinear la cara o para el contorno (!): ");
string menton = SolicitarCadena("Ingrese tres caracteres para el mentón (\\_/): ", 3);

// Generar la figura de la cara humana estilizada
Console.WriteLine($" {new string(cabello, 5)} ");
Console.WriteLine($"{contorno} {cejas[0]} {cejas[1]} {contorno}");
Console.WriteLine($"{orejas[0]} {ojos} {ojos} {orejas[1]}");
Console.WriteLine($"{contorno}  {nariz}  {contorno}");
Console.WriteLine($"{contorno} {boca} {contorno}");
Console.WriteLine($" {contorno}   {contorno}");
Console.WriteLine($"  {menton} ");

static char SolicitarCaracter(string mensaje)
{
    char resultado;
    while (true)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine();
        if (entrada.Length == 1)
        {
            resultado = entrada[0];
            break;
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un solo caracter.");
        }
    }
    return resultado;
}

static string SolicitarCadena(string mensaje, int longitudEsperada)
{
    string resultado;
    while (true)
    {
        Console.Write(mensaje);
        resultado = Console.ReadLine();
        if (resultado.Length == longitudEsperada)
        {
            break;
        }
        else
        {
            Console.WriteLine($"Por favor, ingrese exactamente {longitudEsperada} caracteres.");
        }
    }
    return resultado;
}
