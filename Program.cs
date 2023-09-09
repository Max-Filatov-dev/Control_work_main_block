internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nЗадача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.\n");

        string[] example = { "Hello", "TV", "World", "Max" };

        int GetLenNewArray(string[] arr)
        {
            int len = 0;
            foreach (var item in arr)
                if (item.Length <= 3) len++;

            return len;
        }

        string[] NewArray(string[] arr, int len)
        {
            string[] newArray = new string[len];
            int index = 0;
            foreach (var item in arr)
                if (item.Length <= 3)
                {
                    newArray[index] = item;
                    index++;
                }

            return newArray;
        }

        void PrintArray(string[] arr, string text)
        {
            Console.WriteLine($"{text}");
            foreach (var item in arr)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }

        int respLen = GetLenNewArray(arr: example);
        string[] respNew = NewArray(arr: example, len: respLen);
        PrintArray(arr: example, text: "Исходный массив:");
        Console.WriteLine();
        PrintArray(arr: respNew, text: "Новый массив:");
    }
}