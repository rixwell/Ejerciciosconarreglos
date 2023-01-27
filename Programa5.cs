 int[] numeros = new int[10];
        int digitomayor= 0;
        int primomayori = -1;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero entero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            int num = numeros[i];
            int contadordigitos = 0;
            int econtadordigitos = 0;

            if (EsPrimo(num))
            {
                while (num > 0)
                {
                    int digito = num % 10;
                    if (digito % 2 == 0)
                    {
                        econtadordigitos++;
                    }
                    contadordigitos++;
                    num /= 10;
                }

                if (econtadordigitos > digitomayor)
                {
                    digitomayor = econtadordigitos;
                    primomayori = i;
                }
            }
        }

        if (primomayori == -1)
        {
            Console.WriteLine("No se encontro ningun numero primo con digitos pares");
        }
        else
        {
            Console.WriteLine("El numero primo con mas digitos pares es: " + numeros[primomayori] + " en la posicion " + primomayori);
        }
    
    static bool EsPrimo(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        var limite = (int)Math.Floor(Math.Sqrt(num));

        for (int i = 3; i <= limite; i += 2)
            if (num % i == 0)
                return false;

        return true;
    }

Console.ReadKey();
