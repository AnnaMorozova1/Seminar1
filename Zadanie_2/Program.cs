Console.WriteLine("Введите числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("max " + A);
}
else if (A < B)
{
    Console.WriteLine("max " + B);
}
else
{
    Console.WriteLine(A + " = " + B);
}
