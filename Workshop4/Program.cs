// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

// Если мы захотим сами задать число из данного диапазона, нужно вести:
// System.Console.Write("Введите число:   ");
// string writeNum = Console.ReadLine();
// int number = Convert.ToInt32(writeNum);

// Создаем объект Random для генерации случайных чисел
Random random = new Random();

// Генерируем случайное число в диапазоне от 1 до 100000
int randomNumber = random.Next(1, 100001);

// Выводим сгенерированное число на экран
Console.WriteLine($"Сгенерированное случайное число: {randomNumber}");
int result = randomNumber;

// Вычисляем количество цифр в числе

int count = 0;
while (result > 0)
{
    result = result / 10;
    count++;
}

System.Console.WriteLine($"Число {randomNumber} состоит из {count} цифр");
System.Console.WriteLine();

// Создание массива из цифр числа
int[] digitsArray = new int[count];

// Заполняем массив цифрами c измененными индексами из числа
int index = 0;
while (randomNumber > 0)
{
digitsArray[index] = randomNumber % 10;
randomNumber = randomNumber / 10;
index++;
}

// Вывод массива с измененными индексами
Console.WriteLine("Массив цифр c измененными индексами числа:");
foreach (int digit in digitsArray)
{
Console.Write(digit + " ");
}

Console.WriteLine();


