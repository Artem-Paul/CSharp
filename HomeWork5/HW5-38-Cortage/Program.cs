(int, int) GetTwoNums(params int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return(min, max);
}
int[] array = {1, 2, 3, 4, 5, 6};
var result = GetTwoNums(1, 2, 3, 4, 5, 6);
//System.Console.WriteLine(result.Item1); 
System.Console.WriteLine(result); 