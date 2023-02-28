void multiplicity(int num_1, int num_2)
{
  if(num_1 % num_2 == 0) 
    Console.WriteLine("Yes");
  else 
    Console.WriteLine($"No {num_1 % num_2}");
  
}
multiplicity(35, 5);
