void Second_num(int num)
{
  string int_to_str = Convert.ToString(num);
  char second_num = int_to_str[1];
  Console.WriteLine(second_num);
}
int enter_num = new Random().Next(100, 1000);
Console.WriteLine(enter_num);
Second_num(enter_num);