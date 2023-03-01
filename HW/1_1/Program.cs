void Second_num(int num)
{
  int result = ((num % 100)/10);
  Console.WriteLine(result);
}
int enter_num = new Random().Next(100, 1000);
Console.WriteLine(enter_num);
Second_num(enter_num);