namespace MyListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            int[]mass=new int[5] { 5,6,7,8,9};
            list.Add(new int[9] { 1, 2, 3, 4, 10, 11, 12, 13, 14 });
            list.Add(4,mass);
            //list.Add(9, 5);
            list.Print();
        }


    }
}
