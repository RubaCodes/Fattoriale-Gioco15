int[] campoDiGioco = {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };


void printCampo(int[] array) {
    int count = 0;
        for (int i = 0; i < campoDiGioco.Length; i++) {
            Console.Write(" " + campoDiGioco[i] + " ");
            count++;
        if (count == 4) {
            Console.WriteLine();
            count = 0;
            }
        }
}

printCampo(campoDiGioco);