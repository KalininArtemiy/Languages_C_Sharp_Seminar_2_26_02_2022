int third_number(int num)
{
  if(num < 100)
  {
    Console.WriteLine("The number is under 100 please enter correct number");
    return -1;
  }
  while(num > 999)
  {
    num /= 10;
  }
  return num % 10;
}

Console.WriteLine(third_number(int.Parse(Console.ReadLine())));