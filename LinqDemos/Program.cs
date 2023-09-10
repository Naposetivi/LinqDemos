using System.Collections;

namespace LinqDemos
{

    //public class Params : IEnumerable<int>
    //{
    //    private int a, b, c;

    //    public Params(int a, int b, int c)
    //    {
    //        this.a = a;
    //        this.b = b;
    //        this.c = c;
    //    }

    //    public IEnumerator<int> GetEnumerator()
    //    {
    //        yield return a;
    //        yield return b;
    //        yield return c;
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Person
    //{
    //    private string firstName, middleName, lastName;

    //    public Person(string firstName, string middleName, string lastName)
    //    {
    //        this.firstName = firstName;
    //        this.middleName = middleName;
    //        this.lastName = lastName;
    //    }

    //    public IEnumerable<string> Names
    //    {
    //        get
    //        {
    //            yield return firstName;
    //            yield return middleName;
    //            yield return lastName;
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //var p = new Params(1, 2, 3);

            //foreach (var item in p)
            //{
            //    Console.WriteLine(item);
            //}

            //var person = new Person("Jon", "Odinson", "Smith");

            //foreach (var item in person.Names)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}



//From LINQPad


//Console.WriteLine(Enumerable.Empty<int>());

//Console.WriteLine(Enumerable.Repeat("hello", 3));

//Console.WriteLine(Enumerable.Range(1, 10));

//Console.WriteLine(Enumerable.Range('a', 'z' - 'a').Select(c => (char)c));

//Console.WriteLine(Enumerable.Range(1, 10).Select(i => new string('x', i)));