int[] array = {21,55,674,21,90,76,33};
int n = array.Length;
int find = 21;
int index = 0;

while (index < n){
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}
