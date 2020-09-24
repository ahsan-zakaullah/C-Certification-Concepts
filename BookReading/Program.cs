using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Collections.Concurrent;
using System.IO;

namespace BookReading
{
    static class Program
    //{
    //    public static void ThreadMethod(object o)
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("ThreadProc: {0}", i);
    //            Thread.Sleep(0);
    //        }
    //}
    //    public static void Main()
    //    {
    //        bool stopped = false;
    //       Thread t = new Thread(new ThreadStart(() =>
    //   {
    //       while (!stopped)
    //       {
    //           Console.WriteLine("Running...");
    //           Thread.Sleep(1000);
    //       }
    //   }));
    //        t.Start();
    //        Console.WriteLine("Press any key to exit");
    //        Console.ReadKey();
    //        stopped = true;
    //        t.Join();
    //    }
    //}

    {

        //  Using ThreadStatic


        //[ThreadStatic]
        //public static int _field;
        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread A: {0}", _field);
        //        }
        //    }).Start();
        //    new Thread(() =>
        //{

        //    for (int x = 0; x < 10; x++)
        //    {
        //        _field++;
        //        Console.WriteLine("Thread B: {0}", _field);
        //    }
        //}).Start();
        //    Console.ReadKey();
        //}


        // Using ThreadLocal<T>
        //public static ThreadLocal<int> _field =
        //new ThreadLocal<int>(() =>
        //{
        //    return Thread.CurrentThread.ManagedThreadId;
        //});
        //        public static void Main()
        //        {
        //            new Thread(() =>
        //            {
        //            for (int x = 0; x < _field.Value; x++)
        //            {
        //                Console.WriteLine("Thread A: {0}", x);
        //        }
        //    }).Start();
        //    new Thread(() =>
        //{
        //for (int x = 0; x<_field.Value; x++)
        //{
        //Console.WriteLine("Thread B: {0}", x);
        //}
        //}).Start();
        //Console.ReadKey();
        //    }   
        //   }

        // Thread pools

        public static void Main()
        {
            //ThreadPool.QueueUserWorkItem((s) =>
            //{
            //    Console.WriteLine("Working on a thread from threadpool");
            //});
            //Console.ReadLine();

            //LISTING 1-8 Starting a new Task
            //Task t = Task.Run(() =>
            //{
            //    for (int x = 0; x < 100; x++)
            //    {
            //        Console.Write("*");
            //    }
            //});
            //t.Wait();

            //  LISTING 1 - 9 Using a Task that returns a value.
            //  Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //});
            //Console.WriteLine(t.Result); // Displays 42

            // LISTING 1 - 10 Adding a continuation
            //Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //}).ContinueWith((i) =>
            //{
            //    return i.Result * 2;
            //});
            //Console.WriteLine(t.Result); // Displays 84


            //   LISTING 1 - 11 Scheduling different continuation tasks
            //Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //});
            //t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Canceled");
            //}, TaskContinuationOptions.OnlyOnCanceled);
            //t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Faulted");
            //}, TaskContinuationOptions.OnlyOnFaulted);
            //var completedTask = t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Completed");
            //}, TaskContinuationOptions.OnlyOnRanToCompletion);
            //completedTask.Wait();



            //   LISTING 1-12 Attaching child tasks to a parent task
            //    Task<Int32[]> parent = Task.Run(() =>
            //    {
            //        var results = new Int32[3];
            //        new Task(() => results[0] = 0,
            //        TaskCreationOptions.AttachedToParent).Start();
            //        new Task(() => results[1] = 1,
            //        TaskCreationOptions.AttachedToParent).Start();
            //        new Task(() => results[2] = 2,
            //        TaskCreationOptions.AttachedToParent).Start();
            //        return results;
            //    });
            //    var finalTask = parent.ContinueWith(
            //    parentTask => {
            //        foreach (int i in parentTask.Result)
            //            Console.WriteLine(i);
            //    });

            //finalTask.Wait();

            //LISTING 1-13 Using a TaskFactory

            //Task<Int32[]> parent = Task.Run(() =>
            //{
            //    var results = new Int32[3];
            //    TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
            //    TaskContinuationOptions.ExecuteSynchronously);
            //    tf.StartNew(() => results[0] = 0);
            //    tf.StartNew(() => results[1] = 1);
            //    tf.StartNew(() => results[2] = 2);
            //    return results;
            //});
            //var finalTask = parent.ContinueWith(
            //parentTask => {
            //    foreach (int i in parentTask.Result)
            //        Console.WriteLine(i);
            //});
            //finalTask.Wait();

            //LISTING 1-14 Using Task.WaitAll
            //Task[] tasks = new Task[3];
            //tasks[0] = Task.Run(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("1");
            //    return 1;
            //});
            //tasks[1] = Task.Run(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("2");
            //    return 2;
            //});
            //tasks[2] = Task.Run(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("3");
            //    return 3;
            //}
            //);
            //Task.WaitAll(tasks);

            //   LISTING 1 - 15 Using Task.WaitAny
            //Task<int>[] tasks = new Task<int>[3];
            //tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            //tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            //tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
            //while (tasks.Length > 0)
            //{
            //    int i = Task.WaitAny(tasks);
            //    Task<int> completedTask = tasks[i];
            //    Console.WriteLine(completedTask.Result);
            //    var temp = tasks.ToList();
            //    temp.RemoveAt(i);
            //    tasks = temp.ToArray();

            //LISTING 1 - 16 Using Parallel.For and Parallel.Foreach

            //Parallel.For(0, 10, i =>
            //{
            //    Thread.Sleep(1000);
            //});
            //var numbers = Enumerable.Range(0, 10);
            //Parallel.ForEach(numbers, i =>
            //{
            //    Thread.Sleep(1000);
            //});


            //LISTING 1-18 async and await

            //string result = DownloadContent().Result;
            //Console.WriteLine(result);
            //ScaleVsResponsive sr = new ScaleVsResponsive();
            //sr.SleepAsyncA(1000);
            //sr.SleepAsyncB(1000);
            // LISTING 1 - 22 Using AsParallel
            //var numbers = Enumerable.Range(0, 100000000);
            //var parallelResult = numbers.AsParallel()
            //.Where(i => i % 2 == 0)
            //.ToArray();
            //Console.WriteLine(parallelResult[0]);
            // LISTING 1 - 23 Unordered parallel query
            //  var numbers = Enumerable.Range(0, 10);
            //var parallelResult = numbers.AsParallel()
            //.Where(i => i % 2 == 0)
            //.ToArray();
            //foreach (int i in parallelResult)
            //    Console.WriteLine(i);
            //LISTING 1 - 24 Ordered parallel query
            //  var numbers = Enumerable.Range(0, 10);
            //var parallelResult = numbers.AsParallel().AsOrdered()
            //.Where(i => i % 2 == 0)
            //.ToArray();
            //foreach (int i in parallelResult)
            //    Console.WriteLine(i);

            //LISTING 1-25 Making a parallel query sequential
            //var numbers = Enumerable.Range(0, 20);
            //var parallelResult = numbers.AsParallel().AsOrdered()
            //.Where(i => i % 2 == 0).AsSequential();
            //foreach (int i in parallelResult.Take(5))
            //    Console.WriteLine(i);

            //LISTING 1-26 Using ForAll
            //var numbers = Enumerable.Range(0, 20);
            //var parallelResult = numbers.AsParallel()
            //.Where(i => i % 2 == 0);
            //parallelResult.ForAll(e => Console.WriteLine(e));

            //LISTING 1 - 27 Catching AggregateException

            //var numbers = Enumerable.Range(0, 20);
            //try
            //{
            //    var parallelResult = numbers.AsParallel()
            //    .Where(i => IsEven(i));
            //    parallelResult.ForAll(e => Console.WriteLine(e));
            //}
            //catch (AggregateException e)
            //{
            //    Console.WriteLine("There where {0} exceptions",
            //    e.InnerExceptions.Count);
            //}


            //LISTING 1-28 Using BlockingCollection<T>
            //BlockingCollection<string> col = new BlockingCollection<string>();
            //Task read = Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(col.Take());
            //    }
            //});
            //Task write = Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        string s = Console.ReadLine();
            //        if (string.IsNullOrWhiteSpace(s)) break;
            //        col.Add(s);
            //    }
            //});
            //write.Wait();


            //LISTING 1-29 Using GetConsumingEnumerable on a BlockingCollection
            //BlockingCollection<string> col = new BlockingCollection<string>();
            //Task read = Task.Run(() =>
            //{
            //    foreach (string v in col.GetConsumingEnumerable())
            //        Console.WriteLine(v);
            //});
            //Task write = Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        string s = Console.ReadLine();
            //        if (string.IsNullOrWhiteSpace(s)) break;
            //        col.Add(s);
            //    }
            //});
            //write.Wait();

            //     LISTING 1 - 30 Using a ConcurrentBag
            //ConcurrentBag<int> bag = new ConcurrentBag<int>();
            //bag.Add(42);
            //bag.Add(21);
            //int result;
            //if (bag.TryTake(out result))
            //    Console.WriteLine(result);
            //if (bag.TryPeek(out result))
            //    Console.WriteLine("There is a next item: {0}", result);


            //LISTING 1 - 31 Enumerating a ConcurrentBag
            //ConcurrentBag<int> bag = new ConcurrentBag<int>();
            //Task.Run(() =>
            //{
            //    bag.Add(42);
            //    Thread.Sleep(1000);
            //    bag.Add(21);
            //});
            //Task.Run(() =>
            //{
            //    foreach (int i in bag)
            //        Console.WriteLine(i);
            //}).Wait();


            //    LISTING 1 - 32 Using a ConcurrentStack
            //ConcurrentStack<int> stack = new ConcurrentStack<int>();
            //stack.Push(42);
            //int result;
            //if (stack.TryPop(out result))
            //    Console.WriteLine("Popped: {0}", result);
            //stack.PushRange(new int[] { 1, 2, 3 });
            //int[] values = new int[2];
            //stack.TryPopRange(values);
            //foreach (int i in values)
            //    Console.WriteLine(i);

            //LISTING 1 - 33 Using a ConcurrentQueue.
            //ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            //queue.Enqueue(42);
            //int result;
            //if (queue.TryDequeue(out result))
            //    Console.WriteLine("Dequeued: {0}", result);


            //LISTING 1-35 Accessing shared data in a multithreaded application

            //int n = 0;
            //var up = Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //        n++;
            //});
            //for (int i = 0; i < 1000000; i++)
            //    n--;
            //up.Wait();
            //Console.WriteLine(n);

            //LISTING 1-36 Using the lock keyword
            //int n = 0;
            //object _lock = new object () ; 
            //var up = Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //        lock (_lock) ;
            //        n++;
            //});
            //for (int i = 0; i < 1000000; i++)
            //    lock (_lock) ;
            //n--;
            //up.Wait();
            //Console.WriteLine(n);


            ////LISTING 1 - 37 Creating a deadlock
            //object lockA = new object();
            //object lockB = new object();
            //var up = Task.Run(() =>
            //{
            //    lock (lockA)
            //    {
            //        Thread.Sleep(1000);
            //        lock (lockB)
            //        {
            //            Console.WriteLine("Locked A and B");
            //        }
            //    }
            //});
            //lock (lockB)
            //{
            //    lock (lockA)
            //    {
            //        Console.WriteLine("Locked A and B");
            //    }
            //}
            //up.Wait();


            //LISTING 1 - 38 Generated code from a lock statement
            //object gate = new object();
            //bool __lockTaken = false;
            //try
            //{
            //    Monitor.Enter(gate, ref __lockTaken);
            //}
            //finally
            //{
            //    if (__lockTaken)
            //        Monitor.Exit(gate);
            //}


            //LISTING 1 - 39 A potential problem with multithreaded code
            //Thread1();
            //Thread2();

            //LISTING 1 - 40 Using the Interlocked class
            //int n = 0;
            //var up = Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //        Interlocked.Increment(ref n);
            //});
            //for (int i = 0; i < 1000000; i++)
            //    Interlocked.Decrement(ref n);
            //up.Wait();
            //Console.WriteLine(n);


            //LISTING 1 - 41 Compare and exchange as a nonatomic operation
            //Task t1 = Task.Run(() =>
            //{
            //    if (value == 1)
            //    {
            //        // Removing the following line will change the output
            //       // Thread.Sleep(1000);
            //        value = 2;
            //    }
            //});
            //Task t2 = Task.Run(() =>
            //{
            //    value = 3;
            //});
            //Task.WaitAll(t1, t2);
            //Console.WriteLine(value); // Displays 2


            //LISTING 1 - 42 Using a CancellationToken
            //CancellationTokenSource cancellationTokenSource =
            //new CancellationTokenSource();
            //CancellationToken token = cancellationTokenSource.Token;
            //Task task = Task.Run(() =>
            //{
            //    while (!token.IsCancellationRequested)
            //    {
            //        Console.Write("*");
            //        Thread.Sleep(1000);
            //    }
            //}, token);
            //Console.WriteLine("Press enter to stop the task");
            //Console.ReadLine();
            //cancellationTokenSource.Cancel();
            //Console.WriteLine("Press enter to end the application");
            //Console.ReadLine();


            //LISTING 1 - 43 Throwing OperationCanceledException
            //CancellationTokenSource cancellationTokenSource =
            //new CancellationTokenSource();
            //CancellationToken token = cancellationTokenSource.Token;
            //Task task = Task.Run(() =>
            //{
            //    while (!token.IsCancellationRequested)
            //    {
            //        Console.Write("*");
            //        Thread.Sleep(1000);
            //    }
            //    token.ThrowIfCancellationRequested();
            //}, token);
            //try
            //{
            //    Console.WriteLine("Press enter to stop the task");
            //    Console.ReadLine();
            //    cancellationTokenSource.Cancel();
            //    task.Wait();
            //}
            //catch (AggregateException e)
            //{
            //    Console.WriteLine(e.InnerExceptions[0].Message);
            //}
            //Console.WriteLine("Press enter to end the application");
            //Console.ReadLine();


            //LISTING 1 - 44 Adding a continuation for canceled tasks
            //CancellationTokenSource cancellationTokenSource =
            //new CancellationTokenSource();
            //CancellationToken token = cancellationTokenSource.Token;
            //Task task = Task.Run(() =>
            //{
            //    while (!token.IsCancellationRequested)
            //    {
            //        Console.Write("*");
            //        Thread.Sleep(1000);
            //    }
            //}, token).ContinueWith((t) =>
            //{
            //    t.Exception.Handle((e) => true);
            //    Console.WriteLine("You have canceled the task");
            //}, TaskContinuationOptions.OnlyOnCanceled);




            //LISTING 1 - 45 Setting a timeout on a task
        //Task longRunning = Task.Run(() =>
        //    {
        //Thread.Sleep(10000);
        //    });
        //    int index = Task.WaitAny(new[] { longRunning }, 1000);
        //    if (index == -1)
        //        Console.WriteLine("Task timed out");



        //    LISTING 1 - 48 Short - circuiting the OR operator
            bool x = true;
            bool result = x || GetY();



            //LISTING 1 - 56 Using multiple if/else statements
            //bool b = false;
            //bool c = true;
            //if (b)
            //{
            //    Console.WriteLine("b is true");
            //}
            //else if (c)
            //{
            //    Console.WriteLine("c is true");
            //}
            //else
            //{
            //    Console.WriteLine("b and c are false");
            //}


            //LISTING 1-75 Using a delegate
            //delegatesUsage du = new delegatesUsage();
            //du.UseDelegate();

            //LISTING 1 - 76 A multicast delegate
            //multicastdelegates md = new multicastdelegates();
            //md.Multicast();


            ////  LISTING 1-77 Covariance with delegates
            //CovarianceDelegates c = new CovarianceDelegates();
            //c.convariance();


            //LISTING 1 - 79 Lambda expression to create a delegate
            //Calculate calc = (z, y) => z + y;
            //Console.WriteLine(calc(3, 4)); // Displays 7
            //calc = (z, y) => z * y;
            //Console.WriteLine(calc(3, 4)); // Displays 12


            // 1-82 Events
            //Pub p = new Pub();
            //p.CreateAndRaise();
            //p.Raise();


            //LISTING 1 - 88 Parsing an invalid number
            //string s = "NaN";
            //int i = int.Parse(s);


            //LISTING 1-89 Catching a FormatException
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(s)) break;
                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{ 0} is not a valid number.Please try again", s);
                    }
}
            }

        //LISTING 1-87 Manually raising events with exception handling
