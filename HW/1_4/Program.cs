bool is_weekend(int num) 
{
  if(num < 8 && num > 5) 
  {
    Console.WriteLine("Yahooo weekend!");
    return true;
  }
  else if(num > 0 && num < 7) 
  {
    Console.WriteLine("It's time to work!");
    return false;
  }
  else  Console.WriteLine("Not a week day");
  return false;
}
Console.WriteLine("Enter the week day");

Console.WriteLine(is_weekend(int.Parse(Console.ReadLine())));