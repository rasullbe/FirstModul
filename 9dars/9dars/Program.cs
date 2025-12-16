namespace _9dars;

internal class Program
{
    //static void Main(string[] args)
    //{
    //    List<int> numbers = new List<int>() {1, 3, 7, 4};
    //    Console.WriteLine(sum(numbers));
    //}

    //static int sum(List<int> ints)
    //{
    //    var res = 0;
    //    foreach (int i in ints)
    //    {
    //        res = res + i;
    //    }
    //    return res;
    //}



    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "hello", "$hello"};
        Console.WriteLine(Checker(list));
    }

    static int Checker(List<string> text)
    {
        var count = 0;
        foreach (var item in text)
        {
            if (item[0] == '$')
            {
                count++;
            }
        }
        return count;
    }
}