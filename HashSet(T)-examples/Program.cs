using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_T__examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumbCollection = new List<int> { 11, 33, 55, 666, 666 };
            var secondNumbCollection = new List<int> { 22, 44, 666, 88 , 666};

            var hashCollection = new HashSet<int>();

            firstNumbCollection.ForEach(x => hashCollection.Add(x));
            Console.WriteLine(string.Join(" ", hashCollection));

            secondNumbCollection.ForEach(x => hashCollection.Add(x));  //**
            //hashCollection.UnionWith(secondNumbCollection);  //** 
            Console.WriteLine(string.Join(" ", hashCollection));

            hashCollection.Add(666);
            hashCollection.Add(666);

            Console.WriteLine("\nHashSet add ONLY unique elements!"
                             + "\n" + string.Join(" ", hashCollection));
        }
    }
}

//** With UnionWith() method we can add all elements from collection at once. When use Add() we need to use lambda expression at once, because this method add element one by one.