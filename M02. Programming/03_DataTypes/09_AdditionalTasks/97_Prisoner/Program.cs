using System;

namespace _97_Prisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            long thiefID = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                switch (dataType)
                {
                    case "sbyte":
                        if (id <= sbyte.MaxValue)
                        {
                            if (id > thiefID)
                            {
                                thiefID = id;//6
                            }

                        }
                        break;
                    case "int":
                        if (id <= int.MaxValue)
                        {
                            if (id > thiefID)
                            {
                                thiefID = id;//6
                            }

                        }
                        break;
                    case "long":
                        if (id <= long.MaxValue)
                        {
                            if (id > thiefID)
                            {
                                thiefID = id;//6
                            }

                        }
                        break;
                }
            }

            Console.WriteLine(thiefID);

            decimal years;
            decimal sbyteMin = sbyte.MinValue;
            decimal sbyteMax = sbyte.MaxValue;
            if (thiefID > 0)
            {
                years = thiefID / sbyteMax;
            }
            else
            {
                years = thiefID / sbyteMin;
            }

            if(years > 1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Ceiling(years)} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Ceiling(years)} year");
            }
        }
    }
}
