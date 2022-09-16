namespace Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To ");
            hash.Add("1", "be ");
            hash.Add("2", "or ");
            hash.Add("3", "not ");
            hash.Add("4", "to ");
            hash.Add("5", "be ");

            Console.Write(hash.GetV("0"));
            Console.Write(hash.GetV("1"));
            Console.Write(hash.GetV("2"));
            Console.Write(hash.GetV("3"));
            Console.Write(hash.GetV("4"));
            Console.Write(hash.GetV("5"));
            Console.ReadKey();


        }
    }
}

