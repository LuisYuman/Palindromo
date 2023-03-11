

Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

if(espalindromo(palabra))
{
    Console.WriteLine($"{palabra} Es un palindromo");

}
else
{
    Console.WriteLine($"{palabra} No es un palindromo");
}

bool espalindromo(string palabra)
{
    palabra= palabra.ToLower();

    int longitud = palabra.Length;
    for(int i = 0; i < longitud/2;i++ )
    {
        if (palabra[i] != palabra[longitud -i -1])
        {
            return false;
        }
    }
    return true;
}