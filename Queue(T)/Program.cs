using System;
using System.Collections.Generic; //needed for Queue<T>
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //I. Defining and using Queue<T>
        Queue<string> message = new Queue<string>();
        //Enqueue/push elements (вмъкване на елемнти)
        message.Enqueue("Message One");
        message.Enqueue("Message Two");
        message.Enqueue("Message Three");
        message.Enqueue("Message Four");

        while (message.Count > 0)
        {
            Console.WriteLine(message.Dequeue()); //Dequeue(TAKE and REMOVE) the FIRST element from Queue<T>
        }

    }
}

//NOTE: Queue<T> has NO indexer!
//.Enqueue() -> Enqueue/push element to LAST position.
//.Dequeue() -> Dequeue(TAKE and REMOVE) the FIRST element from Queue<T>
//.Peek()    -> JUST SEE first element from queue<T>, NOT dequeue(take) them.
//.Count()   -> See the counter/length of Queue<T>.