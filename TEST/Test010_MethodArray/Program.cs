int[] array = {1,12,31,4,6,43,77,55,75,43};

int n = array.Length;
int find = 43;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    
    //index = index + 1;
    index++;
}

