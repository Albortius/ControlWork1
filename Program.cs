// Блок ввода исходных данных
Console.Write("Введите количество элементов массива: ");
int inputArrayCount = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[inputArrayCount];
string[] lastArray  = new string[inputArrayCount];
for(int i = 0; i < inputArrayCount; i++)
{
    if(inputArrayCount  > 0)
    {
        Console.Write($"Значение {i+1}-го элемента массива: ");
        firstArray[i]   = Console.ReadLine();
        lastArray[i]    = firstArray[i];
    }
}
// логический блок выявления элементамассива
// с длиной строки меньше или равно 3 элемента
int trueValuesCount = 0;
for(int i = 0; i < inputArrayCount;i++)
{
    if(firstArray[i].Length <= 3)
    {
        lastArray[trueValuesCount] = firstArray[i];
        trueValuesCount++;
    }
}
Array.Resize(ref lastArray, trueValuesCount);
// Вывод результата
Console.Write(String.Join(", ",firstArray)+" => ");
Console.Write(String.Join(", ", lastArray));