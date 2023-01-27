int[] numeros = new int[10];
        List<int> numerosmayordetresdigitos = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero entero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            int num = numeros[i];
            int contadordigitos = 0;

            while (num > 0)
            {
                contadordigitos++;
                num /= 10;
            }

            if (contadordigitos > 3)
            {
                numerosmayordetresdigitos.Add(i);
            }
        }

        if (numerosmayordetresdigitos.Count == 0)
        {
            Console.WriteLine("No se encontro ningun numero con mas de 3 digitos");
        }
        else
        {
            Console.WriteLine("Los numeros con mas de 3 digitos se encuentran en las siguientes posiciones:");
            foreach (int index in numerosmayordetresdigitos)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }


Console.ReadKey();
    