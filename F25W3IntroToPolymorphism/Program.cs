namespace F25W3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add(2, 3);

            //int[] arr = { 1, 2, 3 };
            ////PrintArray(arr);
            ////PrintArray(2, 3, 4, 5, 6, 6, 5, 43);

            //PrintArray(3, 3, 4, 45, 4, 3);



            BaseClass objBase = new BaseClass();
            objBase.Show();

            //DerivedClass objDerived = new DerivedClass();
            //objDerived.Show();

            objBase = new DerivedClass();
            objBase.Show();

            //DerivedClass objDerived = new BaseClass();
        }

        //static void PrintArray(int[] n)
        //{

        //}

        static void PrintArray(params int[] array)
        {

        }

        static void Add(int n1, int n2)
        {

        }

        //static int Add(int n1, int n2)
        //{
        //    return 1;
        //}

        static void Add(decimal n1, decimal n2)
        {

        }

        static void Add(int n1, int n2, int n3)
        {

        }

        static void Add(int n1, int n2, ref int n3)
        {

        }
    }
}
