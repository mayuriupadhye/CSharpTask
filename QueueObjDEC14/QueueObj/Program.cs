using System;
using System.Collections;

namespace QueueObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            int num = 3;

            for(int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                queue.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for(int i = 0; i < num; i++)
            {
                Person p = (Person) queue.Dequeue();
                Console.WriteLine(p.ToString());
            }
        }
    }
}
