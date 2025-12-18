namespace _10dars;

internal class Program
{
    static void Main(string[] args)
    {
        Laptop laptop2 = new Laptop();
        laptop2.Brand = "Asus";
        laptop2.Model = "ROG";
        laptop2.Processor = "AMD Ryzen 7 12400";
        laptop2.ScreenType = "OLED";
        laptop2.ManifacturedYear = 2026;


        Laptop laptop1 = new Laptop()
        {
            Brand = "Asus",
            Model = "Vivobook G015",
            Processor = "AMD Ryzen 3 7000series",
            ScreenType = "OLED",
            ManifacturedYear = 2024
        };



        Console.WriteLine(laptop1.Brand);
        Console.WriteLine(laptop2.Brand);
        Console.WriteLine(laptop1.Model);
        Console.WriteLine(laptop2.Model);
        Console.WriteLine(laptop1.Processor);
        Console.WriteLine(laptop2.Processor);
        Console.WriteLine(laptop1.ScreenType);
        Console.WriteLine(laptop2.ScreenType);
        Console.WriteLine(laptop1.ManifacturedYear);
        Console.WriteLine(laptop2.ManifacturedYear);

    }

};








//public class Solution
//{
//    public string[] UncommonFromSentences(string s1, string s2)
//    {
//        List<string> words = new List<string>();
//        words.AddRange(s1.Split(' '));
//        words.AddRange(s2.Split(' '));

//        List<string> res = new List<string>();
//        foreach (string word in words)
//        {
//            var count = words.Count(x => x == word);
//            if (count == 1)
//            {
//                res.Add(word);
//            }
//        }

//        return res.ToArray();
//    }
//}
