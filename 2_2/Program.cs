void multiplicity(int num_1, int num_2)
{
  if(num_1 % num_2 == 0) 
    Console.WriteLine("Yes");
  else 
    Console.WriteLine("No");
  
}
multiplicity(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
