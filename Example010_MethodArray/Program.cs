

int [] array = {1,2,22,4,55,13,78,98,78};

int n = array.Length;

int find = 78;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}