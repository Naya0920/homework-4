// #1
/*
int Degree(int num1, int num2)
{
  int result = 1;
  for(int i=1; i <= num2; i++)
  {
    result = result * num1;
  }
    return result;
}

  Console.Write("Enter number 1: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter number 2: ");
  int num2 = Convert.ToInt32(Console.ReadLine());

  int Degreeof = Degree(num1, num2);
  Console.WriteLine("Answer: " + Degreeof);
*/
// #2
/*
int SumNum(int n)
{
    
    int count = n;
    int next = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      next = n - n % 10;
      result = result + (n - next);
      n = n / 10;
    }
   return result;
  }

Console.Write("Enter numbser n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sumNum = SumNum(n);
Console.WriteLine("The sum of the digits in a number: " + sumNum);
*/
// #3
int [] CreateRandomArray(int size, int newNumber, int newNumbers)
{
  int[] array = new int[size];
  int a = 0;

  for (int i = 0; i < size; i++)
  {
    Console.Write("Enter new nimbers = ");
    int NewNumbers = Convert.ToInt32(Console.ReadLine());

    while (newNumber[i] != ',' && i < size)
    {
      newNumbers += newNumber[i];
       i++;
    }
    array[a] = Convert.ToInt32(newNumbers);
    if (i < size - 1)
    {
      array = array.Concat(new int[] {0}).ToArray();
    }
    a++;
  }
    return array;
}

void ShowArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Enter lenght = ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max = ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);

Console.Write("Введите ряд чисел, разделенных запятой : ");
int Numbers = Convert.ToInt32(Console.ReadLine());
Console.Write("Numbers + ","");
