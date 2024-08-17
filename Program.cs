namespace WMI___System_Specifications
{
    internal class Program
    {
        private static void Main()
        {
            bool repeat = true;

            Console.WriteLine("System Specifications");
            Console.WriteLine("______________________");
            do
            {
                Console.Write("Enter your query: (Ex: SELECT * FROM Win32_Processor) ");
                string query = Console.ReadLine()!;
                Console.WriteLine("Press 1 to get all properties");
                Console.WriteLine("Press 2 to get a specific property");
                Console.WriteLine("Press 3 to exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "1":
                        GetAllPropertiesClass.GetProperties(query);
                        break;
                    case "2":
                        Console.Write("Enter the property name: (EX: Name) ");
                        string propertyName = Console.ReadLine()!;
                        GetPropertyValueClass.GetPropertyValue(query, propertyName);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                RepeatClass.Repeat(ref repeat);
            } while (repeat != false);
        }
    }
}