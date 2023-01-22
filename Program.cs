// #1
/*
int Degree(int num1, int num2){
  int result = 1;
  for(int i=1; i <= num2; i++)
  {
    result = result * num1;
  }
    return result;
}

  Console.Write("Enter number 1: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter number 2: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int Degreeof = Degree(numberA, numberB);
  Console.WriteLine("Answer: " + Degreeof);
*/
// #2
/*
int SumNum(int n)
{
    
    int counter = Convert.ToString(n).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = n - n % 10;
      result = result + (n - advance);
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
