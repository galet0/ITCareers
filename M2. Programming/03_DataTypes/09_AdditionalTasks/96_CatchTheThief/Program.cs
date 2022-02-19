using System;

namespace _96_CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            long max = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                switch (dataType)
                {
                    case "sbyte":
                        if(id <= sbyte.MaxValue)
                        {
                            if(id > max)
                            {
                                max = id;//6
                            }

                        }
                        break;
                    case "int":
                        if (id <= int.MaxValue)
                        {
                            if (id > max)
                            {
                                max = id;//6
                            }

                        }
                        break;
                    case "long":
                        if (id <= long.MaxValue)
                        {
                            if (id > max)
                            {
                                max = id;//6
                            }

                        }
                        break;
                }
            }

            Console.WriteLine(max);
        }
    }
}
