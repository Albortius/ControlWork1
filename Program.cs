// Блок ввода исходных данных
Console.Write("Введите количество элементов массива: ");
int inputArrayCount = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[inputArrayCount];
for(int i = 0; i < inputArrayCount; i++)
{
    if(inputArrayCount  > 0)
    {
        Console.Write($"Значение {i+1}-го элемента массива: ");
        firstArray[i] = Console.ReadLine();
    }
}
// Блок логики
// Вывод результата
