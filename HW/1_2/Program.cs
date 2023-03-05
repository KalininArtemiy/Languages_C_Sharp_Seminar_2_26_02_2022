// I guess i don't have a lot of C# knowledge to make experiments like in 1_1_2
void remove_2_char(int num)
{
  int first_char = num / 100;
  int second_char = num % 10;
  Console.Write(first_char);
  Console.Write(second_char);
}
int new_number = new Random().Next(1, 1000);
Console.WriteLine(new_number);
remove_2_char(new_number);