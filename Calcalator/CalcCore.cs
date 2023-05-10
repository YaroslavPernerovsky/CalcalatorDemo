using System;
namespace Calcalator
{
	public class CalcCore
	{
		public CalcCore()
		{
		}

		public int Add(int x, int y)
		{
			return x + y;
		}

        public double Divide(int x, int y)
        {
			return x / y;
        }

        public int Multiply(int x, int y)
        {
			return x * y;
        }

        public int Multiply2(int x, int y)
        {
            return x * y * 2;
        }
    }
}

