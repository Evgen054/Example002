double[] Array = { 4, 6, 18, 10, 12, 14, 16, };

double MaxNumber(double[] Array)
{
  double max = Array[0];
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] > max) max = Array[i];
  }
  return max;
}

double MinNumber(double[] Array)
{
  double min = Array[0];
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] < min) min = Array[i];
  }
  return min;
}

double a = MaxNumber(Array); 
System.Console.WriteLine(a);
double b = MinNumber(Array); 
System.Console.WriteLine(b);
System.Console.WriteLine(a-b);
