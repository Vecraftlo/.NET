
int silnia = 12; //bo silnia z 12 - n!=1⋅2⋅3⋅...⋅(n−1)⋅n
int ndwa = 1; //
for (int number = 1; number <= silnia; number++)
{
    ndwa = ndwa * number;
}
Console.WriteLine(ndwa);


// int silnia2 = 1;
// int n = 12;
// int cn = n;

// while (n != 0)
// {
//     silnia2 *= n;
//     n--;
// }

// Console.WriteLine(cn + "! = " + silnia2);

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