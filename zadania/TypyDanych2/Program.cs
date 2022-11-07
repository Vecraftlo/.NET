
int silnia = 12; //bo silnia z 12 - n!=1⋅2⋅3⋅...⋅(n−1)⋅n
int ndwa = 1;
for (int number = 1; number <= silnia; number++)
{
    ndwa = ndwa * number;
}
Console.WriteLine(ndwa);

// int silnia (int n)
// {
//     if (n>1) 
//     { 
//       return silnia(n-1)*n; 
//     }
//     else 
//     { 
//       return 1; 
//     }
// }