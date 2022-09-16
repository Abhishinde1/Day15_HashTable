namespace Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            //hash.Add("0", "To ");
            //hash.Add("1", "be ");
            //hash.Add("2", "or ");
            //hash.Add("3", "not ");
            //hash.Add("4", "to ");
            //hash.Add("5", "be ");

            //Console.Write(hash.GetV("0"));
            //Console.Write(hash.GetV("1"));
            //Console.Write(hash.GetV("2"));
            //Console.Write(hash.GetV("3"));
            //Console.Write(hash.GetV("4"));
            //Console.Write(hash.GetV("5"));

            MyMapNode<string, string> hash = new MyMapNode<string, string>(20);
            Console.WriteLine(hash.IsEmpty());
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "they");
            hash.Add("10", "keep");
            hash.Add("11", "putting");
            hash.Add("12", "themselves");
            hash.Add("13", "deliberately");
            hash.Add("14", "into");
            hash.Add("15", "paranoid");
            hash.Add("16", "avoidable");
            hash.Add("17", "situations");
            Console.WriteLine(hash.GetV("5"));
            Console.WriteLine(hash.GetV("0"));
            Console.WriteLine($"size is: {hash.Getsize()}");


            Console.ReadKey();


        }
    }
}

