namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            switch(age)
            {
                case 18:
                    Console.WriteLine("please wait an year");
                    break;

                    case 19:
                    Console.WriteLine("you are 19");
                    break;

                    case 20:
                    Console.WriteLine("you are 20");
                    break;

                    Default:
                    Console.WriteLine("Enjoy!");
                    break;

                    Console.ReadLine();

            } 

        }
    }
}