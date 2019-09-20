using System;

namespace ISMMethods
{
    class Program
    {
        
            static void Main(string[] args)
            {

                try
                {
                    //Asks the user for input and then calls the HelloName method and passes on the value the method retuns
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
            //Reads the line and stores it as a string in the method, returns the value of that string
            string UserName = Console.ReadLine();

            return UserName;
        }
    }
    
}
