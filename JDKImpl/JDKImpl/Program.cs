using System;

namespace JDKImpl
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IList<string> list = new ArrayList<string>();

            list.Add("hi");
            list.Add("Super");
            list.Add("Cool");
            list.Add("Test");

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get("hi"));
        }
    }
}
