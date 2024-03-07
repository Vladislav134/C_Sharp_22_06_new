// See https://aka.ms/new-console-template for more informat
int QouNum(int num)
{
  int qount = 0;
  for (int i = 0; i < num;)
  {
     int a = num%10;
     qount = qount + a;
     num = num/10;
  }  
  return qount;
}
int b = int.Parse(Console.ReadLine()!);
int result = QouNum(b);
Console.WriteLine(result);