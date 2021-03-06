using System;
using System.Collections;

namespace StackObj
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            int num = 3;

            for(int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for(int i = 0; i < num; i++)
            {
                Person p = (Person) stack.Pop();
                Console.WriteLine(p.ToString());
            }
        }
    }
}
