using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyListProject
{
    public class MyList<T>

    {

        private T[] _array;



        public int Capacity { get; set; }



        public int Count { get; set; }



        public MyList()

        {

            _array = new T[2];

            Capacity = _array.Length;

            Count = 0;

        }



        public MyList(int length)

        {

            _array = new T[length];

            Capacity = length;

            Count = 0;

        }



        public MyList(int length, T element)

        {

            _array = new T[length];

            _array[0] = element;

            Capacity = length;

            Count = 1;

        }



        public void Add(T element)

        {

            if (IsEnoughMemory()) Resize();


            _array[Count++] = element;
        }



        public void Add(T[] elements)

        {
            int AdditionalMemory = elements.Length;


            if (IsEnoughMemory(AdditionalMemory)) Resize(AdditionalMemory);


            foreach (var element in elements)
            {

                _array[Count++] = element;
            }

        }



        public void Add(int index, T element)

        {
            if (CheckIndex(index)) { Console.WriteLine("Неверный индекс"); return; }
            if (IsEnoughMemory()) Resize();


            var newArray = new T[++Count];



            for(int i = 0; i < index; i++)
            {
                newArray[i]= _array[i];
            }


            newArray[index] = element;



            for(int i =index+1;i< Count; i++)
            {
                newArray[i]= _array[i-1];
            }



            _array = newArray;
        }



        public void Add(int index, T[] elements)

        {
            if (CheckIndex(index)) { Console.WriteLine("Неверный индекс"); return; }



            int AdditionalMemory = elements.Length;
            int newArrayLength= Count+ AdditionalMemory;
            int newIndex1 = index;
            int newIndex2 = index;

            if (IsEnoughMemory(AdditionalMemory)) Resize(AdditionalMemory);



            var newArray = new T[newArrayLength];
            for(int i=0; i< index; i++)
            {
                newArray[i] = _array[i];
            }




            foreach (var element in elements)
            {
                newArray[newIndex1++]= element;
            }




            for (int i = newIndex1; i < newArrayLength; i++)
            {
                newArray[i] = _array[newIndex2++];
            }


            Count = newArrayLength;
            _array = newArray;
        }



        public T this[int index]

        {

            get

            {

                if (index >= Count || index < 0)

                {

                    throw new IndexOutOfRangeException();

                }



                return _array[index];

            }

            set

            {

                if (index >= Count || index < 0)

                {

                    throw new IndexOutOfRangeException();

                }



                _array[index] = value;

            }

        }



        private void Resize(int AdditionalMemory = 0)

        {

            int newLength = _array.Length * 2 + AdditionalMemory;

            var newArray = new T[newLength];



            Array.Copy(_array, newArray, Count);



            _array = newArray;

        }



        private void Copy(int[] sourceArray, int[] destinationArray)

        {

            if (sourceArray.Length > destinationArray.Length)

            {

                throw new ArgumentException();

            }



            for (int i = 0; i < sourceArray.Length; i++)

            {

                destinationArray[i] = sourceArray[i];

            }

        }


        private bool IsEnoughMemory(int AdditionalMemory = 0) => Count + AdditionalMemory >= Capacity;

        private bool CheckIndex(int index)=>index<0 || index > Count;
        

        


        public  void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(_array[i] + " ");
            }
        }






    }

}


