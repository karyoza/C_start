void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int index = collection.Length;
    int count = 0;
    int position = -1;

    while(count < index)
    {
        if(collection[count] == find)
        {
           position = count;
           break;
            
        }
        count++;
    }
        return position;
    
}


int [] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);

