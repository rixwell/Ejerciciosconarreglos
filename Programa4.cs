int[] numeros = new int[10];

        
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingresa un número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int contador = 0;
        
        for (int i = 0; i < 10; i++)
        {
            int primerdigito = (int)(numeros[i] / Math.Pow(10, (int)Math.Log10(numeros[i])));
            if (esprimo(primerdigito))
            {
                contador++;
            }
        }

        Console.WriteLine("Hay " + contador + " números que comienzan con un dígito primo.");
    

    static bool esprimo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }