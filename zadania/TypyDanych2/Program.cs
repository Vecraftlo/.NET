
int silnia = 12; //bo silnia z 12 - n!=1⋅2⋅3⋅...⋅(n−1)⋅n
int ndwa = 1; //
for (int number = 1; number <= silnia; number++)
{
    ndwa = ndwa * number;
}
Console.WriteLine(ndwa);


int silnia2 = 1;
int n = 12;
int cn = n;

while(n != 0)
{
    silnia2 *= n;
    n --;
}

Console.WriteLine(cn + "! = " + silnia2);