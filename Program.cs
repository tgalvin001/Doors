using System;



namespace Doors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] doors = new bool[101];

            for (int pass = 1; pass <= 101; pass++)
            {
                for (int i = 0; i < doors.Length; i++)
                {
                    if (i % pass == 0)
                    {
                        if (doors[i] == false)
                            doors[i] = true;
                        else
                            doors[i] = false;
                    }

                }
            }

            for (int i = 0; i < doors.Length; i++)
            {
                Console.WriteLine($"{i}: {doors[i]}");
            }
            Console.ReadKey();
        }
    }
}