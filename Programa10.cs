 int[] numeros = new int[10];

    Console.WriteLine("Ingresa 10 números enteros:");
    for (int i = 0; i < 10; i++) 
    {
      numeros[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Ingresa un número entero:");
    int num = int.Parse(Console.ReadLine());

    int contador = 0;
    for (int i = 0; i < 10; i++) 
    {
      if (num % numeros[i] == 0) 
      {
        contador++;
      }
    }

   
    Console.WriteLine("El número ingresado tiene " + contador + " divisores exactos entre los valores almacenados en el arreglo.");
  Console.ReadKey();