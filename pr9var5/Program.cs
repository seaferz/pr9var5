/*Дан массив 30 значений в диапазоне [-100;100] найти количество 
положительных и отрицательных*/

int[] array = new int[30];  //создаем массив
Random random = new Random();
for (int i = 0; i < array.Length; i++)  //заолняем массив случайными значениями
{
    array[i] = random.Next(-100, 101);
}

int positiveCount = array.Count( x => x > 0 );  //положительные
int negativeCount = array.Count(x => x < 0);    //отрицательные

//вывод
Console.WriteLine($"Кол-во положительных чисел: {positiveCount}");
Console.WriteLine($"Кол-во отрицательных чисел: {negativeCount}");