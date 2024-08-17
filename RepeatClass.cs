namespace WMI___System_Specifications
{
    internal class RepeatClass
    {
        public static void Repeat(ref bool repeat) 
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Do you want to continue? (Y / N)");
            string repeatChoice = Console.ReadLine()!;
            switch (repeatChoice)
            {
                case "Y":
                case "y":
                    repeat = true;
                    break;
                case "N":
                case "n":
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
