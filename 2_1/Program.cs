int BiggestNum(int rand_num)
{
  int first_num = rand_num / 10;
  int second_num = rand_num % 10;
  int biggest_Num = 0;
  if (first_num > second_num) biggest_Num = first_num;
  else biggest_Num = second_num;
  return biggest_Num;
}
int enter_num = new Random().Next(1, 100);
Console.WriteLine(enter_num);
Console.WriteLine(BiggestNum(enter_num));