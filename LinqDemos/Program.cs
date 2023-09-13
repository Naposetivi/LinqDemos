using NUnit.Framework;
using System.Collections;

namespace LinqDemos
{
    [TestFixture]
    class Program
    {
        //[Test]
        //public void Test()
        //{
        //    var a = new[] { 1, 2, 3 };
        //    var b = new List<int> { 1, 2, 3 };

        //    Assert.That(a, Is.EqualTo(b));

        //    var c = new List<int> { 3, 2, 1 };
        //    Assert.That(() => a, Is.EquivalentTo(c));
        //}


        static void Main(string[] args)
        {

            // --------------- Parallels ---------------



            // --- AsParallel and ParallelQuery ---


            //const int count = 50;

            //var items = Enumerable.Range(1, count).ToArray();
            //var results = new int[count];

            //items.AsParallel().ForAll(x =>
            //{
            //    int newValue = x * x * x;
            //    Console.Write($"{newValue} ({Task.CurrentId})\t");
            //    results[x - 1] = newValue;
            //});

            //Console.WriteLine();
            //Console.WriteLine();

            //foreach(var i in results)
            //{
            //    Console.WriteLine($"{i}\t");
            //}
            //Console.WriteLine();

            //var cubes = items.AsParallel().AsOrdered().Select(x => x * x * x);

            //var arr = cubes.ToArray();
            //foreach(var i in cubes)
            //    Console.Write($"{i}\t");
            //Console.WriteLine();



            // --- Cancellation and Exception ---


            //var cts = new CancellationTokenSource();

            //var items = ParallelEnumerable.Range(1, 20);

            //var results = items.WithCancellation(cts.Token).Select(i =>
            //{
            //    double result = Math.Log10(i);

            //    //if (result > 1) throw new InvalidOperationException();

            //    Console.WriteLine($"i = {i}, tid = {Task.CurrentId}");
            //    return result;
            //});

            //try
            //{
            //    foreach (var c in results)
            //    {
            //        if(c > 1)
            //        {
            //            cts.Cancel();
            //        }
            //        Console.WriteLine($"result = {c}");
            //    }
            //}
            //catch (AggregateException ae)
            //{
            //    ae.Handle(e =>
            //    { 
            //        Console.WriteLine($"{e.GetType().Name}: {e.Message}");
            //        return true;
            //    });
            //}
            //catch (OperationCanceledException)
            //{
            //    Console.WriteLine("Canceled");
            //}



            // --- Merge Options ---


            //var numbers = Enumerable.Range(1, 20).ToArray();

            //var results = numbers
            //    .AsParallel()
            //    .WithMergeOptions(ParallelMergeOptions.FullyBuffered)
            //    .Select(x => 
            //    {
            //        var result = Math.Log10(x);
            //        Console.Write($"P {result}\t");
            //        return result;
            //    });

            //foreach ( var result in results )
            //{
            //    Console.Write($"C {result}\t");
            //}



            // --- Custom Aggregation ---


            //var sum = Enumerable.Range(1, 1000).Sum();

            //var sum = Enumerable.Range(1, 1000)
            //    .Aggregate(0, (i, acc) => i + acc);

            //var sum = ParallelEnumerable.Range(1, 1000)
            //      .Aggregate(
            //        0,
            //        (partialSum, i) => partialSum += i,
            //        (total, subtotal) => total += subtotal,
            //        i => i);

            //Console.WriteLine("Sum = " + sum);


            // -------------------------------------------



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
}