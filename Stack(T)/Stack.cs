using System;
using System.Collections.Generic; //needed for "Stack<T>"
using System.Linq;

class Stack
{
    static void Main(string[] args)
    {
        //I. Defining and using Stack<T>
        Stack<string> namesInStack = new Stack<string>();  
        //push elements (вмъкване на елемнти)
        namesInStack.Push("1. Todor");
        namesInStack.Push("2. Ivan");
        namesInStack.Push("3. Slav");
        namesInStack.Push("4. Niki");
        namesInStack.Push("5. Ivo");

        Console.WriteLine("The last name (at TOP position) is = {0}", namesInStack.Peek());  //JUST see last element

        Console.WriteLine("\nPerson Names..");
        while (namesInStack.Count > 0)
        {
            Console.WriteLine(namesInStack.Pop());  //Pop(TAKE and REMOVE) the LAST element from stack
        }
        
    }
}

//NOTE: Stack<T> has NO indexer!
//.Push() -> Push element to LAST position.
//.Pop()  -> Pop(TAKE and REMOVE) the LAST element from stack<T>.
//.Peek() -> JUST SEE last element from stack<T>, NOT pop(take) them.
//.Count()-> See the counter/length of stack<T>.
