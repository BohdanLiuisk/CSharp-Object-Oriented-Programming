using System;

namespace ArrayOfDelegates
{
    class Program
    {
        delegate int MyDelegate();
        delegate double ArrayDelegate(MyDelegate[] a);

        static int GetRandom()
        {
            return new Random().Next(100);
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }

            ArrayDelegate arrDelegate = (MyDelegate[] c) =>
            {
                double sr = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sr += c[i].Invoke();
                }
                return sr / array.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " ");
            }

            Console.WriteLine("\nAverage value of elements {0:##.###}", arrDelegate(array));
        }
    }
}
