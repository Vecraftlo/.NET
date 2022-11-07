Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------- Zadanie 1");
Console.WriteLine("Wyświetl wszystkie liczby od -100 do 100");
Console.WriteLine("PETLA FOR");
Console.ResetColor();

for (int i = -100; i < 101; i++)
{
    Console.Write(i + ", ");

}
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

int number = -100;
while (number <= 100)
{
    Console.Write(number + ", ");
    number++;
}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();

int numberdw = -100;
do
{
    Console.Write(numberdw + ", ");
    numberdw++;
}
while (numberdw <= 100);

////ZADANIE2
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------- Zadanie 2");
Console.WriteLine("Wyświetl ilość liczb parzystych z przedziału od -100 do 100");
Console.WriteLine("PETLA FOR");
Console.ResetColor();

for (int liczba = -100; liczba < 101; liczba++)
{

    if (liczba % 2 == 0)
    {
        Console.Write(liczba + ", ");
    }
}
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

int number2 = -100;
while (number2 <= 100)
{
    if (number2 % 2 == 0)
        Console.Write(number2 + ", ");
    number2++;

}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();

int number2dw = -100;
do
{
    if (number2dw % 2 == 0)
        Console.Write(number2dw + ", ");
    number2dw++;
}
while (number2dw <= 100);

Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------- Zadanie 3");
Console.WriteLine("Wyświetl ilość liczb podzielnych przez 5 z przedziału od -100 do 100");
Console.WriteLine("PETLA FOR");
Console.ResetColor();

for (int liczba = -100; liczba < 101; liczba++)
{
    if (liczba % 5 == 0)
    {
        Console.Write(liczba + ", ");
    }
}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

int number3 = -100;
while (number3 <= 100)
{
    if (number3 % 5 == 0)
        Console.Write(number3 + ", ");
    number3++;
}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();

int number3dw = -100;
do
{
    if (number3dw % 5 == 0)
        Console.Write(number3dw + ", ");
    number3dw++;
}
while (number3dw <= 100);
Console.WriteLine(" ");


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------- Zadanie 4");
Console.WriteLine("Wyświetl ilość liczb podzielnych przez 5 z przedziału od -000 do 100");
Console.WriteLine("PETLA FOR");
Console.ResetColor();

for (int liczba = 0; liczba < 101; liczba++)
{
    if (liczba % 5 == 0)
    {
        Console.Write(liczba + ", ");
    }

}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

int number4 = 0;
while (number4 <= 100)
{
    if (number4 % 5 == 0)
        Console.Write(number4 + ", ");
    number4++;
}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();

int number4dw = 0;
do
{
    if (number4dw % 5 == 0)
        Console.Write(number4dw + ", ");
    number4dw++;

}
while (number4dw <= 100);

/*
Wyświetl liczby od -100 do 100, ale wszystkie liczby, których reszta z 
dzielenia przez 8 jest większa od 4 mają zostać pomnożone przez ich 
resztę z dzielenia.
*/
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------- Zadanie 5");
Console.WriteLine("Wyświetl liczby od -100 do 100, ale wszystkie liczby, których reszta z dzielenia przez 8 jest większa od 4 mają zostać pomnożone przez ich resztę z dzielenia.");
Console.WriteLine("PETLA FOR");
Console.ResetColor();

for (int liczba = -100; liczba < 101; liczba++)
{
    // kopiuje sobie na chwile wartosc zmiennej 'liczba' bo bede ja przeksztalcal
    // jesli spelni warunek
    // int temp = liczba;
    // int reszta = temp % 8;

    // // sprawdzamy czy reszta jest na minusie, jesli jest - odrwacamy na plus
    // if (reszta < 0)
    // {
    //     reszta = -reszta;
    // }

    // if (reszta > 4)
    // {
    //     // jesli reszta z dzielenia jest wieksza od 4, to biore jej reszte, mnoze razy temp i ustawiam
    //     // jako nowa wartosc temp
    //     // temp = -> nadaje nowa wartosc zmiennej temp
    //     // temp * -> biore aktualna wartosc temp i mnoze razy to po prawej
    //     // temp % 8 -> biore aktualna wartosc temp, dziele przez 8 i zwracam reszte
    //     //temp = temp * temp % 8;
    //     // temp *= temp % 8;
    //     temp *= reszta;
    // }

    // Console.WriteLine(temp);

    // przypadek drugi - jesli chcemy, by mnozylo razy reszta na minusie
    int temp = liczba;
    int reszta = temp % 8;

    if (reszta > 4 || reszta < -4) // && -> i, || -> lub
    {
        temp *= reszta;
    }

    Console.Write(temp + ", ");
}
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

