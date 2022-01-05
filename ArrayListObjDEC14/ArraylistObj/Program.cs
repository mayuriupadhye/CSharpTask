using System;
using System.Collections;

namespace ArraylistObj
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine(); 
        }
    }
}
