//Task25

System.Console.WriteLine("Add digit A");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Add digit B");
int B = int.Parse (Console.ReadLine());

int result = 1;
for (int i = 1; i <= B; i++)
{
   result = result* A; 
}
System.Console.WriteLine("Final answer:" + result);

//Task27

System.Console.WriteLine("Add Digit ");
int digit = int.Parse(Console.ReadLine());
int Sum = 0;
while (digit>0)
{
    Sum += digit % 10;
    digit /= 10;
}

System.Console.WriteLine("Sum of digits is equal "  + Sum );


// Task 29

int[] array = {1, 2, 3, 4, 5, 6, 7, 8 };
for (int i = 0; i <array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}
