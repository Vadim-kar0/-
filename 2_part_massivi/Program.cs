//тут что-то буду мутить с массивами

//Первая запись массива и поиск максимального значения 

/* int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//              0      1     2    3    4    5   6   7   8   
int[] array = { 1000, 248, 3654, 454, 564, 68, 744, 88, 92 };
array[0] = 12;

int maxi = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(maxi);

 */

//Вторая запись массива и поиск чего-то того что пока я не знаю

/* 
int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;
int find = 18; 

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //прерывание после нахождения первого элемента
        break;
    }
    index++;
    //index = index + 1;
} */



//Третья запись массива с использованием 
//функций (методов) по заполнению и печати 

/* void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1 
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int possition = -1;
    //Если в массиве не будет значения которого мы ищем,
    //то результат будет равен -1 что означает отсутствие 
    //элемента в массиве
    
    while (index < count)
    {
        if(collection[index] == find)
        {
            possition = index;
            //В данный момент программа даст последнее вхождение 
            //Если нужно первое нужно остановить через брэйк
            break;
        }
        index++;
    }
    return possition;

}

//Определили массив из 10 элементов
int[] array = new int[10];
//фил аррэй заполнил принт распечатал  
FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos); */






