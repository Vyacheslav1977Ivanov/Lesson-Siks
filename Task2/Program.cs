double[] EnterNumbers() //метод ввода чисел через , 
{
    Console.Write("Введите через , b1,k1,b2,k2 ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(","); // .Split метод разделения текста (символ которым разделяют | , # и тд .)
    double[] numbers = new double[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(arrayNumbers[i]);
    }
    return numbers;
}

void LinearEquation(double [] array)
{
//x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1 
double b1 = array[0]; // 0
double k1 = array[1]; // 1 
double b2 = array[2]; // 2
double k2 = array[3]; // 3 
double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Прямые пересекаются в точке x = {x} y = {y}");
}
double[] num = EnterNumbers();
LinearEquation(num);