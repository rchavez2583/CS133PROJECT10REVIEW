using System;

namespace CS133PROJECT10
{
    class Program
    {
        public delegate string  MyDelegatePointer(int a, int b);

         static void Main()
        {
            MyClass myClass = new MyClass();

            Func<int, int, string> pointer;
            pointer = myClass.MyFirstMethod;


            Action<int, int> pointer2;
            pointer2 = myClass.MySecondMethod;

            Action<int, int> pointer3;
            pointer3 = myClass.MyThirdMethod;

            Console.WriteLine(pointer(34, 21));
            pointer2(21, 11);
            pointer3(32, 10);
                


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            

        }
    }
}
public class MyClass
{
    public string MyFirstMethod(int a, int b)
    {
        return a.ToString() + b.ToString();
    }

    public void MySecondMethod(int a, int b)
    {
        Console.WriteLine(a * b * b);
    }

    public void MyThirdMethod(int a, int b)
    {
        Console.WriteLine(a + b * b / a);
    }
}
