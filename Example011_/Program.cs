
void FillArray(int[] collecnion)
{
    int length = collecnion.Length;
    int index = 0;
    while (index<length)
    {
        collecnion[index] = new Random().Next (1,10);
        
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position< count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}



int IndexOf(int[] collecnion, int find)
{
    int count = collecnion.Length;
    int index=0;
    int position = 0;

    while (index < count)
    {
        if(collecnion[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
