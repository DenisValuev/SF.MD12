namespace SF.Module12.Unit1
{
    internal class Program
    {
        /// <summary>
        /// task 12.1.2
        /// </summary>
        static void Greetings()
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            string greetings = "Привет," + name;
            Console.WriteLine(greetings);
        }

        /// <summary>
        /// task 12.1.3
        /// </summary>
        static void ReadArray()
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = int.Parse(Console.ReadLine());
            string[] array = new string[count];
            for (int i = 0; i < count; i++)
                array[i] = Console.ReadLine();
            Console.WriteLine("Все элементы записаны");
        }

        /// <summary>
        /// 12.1.4
        /// </summary>
        static void CheckAge()
        {
            Console.WriteLine("Введите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age > 13)
                Console.WriteLine("Вы успешно зарегистрированы");
            else
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
