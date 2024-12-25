namespace MyListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
           string[]mass=new string[5] { "5","6","7","8","9"};
            list.Add(new string[9] { "1", "2", "3", "4", "10", "11", "12", "13", "14" });
            list.Add(mass);
           // list.Add(1, "5");
            list.Print();
            Console.WriteLine(list.Count);
        }


    }
}
