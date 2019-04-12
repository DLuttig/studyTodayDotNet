using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Out of 1 to 10, How is your Quality of learing to day");
            int qualityOfStudy = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if(qualityOfStudy >= 8)
            {
                Console.WriteLine("Great work!!!");
            }
            else if(qualityOfStudy < 8 && qualityOfStudy >= 6)
            {
                Console.WriteLine("Small drops of water fulls the bucket over time");
            }
            else
            {
                Console.WriteLine("Maybe an extra hour will help");
            }
        }
    }
}
