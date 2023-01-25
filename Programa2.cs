 int[] numeros = new int[10];
    int mayornum = int.MinValue;
    int mayornumpar = -1;

    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Ingrese un número entero:");
      numeros[i] = int.Parse(Console.ReadLine());

      if (numeros[i] % 2 == 0 && numeros[i] > mayornum) {
        mayornum = numeros[i];
        mayornumpar = i;
      }
    }

    if (mayornumpar == -1) {
      Console.WriteLine("No se encontró ningún número par en el arreglo.");
    } else {
      Console.WriteLine("El número par más grande es " + mayornum + " y se encuentra en la posición " + mayornumpar + " del arreglo.");
    }