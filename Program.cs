
/* Matriz Aleatoria */
static int[] RandomArray()
{
    Random random = new Random();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(5, 26);
    }

    return array;
}

static void PrintMinMaxSum(int[] array)
{
    int minValue = array[0];
    int maxValue = array[0];
    int sum = 0;

    foreach (int num in array)
    {
        if (num < minValue)
        {
            minValue = num;
        }

        if (num > maxValue)
        {
            maxValue = num;
        }

        sum += num;
    }

    Console.WriteLine("Valores mínimos: " + minValue);
    Console.WriteLine("Valores máximos: " + maxValue);
    Console.WriteLine("Suma de todos los valores: " + sum);
}

{
    int[] randomArray = RandomArray();
    PrintMinMaxSum(randomArray);
}

/* Lanzamiento de Moneda */
Console.WriteLine("------------------------------");
Console.WriteLine("FUNCION LANZAMIENTO DE MONEDA");
Console.WriteLine("------------------------------");
static string TossCoin()
{
    Console.WriteLine("¡Tirando una moneda!");

    Random random = new Random();
    int resultado = random.Next(2);

    if (resultado == 0)
    {
        Console.WriteLine("Cara");
        return "Cara";
    }
    else
    {
        Console.WriteLine("Cruz");
        return "Cruz";
    }
}

{
    string resultado = TossCoin();
    Console.WriteLine("El resultado es: " + resultado);
}

/* Nombres */
Console.WriteLine("\n----------");
Console.WriteLine("Nombres");


static List<string> Nombres()
{
    List<string> nombres = new List<string> { "Alejandro", "Roberto", "Maximo", "Ximena", "Felipe","Dave","Josh","Math" };
    List<string> nombresMasDe5Caracteres = new List<string>();

    foreach (string nombre in nombres)
    {
        if (nombre.Length > 5)
        {
            nombresMasDe5Caracteres.Add(nombre);
        }
    }
    return nombresMasDe5Caracteres;
}

/*Nombres barajados */
static void Shuffle(List<string> list)
    {
        Random random = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    {
        List<string> resultado = Nombres();
        Console.WriteLine("\nNombres mas de 5 caracteres");
        foreach(string nombre in resultado){
            Console.WriteLine(nombre);
        }

        Shuffle(resultado);

        Console.WriteLine("\nNombres barajados");
        foreach(string nombre in resultado){
            Console.WriteLine(nombre);
        }
}

