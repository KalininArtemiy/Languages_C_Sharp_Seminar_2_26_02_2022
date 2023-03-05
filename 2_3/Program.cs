void multiplicity(int num)
{
  if(num % 7 == 0 && num % 23 == 0) Console.WriteLine("Yes");
  else Console.WriteLine("No");
}
multiplicity(int.Parse(Console.ReadLine()));
