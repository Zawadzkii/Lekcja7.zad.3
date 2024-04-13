using System; // Importuje przestrzeń nazw System, która zawiera podstawowe funkcje do obsługi wejścia i wyjścia.

class Program
{
	static void Main() // Główna metoda programu.
	{
		Console.Write("Podaj liczbę całkowitą: "); // Wyświetla komunikat proszący użytkownika o podanie liczby.

		// Pobranie liczby od użytkownika i konwersja na typ int.
		int liczba = Convert.ToInt32(Console.ReadLine());

		// Sprawdzenie, czy liczba jest większa od zera (dodatnia).
		if (liczba > 0)
		{
			Console.WriteLine($"{liczba} jest liczbą dodatnią."); // Wyświetla komunikat informujący, że liczba jest dodatnia.
		}
		// Sprawdzenie, czy liczba jest mniejsza od zera (ujemna).
		else if (liczba < 0)
		{
			Console.WriteLine($"{liczba} jest liczbą ujemną."); // Wyświetla komunikat informujący, że liczba jest ujemna.
		}
		// Jeśli liczba nie jest ani dodatnia, ani ujemna, to jest to zero.
		else
		{
			Console.WriteLine($"{liczba} jest zerem."); // Wyświetla komunikat informujący, że liczba jest zerem.
		}

		Console.ReadLine(); // Oczekiwanie na wciśnięcie klawisza przed zakończeniem działania programu.
	}
}