int number5 = -100;
while (number5 <= 100)
{
    int temp = number5;
    int reszta = temp % 8;
    if (reszta > 4 || reszta < -4)
    {
        temp *= reszta;
    }
    Console.Write(temp + ", ");
    number5++;
}
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();
int number5dw = -100;
do
{
    int tempdw = number5dw;
    int resztadw = tempdw % 8;
    if (resztadw > 4 || resztadw < -4)
    {
        tempdw *= resztadw;
    }
    Console.Write(tempdw + ", ");
    number5dw++;
}
while (number5dw <= 100);


Console.WriteLine(" ");


Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(" ---------------- Zadanie 6");
Console.WriteLine("PETLA FOR");
Console.ResetColor();

for (decimal liczba2 = 0; liczba2 <= 10; liczba2 = liczba2 + 0.1m)
{
    Console.Write(liczba2 + ", ");
}
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

decimal number6 = 0;
while (number6 <= 10)
{
    Console.Write(number6 + ", ");
    number6 = number6 + 0.1m;
}
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();
decimal number6dw = 0;
do
{
    Console.Write(number6dw + ", ");
    number6dw = number6dw + 0.1m;
}
while (number6dw <= 10);
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------- Zadanie 7");
Console.WriteLine("PETLA FOR");
Console.ResetColor();
/*
Wyświetl wszystkie liczby pierwsze z przedziału 1 do 100.
*/
for (int liczba = 1; liczba < 101; liczba++)
{
    // aby sprawdzic czy jest pierwsza, to musimy sprawdzic ile ma dzielnikow
    // jesli ma tylko 2 dzielniki (liczac 1) to jest liczba pierwsza
    int dzielnik = liczba; // KOPIUJE wartosc z liczby do dzielni, np. 10
    int iloscDzielnikow = 0;

    while (dzielnik > 0)
    {
        if (liczba % dzielnik == 0)
        {
            // iloscDzielnikow = iloscDzielnikow + 1;
            // iloscDzielnikow += 1;
            iloscDzielnikow++;
        }

        // dzielnik = dzielnik - 1;
        // dzielnik -= 1;
        dzielnik--;
    }

    // Console.WriteLine("Liczba: " + liczba + " | iloscDzielnikow: " + iloscDzielnikow);

    if (iloscDzielnikow == 2)
    {
        Console.Write(liczba + ", ");
    }
}
Console.WriteLine(" ");

//for (decimal i = 0; i <= 1; i = i + 0.1m)
//{
//    Console.WriteLine(i);
//}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA WHILE");
Console.ResetColor();

int number7 = 0;
while (number7 <= 100)
{
    // tutaj przyklad liczenia dzielnikow zaczynajac od liczby rownej liczbie ktorej szukamy dzielnikow i potem schodzimy o 1 nizej
    int dzielnik7 = number7;
    int iloscDzielnikow7 = 0;

    while (dzielnik7 > 0)
    {
        if (number7 % dzielnik7 == 0)
        {
            iloscDzielnikow7++;
        }

        dzielnik7--;
    }

    // Console.WriteLine("liczba:" + liczba + " iloscDzielnikow:" + iloscDzielnikow);
    if (iloscDzielnikow7 == 2)
    {
        Console.Write(number7 + ", ");
    }

    number7++;
}

Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PETLA DO WHILE");
Console.ResetColor();

int number7dw = 0;
do
{
    int dzielnik7dw = number7dw;
    int iloscDzielnikow7dw = 0;

    while (dzielnik7dw > 0)
    {
        if (number7dw % dzielnik7dw == 0)
        {
            iloscDzielnikow7dw++;
        }

        dzielnik7dw--;
    }

    // Console.WriteLine("liczba:" + liczba + " iloscDzielnikow:" + iloscDzielnikow);
    if (iloscDzielnikow7dw == 2)
    {
        Console.Write(number7dw + ", ");
    }

    number7dw++;
}
while (number7dw <= 100);

Console.WriteLine(" ");
Console.ReadKey();



