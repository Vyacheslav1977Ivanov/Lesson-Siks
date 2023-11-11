double[] EnterNumbers() //метод ввода чисел через , 
{
    Console.Write("Введите числа через , ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(","); // .Split метод разделения текста (символ которым разделяют | , # и тд .)
    double[] numbers = new double[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(arrayNumbers[i]);
    }
    return numbers;
}

void NegativeNumbers(double[] array)
{
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
         result++;
        }
    }
    Console.Write($"Кол-во отрицательных чисел = {result}");
}

double[] arr = EnterNumbers();
NegativeNumbers(arr);