namespace Seminar6
{
    class Task41 // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    {
        public static int CountNumbers(int[] array) // Метод подсчитывает количество чисел в массиве больше 0
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) count++;
            }
            return count;
        }
        public static void ConvertArray(string[] str, int[] array) // Метод конвертирует строковый массив в int массив
        {
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = Int32.Parse(str[i]);
            }
        }
        public static void Main() // Метод требует ввести числа через пробел проверяя введеные данные и подсчитывает количество введеных чисел больше 0
        {
            try
            {
                Console.WriteLine("Enter numbers separated by a space: ");
                string? str = Console.ReadLine();
                if (str != null && str != "")
                {
                    string[] strNums = str.Split(' ');
                    int[] array = new int[strNums.Length];
                    ConvertArray(strNums, array);
                    Console.WriteLine($"Count numbers > 0:  {CountNumbers(array)}");
                }
                else Console.WriteLine("Do not enter an empty string you must enter a numbers !");
            }
            catch
            {
                Console.WriteLine("INCORRECT DATA ! Please enter the numbers ");
                Main();
            }
        }
    }
}
