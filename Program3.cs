    int[] arr = new int[10];
    int primomayor = 0;
    int primomayori = -1;

    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un entero: ");
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < 10; i++) {
      if (EsPrimo(arr[i]) && arr[i] > primomayor) {
        primomayor = arr[i];
        primomayori = i;
      }
    }

    if (primomayori == -1) {
      Console.WriteLine("No se encontró ningún número primo.");
    } else {
      Console.WriteLine("El mayor número primo es " + primomayor + " y está en la posición " + (primomayori + 1) + " del arreglo.");
    }
  
   static bool EsPrimo(int n) {
    if (n <= 1) return false;
    if (n <= 3) return true;
    if (n % 2 == 0 || n % 3 == 0) return false;

    for (int i = 5; i * i <= n; i = i + 6) {
      if (n % i == 0 || n % (i + 2) == 0)
        return false;
    }
    return true;
  }

