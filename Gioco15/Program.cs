int[] campoDiGioco = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

void printCampo(int[] array) {
	for (int i = 0; i < campoDiGioco.Length/4; i++) {
		Console.Write(campoDiGioco[i]);
	}
	Console.WriteLine();
    Console.WriteLine("----");
}

printCampo(campoDiGioco);