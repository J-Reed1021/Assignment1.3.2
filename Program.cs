namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9};
            int length = numbers.Length;
            int temp = 0;
            for (int i = 0; i < (numbers.Length / 2); i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[length - i - 1];
                numbers[length - i - 1] = temp;
            }
            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }

        }

    }

}
