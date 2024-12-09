namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string ime;
            //Console.WriteLine("Как се казваш");
            //Console.ReadLinе();
            Console.Beep(432, 500);
            for (int i = 200; i <= 4000; i += 200)
                Console.Beep(i, 100);

            Console.Write("Hello,");
            Console.WriteLine("Hristomir");
            Console.WriteLine((3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3);
        }
    }
}
