namespace MyListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add(new string[9] { "1", "2", "3", "4", "10", "11", "12", "13", "14" });
            bool IsMenuOn = true;
            while (IsMenuOn)
            {
                Print();
                MenuType menuType = (MenuType)Convert.ToInt32(Console.ReadLine());
                switch (menuType)
                {
                    case MenuType.exit:
                        IsMenuOn = false; 
                        break;
                    case MenuType.addElementByIndex:
                        list.Add(4, "5"); 
                        break;
                    case MenuType.addMass:
                        string[] mass1 = new string[5] { "5", "6", "7", "8", "9" };
                        list.Add(mass1);
                        break;
                    case MenuType.addMassByIndex:
                        string[] mass2 = new string[5] { "5", "6", "7", "8", "9" };
                        list.Add(4,mass2);
                        break;
                    case MenuType.listPrint:
                        list.Print();
                        break;
                    case MenuType.clear:
                        list = new MyList<string>();
                        list.Add(new string[9] { "1", "2", "3", "4", "10", "11", "12", "13", "14" });
                        break;


                }

            }
           
        }

        public static void Print()
        {
            Console.WriteLine("Введите число для выбора программы: ");
            Console.WriteLine("0 - для выхода \n" +
                "1 - для добавления элемента по индексу в MyList \n"  +
                "2 - для добавления массива в конец списка \n" +
                "3 - для добавления массива по индексу \n" +
                "4 - для печати списка \n" +
                "5 - для очистки списка \n");
        }

    }
}
