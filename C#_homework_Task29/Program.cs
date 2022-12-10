// задаёт массив из 8 элементов и выводит их на экран

int[] array = new int[8];
Random number = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = number.Next(0,100);

}


for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");

}

