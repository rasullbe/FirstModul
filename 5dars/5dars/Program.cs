using System.Threading.Channels;

namespace _5dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину листа:");
            var n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for(var i = 0;  i < n; i++)
            {
                Console.Write("Введите элемент листа:");
                var num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
        }
    }
}