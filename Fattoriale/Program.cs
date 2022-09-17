//fattoriale :


int fattoriale(int n) {
    if (n == 1 || n == 0) {
        return 1;
    }
    else { return n * fattoriale(n - 1); }
}

Console.WriteLine("Inserire il numero di cui fare il fattoriale");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(fattoriale(numero));