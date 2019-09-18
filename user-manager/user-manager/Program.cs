using System;

namespace user_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show main menu");
        }
        /// <summary>
        /// Shows main menu
        /// </summary>
        /// <returns>Selected menu</returns>
        static int ShowMainMenu()
        {
            Console.Clear();

            Console.WriteLine(" Welcome to user manager");
            Console.WriteLine("1 Create a user");
            Console.WriteLine("2 Show all user");
            Console.WriteLine("3 Mail all users");
            Console.WriteLine("4 Exit");
            Console.WriteLine("Select an option: ");

            string input = Console.ReadLine();
            int selectedOption = int.Parse(input);

            return selectedOption;
        }
    }
}
