using System;

namespace ISMMethods
{
    class Program
    {
        
            static void Main(string[] args)
            {

                try
                {
                    Console.WriteLine("Please input your name");
                    string Name = HelloName();

                Console.WriteLine("Hello " + Name + "!");

                }

                catch
                {
                    Console.WriteLine("There was an error with this code");
                }
            }

        public static string HelloName()
        {
            string UserName = Console.ReadLine();

            return UserName;
        }
    }
    
}
