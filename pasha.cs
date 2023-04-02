int[] numbers = { 3, 4, 8, 16, 27, 35 };
int best = numbers[0];
for (int i = 0; i < numbers.Length; i++) 
{
    if (numbers[i] > best) ;
    best = numbers[i];

}
Console.WriteLine(best);
