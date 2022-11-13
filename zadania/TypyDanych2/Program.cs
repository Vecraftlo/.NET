
//ZADANIE 1 Wyświetl silnię dla danej losowej liczby. Możesz sobie wybrać np. int 
//number = 12, i potem sprawdzać inne.

// int silnia = 12; //bo silnia z 12 - n!=1⋅2⋅3⋅...⋅(n−1)⋅n
// int ndwa = 1; //
// for (int number = 1; number <= silnia; number++)
// {
//     ndwa = ndwa * number;
// }
// Console.WriteLine(ndwa);


// int silnia2 = 1;
// int n = 12;
// int cn = n;

// while (n != 0)
// {
//     silnia2 *= n;
//     n--;
// }

// Console.WriteLine(cn + "! = " + silnia2);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 1");
Console.WriteLine("FOR");
Console.ResetColor();


int resultf = 1;
int silniaf = 12;
for (int i = silniaf; i > 1; i--)
{
    resultf = resultf * i;

}
Console.WriteLine(resultf);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("WHILE");
Console.ResetColor();

int result2 = 1;
int silnia2 = 12;
int i2 = silnia2;
while (i2 > 1)
{
    result2 = result2 * i2;
    i2--;
}
Console.WriteLine(result2);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DO WHILE");
Console.ResetColor();

int result3 = 1;
int silnia3 = 12;
int i3 = silnia3;
do
{
    result3 = result3 * i3;
    i3--;
}
while (i3 > 1);
Console.WriteLine(result3);

//ZADANIE 2
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 2");
Console.WriteLine("---------");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 3");
Console.ResetColor();


//ZADANIE 3 Wyświetl trzeci bok trójkąta prostokątnego dla podanych dwóch jego boków przyprostokątnych.
// Wybierz dowolne liczby.

//WZÓR
// int a = 4;
// int b = 3;
// int c = (a*a)+(b*b);
// Console.WriteLine("Przeciwprostokątna jest równa:" +c);

//DZIAŁA, ALE JEST INFINITE LOOP
// int a = 4;
// int b = 3;
// for(int c =1; c >0; c++)
// {
//     c*c = (a*a)+(b*b);
// Console.WriteLine("Przeciwprostokątna jest równa:" +c);
// }

// int a = 4;
// int b = 3;
// for (int c =1; c<100; c++)
// {
//     if (c!=0)
//     {
//     c*c=(a*a)+(b*b);
//     Console.WriteLine("Przeciwprostokątna ma wartość:"+c);
//     }
//     else
//     {
//         return;
//     }
// }
//ROZWIAZANIE
int side1 = 3;
int side2 = 4;
int side3 = side1 * side1 + side2 * side2;
int result123 = 0;

for (int i3f = 0; i3f <= side3; i3f++)
{
    if (i3f * i3f == side3)
    {
        result123 = i3f;
    }
}
Console.WriteLine(result123);


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 4");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 5");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 6");//wielokrotnosc
Console.ResetColor();




Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 7");
Console.WriteLine("FOR");
Console.ResetColor();

int sideA7 = 9;
int sideB7 = 6;

int result7 = 0;

for (int i7 = 0; i7 <= sideA7 * sideB7; i7++)
{
    if (sideA7 * sideB7 == i7)
    {
        result7 = i7;
    }
}
Console.WriteLine(result7);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("WHILE");
Console.ResetColor();

int sideA7w = 9;
int sideB7w = 6;

int i7w = 0;
while (sideA7w * sideB7w > i7w)
{
    i7w++;
}
Console.WriteLine(i7w);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DO WHILE");
Console.ResetColor();

int sideA7dw = 9;
int sideB7dw = 6;

int i7dw = 0;
do
{
    i7dw++;
}
while (sideA7dw * sideB7dw > i7dw);
Console.WriteLine(i7dw);


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 8");
Console.WriteLine("FOR");
Console.ResetColor();

int podstawa8 = 5;
int wysokosc8 = 9;

int result8 = 0;

for (int i8f = 0; i8f <= podstawa8 * wysokosc8 / 2; i8f++)
{
    if (podstawa8 * wysokosc8 / 2 == i8f)
    {
        result8 = i8f;
    }
}
Console.WriteLine(result8);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("WHILE");
Console.ResetColor();

int podstawa8w = 5;
int wysokosc8w = 9;

int i8w = 0;
while (podstawa8w * wysokosc8w / 2 > i8w)
{
    i8w++;
}
Console.WriteLine(i8w);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DO WHILE");
Console.ResetColor();

int podstawa8dw = 5;
int wysokosc8dw = 9;

int i8dw = 0;
do
{
    i8dw++;
}
while (podstawa8dw * wysokosc8dw / 2 > i8dw);
Console.WriteLine(i8dw);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 9");
Console.WriteLine("FOR");
Console.ResetColor();

int podstawa9 = 7;
int wysokosc9 = 4;

int result9 = 0;

for (int i9f = 0; i9f <= podstawa9 * wysokosc9; i9f++)
{
    if (podstawa9 * wysokosc9 == i9f)
    {
        result9 = i9f;
    }
}
Console.WriteLine(result9);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("WHILE");
Console.ResetColor();

int podstawa9w = 7;
int wysokosc9w = 4;

int i9w = 0;
while (podstawa9w * wysokosc9w > i9w)
{
    i9w++;
}
Console.WriteLine(i9w);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DO WHILE");
Console.ResetColor();

int podstawa9dw = 7;
int wysokosc9dw = 4;

int i9dw = 0;
do
{
    i9dw++;
}
while (podstawa9dw * wysokosc9dw > i9dw);
Console.WriteLine(i9dw);


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("ZADANIE 10");
Console.WriteLine("FOR");
Console.ResetColor();

int podstawa10 = 5;
int wysokosc10 = 4;
int podstawa102 = 7;

int result10 = 0;

for (int i10f = 0; i10f <= ((podstawa10 + podstawa102) * wysokosc10) / 2; i10f++)
{
    if (((podstawa10 + podstawa102) * wysokosc10) / 2 == i10f)
    {
        result10 = i10f;
    }
}
Console.WriteLine(result10);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("WHILE");
Console.ResetColor();

int podstawa10w = 5;
int wysokosc10w = 4;
int podstawa102w = 7;
int i10w = 0;
while (((podstawa10w + podstawa102w) * wysokosc10w) / 2 > i10w)
{
    i10w++;
}
Console.WriteLine(i10w);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DO WHILE");
Console.ResetColor();

int podstawa10dw = 5;
int wysokosc10dw = 4;
int podstawa102dw = 7;
int i10dw = 0;
do
{
    i10dw++;
}
while (((podstawa10dw + podstawa102dw) * wysokosc10dw) / 2 > i10dw);
Console.WriteLine(i10dw);
