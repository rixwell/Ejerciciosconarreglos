int[] numeros = new int[10];
        int sum = 0;

      
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingrese un número entero: ");
            numeros[i] = int.Parse(Console.ReadLine());
            sum += numeros[i];
        }

        
        int promedio = sum / numeros.Length;

        Console.WriteLine("El promedio entero de los números ingresados es: " + promedio);

        
        Console.ReadKey();
    