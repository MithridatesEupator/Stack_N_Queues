using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_N_Queues
{
    class Stacks 
    {

        private Object[] stackArray;
        private int stackSize;
        private int topEntry = -1;

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

        Stacks(int size)
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
                Console.WriteLine("Error: Stack is Full\n");
            }
        }

        public Object pop()
        {
            if (topEntry >= 0)
            {
                Object pop = stackArray[topEntry];
                stackArray[topEntry] = null;
                Console.WriteLine(pop + " was popped \n");
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

        static void Main()
        {
            Stacks test = new Stacks(6);
            test.push("10");
            test.push("22");
            test.push("33");
            test.push("42");
            var t = test.pop();
            Console.WriteLine(t);
            test.displayStack();
        }
    }
}
