using System;

namespace TestSort
{
    internal class Rng
    {
        private readonly Random _random;
        private int? last;

        public int Min { get; set; }
        public int Max { get; set; }

        public Rng(int min, int max)
        {
            _random = new Random();

            Min = min;
            Max = max;
        }

        public int Generate()
        {
            int current;
            do
            {
                current = _random.Next(Min, Max);
            }
            while (last.HasValue && current == last.Value);

            last = current;

            return current;
        }
    }
}