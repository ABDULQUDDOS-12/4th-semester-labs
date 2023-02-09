
//int n = 5;
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine("value of i = "+ i);
//    for (int j = 1; j <= i; j++)
//    {
//        Console.WriteLine("value of j = "+ j);
//        for (int k = 1; k <= j; k++)
//        {
//            Console.WriteLine("value of k = "+ k);
//        }
//    }
//}          


int [] A = { 3, 42, 4, 65, 15, 90 };
int max = A[0];
int min = A[0];
for (int i = 0; i < A.Length; i++)
{
    if(A[i] > max)
    {
        max = A[i];
    }
    else if(A[i] < min)
    {
        min = A[i];
    }
}
Console.WriteLine("The maximum value of array is = " + max);

