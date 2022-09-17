int[] campoDiGioco = {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15 };
int[] winningArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
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
//bool checkWinningArray(int[] playerArray) {
//    if (playerArray.Equals( winningArray)) return true;
//    return false;
//}
printCampo(campoDiGioco);

void CheckMove(int[] array ,int numero) {
    int position = Array.IndexOf(array, numero);
    Console.WriteLine(position);
    if (  position + 1 < campoDiGioco.Length && array[position + 1] == 0 ) {
        campoDiGioco[position ] = 0;
        campoDiGioco[position + 1] = numero ;
    }
    else if ((position - 1) > 0 && array[position - 1] == 0 ) {
        campoDiGioco[position -1 ] = numero;
        campoDiGioco[position] = 0;
    }
    else if (position + 4 < campoDiGioco.Length && array[position + 4] == 0) {
        campoDiGioco[position + 4] = numero;
        campoDiGioco[position] = 0;
    }
    else if ( position - 4 > 0 && array[position - 4] == 0)  {
        campoDiGioco[position - 4  ] = numero;
        campoDiGioco[position] = 0;
    }
    else {
         Console.WriteLine("non e' possibile scambiare");
    }
}


// Logica funzionante , manca il loop di gioco
//Console.WriteLine(checkWinningArray(campoDiGioco));

CheckMove(campoDiGioco, 15);
printCampo(campoDiGioco);
CheckMove(campoDiGioco, 11);
printCampo(campoDiGioco);
CheckMove(campoDiGioco, 2);
printCampo(campoDiGioco);