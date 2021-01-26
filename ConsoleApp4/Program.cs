using System;

namespace TaskOfModule9
{
    class MyExeption : Exception
    {
        public override string Message
        {
            get { return "Message of MyExeption"; }
        }
    }


    class program
    {
        static void Main()
        {
            MyExeption obj0=new MyExeption();
            NullReferenceException obj1=new NullReferenceException();
            StackOverflowException obj2=new StackOverflowException();
            DivideByZeroException obj3 = new DivideByZeroException();
            FormatException obj4 = new FormatException();

            Exception[] array = new Exception[] { obj0,obj1,obj2,obj3,obj4 };

            byte x = 0;

            while (x < 5)
            {
                try
                {
                    throw array[x];
                }
                catch (Exception m)
                {
                    Console.WriteLine(m.Message);
                    x++;
                }
            }
        }
    }
}
