using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            // запись в файл
            using (FileStream fstream = new FileStream(@"C:\Users\Nickita\desktop\test123.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл:");
            }


            // удаление из файла

            {
                File.WriteAllText(@"C:\Users\Nickita\desktop\test123.txt", String.Empty);
            }

            using (FileStream fstream = File.OpenRead(@"C:\Users\Nickita\desktop\test123.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла: {0}", textFromFile);
                Console.ReadLine();
            }
        }
    }
}


//
/* public class Person
{
    // Field 
    public string name;

    // Constructor that takes no arguments. 
    public Person()
    {
        name = "unknown";
    }

    // Constructor that takes one argument. 
    public Person(string nm)
    {
        name = nm;
    }

    // Method 
    public void SetName(string newName)
    {
        name = newName;
    }
}
class TestPerson
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        Person person1 = new Person();
        Console.WriteLine(person1.name);

        person1.SetName("John Smith");
        Console.WriteLine(person1.name);

        // Call the constructor that has one parameter.
        Person person2 = new Person("Sarah Jones");
        Console.WriteLine(person2.name);

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output: 
// unknown 
// John Smith 
// Sarah Jones






/*Console.WriteLine("Введите 2 точки");
string x1 = Console.ReadLine();
Console.WriteLine("A точка =" + x1);
string x2 = Console.ReadLine();
Console.WriteLine("B точка =" + x2);
string x3 = Console.ReadLine();
Console.WriteLine("C точка =" + x3);
int x11 = Convert.ToInt32(x1);
int x22 = Convert.ToInt32(x2);
int x33 = Convert.ToInt32(x3);

    int AB = Math.Abs(x22 - x11);
     int BC = Math.Abs(x33 - x22);
int Summ = Math.Abs(AB + BC);
Console.WriteLine("РасстояниеAB = {0}, РасстояниеBC = {1}, Сумма = {2}", AB,BC,Summ);
    Console.ReadLine();

    */




