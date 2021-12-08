using System;
using System.Reflection;

namespace ConsoleApp23
{
    public class SomeClass
    {
        public string Text { get; set; }

        public void PrintText(string text2)
        {
            Console.WriteLine(text2 + " " + Text);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var sc = new SomeClass();
            sc.Text = "Testowy text";
            sc.PrintText("normal");

            //Blad
            //sc = "Test";

            //var type = sc.GetType();
            //var type = typeof(SomeClass);

            dynamic sc2 = new SomeClass();
            sc2.Text = "Dynamic text";
            sc2.PrintText("dynamic");
            Console.WriteLine(sc2.GetType());
            sc2 = "Test";
            Console.WriteLine(sc2.GetType());
            sc2 = 3.2;
            Console.WriteLine(sc2.GetType());

            object sc3 = new SomeClass();
            ((SomeClass)sc3).Text = "Object text";
            ((SomeClass)sc3).PrintText("object");
            Console.WriteLine(sc3.GetType());
            sc3 = "Test";
            Console.WriteLine(sc3.GetType());
            sc3 = 3.2;
            Console.WriteLine(sc3.GetType());
            Console.ReadLine();
        }


           //var sc = new SomeClass();
           // sc.Text = "Testowy text";
           // sc.PrintText("normal");

           // //var type = sc.GetType();
           // //var type = typeof(SomeClass);

       

           // PropertyInfo propInfo = type.GetProperty("Text");
           // propInfo.SetValue(obj, "Text2");

           // MethodInfo methodInfo = type.GetMethod("PrintText");
           // methodInfo.Invoke(obj, new[] { "reflection" });
    }
}
