using System;
using System.Collections.Generic;
using System.Text;

namespace TestSort
{
    class Rag
    {
        private readonly Rng _rng;

        public int Min { get { return _rng.Min; } set { _rng.Min = value; } }
        public int Max { get { return _rng.Max; } set { _rng.Max = value; } }

        public Rag(Rng rng)
        {
            _rng = rng;
        }

        public int[] Generate(int length)
        {
            var numbers = new int[length];
            for (int i = 0; i < length; i++)
                numbers[i] = _rng.Generate();

            return numbers;
        }
    }
}
