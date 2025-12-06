namespace _4dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string RandomText = "I love niggers";
            var TheAnswer = RandomText.Substring(11);
            Console.WriteLine(TheAnswer);

            //2
            string RandomText2 = "RasulbekMatrasulov";
            var TheAnswer2 = RandomText2.Substring(2, 14);
            Console.Write(TheAnswer2);
        }
    }
}
