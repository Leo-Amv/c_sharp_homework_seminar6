namespace Homework
{
    class Task43 // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter number b1 : ");
                float b1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter number k1 : ");
                float k1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter number b2 : ");
                float b2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter number k2 : ");
                float k2 = Convert.ToSingle(Console.ReadLine());
                if (k1 == k2 && b1 != b2) Console.WriteLine("Intersection point does not exist! Lines are parallel!");
                else if (k1 == k2 && b1 == b2) Console.WriteLine("Lines match! Lines have an infinite number of points in common!");
                else
                {
                    float x = (b2 - b1) / (k1 - k2);
                    float y = k1 * x + b1;
                    Console.WriteLine($"Intersection point is : \t ({x} ; {y})");
                }
            }
            catch
            {
                Console.WriteLine("INCORRECT DATA ! Please enter the numbers ");
                Main();
            }
        }
    }
}