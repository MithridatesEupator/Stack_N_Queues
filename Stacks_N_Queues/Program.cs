using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_N_Queues
{
    public class Stacks
    {

        public class Arrays
        {
            static public void fill(Object[] ArrayVar, Object entryVar)
            {
                for (int i = 0; i < ArrayVar.Length; i++)
                {
                    ArrayVar[i] = entryVar;
                }
            }
        }

        private Object[] stackArray;
        private int stackSize;
        private int topEntry = -1;

        public Stacks(int size)
        {
            this.stackSize = size;
            stackArray = new String[size];

        }

        public void push(Object input)
        {
            if (topEntry + 1 < stackSize)
            {
                topEntry++;
                stackArray[topEntry] = input;
                Console.Write(input + " was added to the Stack\n");
            }
            else
            {
                Console.WriteLine("Error: Stack is full\n");
            }
        }

        public Object pop()
        {
            if (topEntry >= 0)
            {
                Object pop = stackArray[topEntry];
                Console.WriteLine(pop + " was popped \n");
                stackArray[topEntry] = null;
                topEntry--;
                return pop;
            }
            else
            {
                return null;
            }
        }

        public void displayStack()
        {
            Console.WriteLine("\n--------[DISPLAY STACK]--------");
            foreach (object item in stackArray)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("-------------------------------");
        }   
    }

    public class Queue
    {

        Object[] queueArray;
        int queueSize = -1;

        public Queue(int size)
        {
            queueArray = new Object[size];
        }

        public void insert(Object entry)
        {
            if (queueSize < queueArray.Length)
            {
                Console.WriteLine(entry + " was inserted \n");
                queueSize++;
                queueArray[queueSize] = entry;
            }
            else
            {
                Console.WriteLine("Error: Queue is full \n");
            }
        }

        public void delete()
        {
            if (queueSize != -1)
            {
                Object[] tempArray = (Object[])queueArray.Clone();
                Console.WriteLine(queueArray[queueSize] + " was deleted \n");
                queueArray[queueSize] = null;
                
                for(int i = queueSize; i != 0; i--)
                {
                    queueArray[i - 1] = tempArray[i];
                }
            }
            else
            {
                Console.WriteLine("Error: Queue is empty \n");
            }
        }

        public void displayQueue()
        {
            Console.WriteLine("\n-------[DISPLAY QUEUE]-------");
            foreach (object item in queueArray)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("-----------------------------");
        }

        
    }
    class FinalClass
    {
    
        public static void Main()
        {
            Queue queueExample = new Queue(6);
            queueExample.insert("10");
            queueExample.insert("22");
            queueExample.insert("33");
            queueExample.insert("42");
            queueExample.delete();
            queueExample.displayQueue();
            //===========================================
            Stacks stackExample = new Stacks(6);
            stackExample.push("10");
            stackExample.push("22");
            stackExample.push("33");
            stackExample.push("42");
            var t = stackExample.pop();
            Console.WriteLine(t);
            stackExample.displayStack();
        }
    }
}
