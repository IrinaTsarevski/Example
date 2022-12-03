int[] array = {2, 36, 56, 71, 86, 94, 71, 79, 23, 5, 7, 71};

int n = array.Length;
int find = 71;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}