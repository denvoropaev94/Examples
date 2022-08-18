int[] arr = new int[8];

  int[] FillArray(int[] array){
  for(int i = 0;i<array.Length;i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
                array[i] = int.Parse(Console.ReadLine());
    }
    return array;
  }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }


        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

int[] n= FillArray(arr);
PrintArray(n);

SelectionSort(arr);

PrintArray(arr);