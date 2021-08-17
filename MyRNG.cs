using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySaper
{
	public class MyRNG
	{
		private
			int
			seed,
			fib1, fib2,
			lastRNG;
		private
			SqRNG squaresValues;
			

		
		private 
			static MyRNG instance;
		private List<bool> y;

		private MyRNG()
        {
			fib1 = 1;
			fib2 = 2;
			y = new List<bool>();
			squaresValues = new SqRNG();
			squaresValues.squaresDecisions = new List<bool>();
		}
		public static ref MyRNG GetInstance()
        {
			if (instance == null)
			{
				instance = new MyRNG();
				
			}
			
			return ref instance;

        }
        public int RNG (int mod)
        {
			
			fib1 += fib2;
			fib2 += fib1;
			seed = instance.Seed();
			lastRNG = ((seed + fib1 + (fib2 * 100)) % mod);
			if (lastRNG < 0)
				lastRNG = lastRNG * (-1);

			return lastRNG;

		}
        public ref SqRNG NxNSqare(int n)
        {
			this.squaresValues.squaresDecisions.Clear();
			//squaresValues.squaresDecisions = new List<bool>();
			int nonBAmount = 0,
				j = 0,
				alg = 0;
			List<int> ints = new List<int>();
			
			this.squaresValues.n = n;
			alg = instance.RNG(n * n);
			if (alg % n == 0)
				alg++;
			if (n % alg == 0)
				alg++;
			this.squaresValues.squareAmountOfB = instance.RNG(n *n);
			this.squaresValues.alg = alg;
			
			
			nonBAmount = (n *n) - this.squaresValues.squareAmountOfB;
			//nie czy ale które
			//tablica "indexów"
			for (int i = 0; i < n * n; i++) 
            {
				ints.Add(i);

            }

            for (int i = nonBAmount; i > 1; i--)
            {
                ints.RemoveAt(ints.Count()-i);
            }

            for (int i = 0; i < n * n; i++) 
            {
				if (i == ints[j])
				{
					squaresValues.squaresDecisions.Add(true);
					j++;
				}
				else
					squaresValues.squaresDecisions.Add(false);

            }
            if (alg > 1)
                instance.AplyAlg();

            return ref squaresValues;
        }
		private void AplyAlg()
        {

			int ind = 0,
				nSq = this.squaresValues.n * this.squaresValues.n;
            for (int i = 0; i < nSq; i++)
            {
                ind += this.squaresValues.alg;
                if (ind > (nSq - 1))
                {
                    ind -= nSq;
                }
                y.Add(this.squaresValues.squaresDecisions[ind]);
            }
			this.squaresValues.squaresDecisions = new List<bool>(y);
			y.Clear();
        }

		private unsafe int Seed()
        {
			int ptr = new int();
			return (int)&ptr;
        }


    }
}
