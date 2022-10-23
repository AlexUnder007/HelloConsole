void Fillarray(int[] collection) // void если метод ничего не возвращает
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        
        collection[index] = new Random().Next(1, 10); // команда, чтоб запихнуть в массив рандомные числа.
        index++;
    }
}

void printArray(int[] coll)
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
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создали новый массив с размером 10 элементов
// array[4] = 4; // принудительно назвать элемент
Fillarray(array); //void FillArray заполнил массив
printArray(array); //printArray распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

