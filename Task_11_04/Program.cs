namespace Task_11_04
{
    internal class Program
    {
        //Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
        //их среднее значение.Используйте ключевое слово params
        static void Main(string[] args)
        {
            //Пример использования
            Console.WriteLine(Average(5, 4, 2, 0, 0, 123, 0.213, 0));
        }

        /// <summary>
        /// Возвращает среднее арифметическое чисел (округляется до 3 знаков после запятой)
        /// </summary>
        /// <param name="x">Массив переданных чисел</param>
        /// <returns>double</returns>
        static double Average(params double[] x)
        {
            double sum = 0;
            foreach (var el in x) sum += el;

            return Math.Round(sum / x.Length, 3);
        }
    }
}
