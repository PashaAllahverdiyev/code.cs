int[] numbers = { 3, 4, -2, 1, -5, 6 };
int count = 0;int count2 = 0;
for (int i = 0; i < numbers.Length;i++)
{ 
    if (numbers[i] > 0) 
    {
        count++;
    }else
    {
        count2++;
    }
    
        
   
}
Console.WriteLine(count);
Console.WriteLine(count2);
