// Do poniższych zadań nie możesz korzystać z żadnej wbudowanej metody 
// która by rozwiązywała zadanie (np. Contains, Min, Max). Wszystkie 
// zadania należy napisać samemu sprawdzając wartość po wartości w 
// tablicy.
// Do generowania tablicy napisz metodę, która będzie ją zwracać z 
// wylosowanymi wartościami z podanego przedziału.
// UWAGA – jeśli jest to możliwe, to do każdego zadania napisz metodę 
// obsługującą liczby całkowite oraz drugą metodę obsługującą liczby 
// zmiennoprzecinkowe (np. double)

// 1. Napisz metodę, która dla podanej tablicy zwróci najmniejszą liczbę.
Console.WriteLine("Zadanie 1: ");

{
    int[] intNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



    Console.WriteLine("Dlugosc tablicy: " + intNumbers.Length);

    for (int idx = 0; idx < intNumbers.Length; idx++)
    {
        Console.Write(intNumbers[idx] + ", ");
    }
    Console.WriteLine();
}
{
    int[] intNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int minimum = intNumbers[0];
    for (int idx = 1; idx < intNumbers.Length; idx++) ;

    if (intNumbers[0] < minimum)
    {
        minimum = intNumbers[0];
    }
    Console.WriteLine("Najmniejsza liczba dla podanej tablicy: " + minimum);
}
// 1B. Napisz metodę, która dla podanej tablicy zwróci największą liczbę.
{
    int[] intNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int max = intNumbers[0];
    for (int idx = 0; idx < intNumbers.Length; idx++)
        if (intNumbers[idx] > max)
        {
            max = intNumbers[idx];

            if (intNumbers[idx] > max)
            {

            }

        }
    Console.WriteLine("Największa liczba dla podanej tablicy: " + max);

}
// 2. Napisz metodę, która dla podanej tablicy zwróci drugą największą liczbę.
Console.WriteLine("Zadanie 2: ");



// 3. Napisz metodę, która dla podanej tablicy zwróci średnią, medianę oraz 
// modę.

Console.WriteLine("Zadanie 3: ");
{ //suma
int wynik=0;                                    //Zmienna przechowuje nasz wynik w postaci liczby całkowitej
int[] tablica = new int[] { 1, 2, 3, 4, 5 };  //Tworzymy tablice z 5 elementami: tablica[0]=4,tablica[1]=6, itd.
for (int i = 0; i < tablica.Length; i++)        //Tworzymy pętle działającą do końca tablicy
{
wynik += tablica[i];                //Dodajemy kolejne elementy tablicy
}
Console.WriteLine("Średnia dla podanej tablicy ma wartość: " + wynik/tablica.Length);                           //Wypisz wynik
Console.ReadKey();                              //Poczekaj na nacisniecie dowolnego klawisza
}

// 4. Napisz metodę, która dla podanej tablicy oraz podanej wartości zwróci 
// informację, ile razy dana liczba występuję w owej tablicy (czyli metoda 
// przyjmuje dwa argumenty: tablice oraz liczbę. następnie sprawdza ile 
// razy ta liczba wystąpiła w tej tablicy i zwraca tą ilość).
Console.WriteLine("Zadanie 4: ");

// 5. Napisz metodę, która dla podanej tablicy oraz podanej wartości zwróci 
// informację, czy dana wartość występuje w tablicy (czyli metoda 
// przyjmuje dwa argumenty: tablice oraz liczbę. następnie sprawdza czy 
// istnieje w tablicy dana liczba, a potem zwraca true/false).
Console.WriteLine("Zadanie 5: ");

// 6. Napisz metodę, która dla podanych dwóch tablic zwróci jedną tablicę 
// będącą ich połączeniem.
Console.WriteLine("Zadanie 6: ");

{
    int[] intNumbers1 = { 1, 3, 5, 7, 9 };
    int[] intNumbers2 = { 2, 4, 6, 8, 10 };
    //int[] combo = intNumbers1 + intNumbers2;

}
{
    int[] tabOne = { 3, 1, 5, 1, 6, 8 };
int[] tabTwo = { 2, 3, 1, 9 };

int[] tabNew = tabOne.Concat(tabTwo).ToArray();

}

// 7. Napisz metodę, która dla podanej tablicy zwróci nową tablicę z 
// odwróconą kolejnością wartości (np. tablica A ma wartości: 1,2,3,4,5. 
// Tablica B czyli wynik metody: 5,4,3,2,1).
Console.WriteLine("Zadanie 7: ");

// 8. Napisz metodę, która dla podanej tablicy zwróci nową tablicę, ale bez 
// powtórzeń wartości (np. tablica A ma wartości: 1,1,2,2,3. Tablica B czyli 
// wynik metody: 1,2,3).
Console.WriteLine("Zadanie 8: ");

// 9. Napisz metodę, która pozwoli do przekazanej tablicy dodawać nową 
// wartość na jej początku.
Console.WriteLine("Zadanie 9: ");

// 10.Napisz metodę, która przyjmuje trzy argumenty: tablicę, nową wartość, 
// indeks w którym należy dodać nową wartość. Np. mamy tablicę 
// [0,1,2,3,4,5], metoda AddOnIndex(tablica, nowaWartosc, 
// indeksNowejWartosci) dla przekazanych wartości AddOnIndex(tablica, 
// 101, 2), zwróci wynik: [0,1,101,2,3,4,5].
Console.WriteLine("Zadanie 10: ");

// 11.Przeczytaj o algorytmach sortowania na stronie https://codemaze.com/sorting-algorithms-csharp/ i następnie dla 5 wybranych 
// algorytmów napisz metodę, która dla podanej tablicy zwróci nową 
// tablicę, ale z posortowanymi wartościami od największej do 
// najmniejszej