public class PubEventExceptionHandle
        {
            public event EventHandler OnChange = delegate { };
            public void Raise()
            {
                var exceptions = new List<Exception>();
                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }
                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
            public void CreateAndRaise()
            {
                PubEventExceptionHandle p = new PubEventExceptionHandle();
                p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");
                p.OnChange += (sender, e)
                => { throw new Exception(); };
                p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");
                try
                {
                    p.Raise();
                }
                catch (AggregateException ex)
                {
                    Console.WriteLine(ex.InnerExceptions.Count);
                }
            }
        }
        




        //LISTING 1-86 Exception when raising an event
        public class PubEventException
        {
            public event EventHandler OnChange = delegate { };
            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
            public void CreateAndRaise()
            {
                PubEventException p = new PubEventException();
                p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");
                p.OnChange += (sender, e)
                => { throw new Exception(); };
                p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");
                p.Raise();
            }
        }
    




        //LISTING 1-84 Custom event arguments
        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
        }
        public class PubEventArg
        {
            public event EventHandler<MyArgs> OnChange = delegate { };
            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
            public void CreateAndRaise()
            {
                PubEventArg p = new PubEventArg();
                p.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
                p.Raise();
            }
        }
       


        //LISTING 1-83 Using the event keyword
        public class PubEvent
        {
            public event Action OnChange = delegate { };
            public void Raise()
            {
                OnChange();
            }
        }

        //LISTING 1-82 Using an Action to expose an event
        public class Pub
        {
            public Action OnChange { get; set; }
            public void Raise()
            {
                if (OnChange != null)
                {
                    OnChange();
                }
            }
            public void CreateAndRaise()
            {
                Pub p = new Pub();
                p.OnChange += () => Console.WriteLine("Event raised to method 1");
                p.OnChange += () => Console.WriteLine("Event raised to method 2");
                p.Raise();
            }
        }
       
        public class CovarianceDelegates
        {
          //  LISTING 1-77 Covariance with delegates
                public delegate TextWriter CovarianceDel();
            public StreamWriter MethodStream() { return null; }
            public StringWriter MethodString() { return null; }
            public void convariance()
            {
                CovarianceDel del;
                del = MethodStream;
                del = MethodString;
            }
        }

        public class multicastdelegates {
            public void MethodOne()
            {
                Console.WriteLine("MethodOne");
            }
            public void MethodTwo()
            {
                Console.WriteLine("MethodTwo");
            }
            public delegate void Del();
            public void Multicast()
            {
                Del d = MethodOne;
                d += MethodTwo;
                d();
            }
        }

        //LISTING 1-75 Using a delegate
        public delegate int Calculate(int x, int y);

        public class delegatesUsage
        {
            public int Add(int x, int y) { return x + y; }
            public int Multiply(int x, int y) { return x * y; }
            public void UseDelegate()
            {
                Calculate calc = Add;
                Console.WriteLine(calc(3, 4)); // Displays 7
                calc = Multiply;
                Console.WriteLine(calc(3, 4)); // Displays 12
            }
        }
        static int value = 1;
        private static int _flag = 0;
        private static int _value = 0;
    public static bool GetY()
    {
        Console.WriteLine("This method doesn’t get called");
        return true;
    }
    public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }
        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }
        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0; }
        }
        //public static async Task<string> DownloadContent()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        try
        //        {
        //            string result = await client.GetStringAsync("http://www.microsoft.com");
        //            return result;
        //        }
        //        catch (Exception e)
        //        {

        //            throw e;
        //        }

        //    }
        //}

    }

    public class ScaleVsResponsive
    {
        public Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }
        public Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }
    }
