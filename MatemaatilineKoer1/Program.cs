using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MatemaatilineKoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage esimene arv:");
            string firstNumber = Console.ReadLine();
            float floatFirst = float.Parse(firstNumber);

            Console.WriteLine("Sisestage teine arv:");
            string secondNumber = Console.ReadLine();
            float floatSecond = float.Parse(secondNumber);

            string dog = Console.ReadLine();

            if (dog == "+")
            {
                Console.WriteLine(floatFirst + floatSecond);
            }
            else if (dog == "-")
            {
                Console.WriteLine(floatFirst - floatSecond);
            }
            else if (dog == "*")
            {
                Console.WriteLine(floatFirst * floatSecond);
            }
            else if (dog == "/")
            {
                Console.WriteLine(floatFirst / floatSecond);
            }


        }
    }
}
