using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySaper
{
    public struct SqRNG
    {
        public int
            n,            
            squareAmountOfB,
            alg;
        public List<bool> squaresDecisions;
    }
    public struct Square
    {
        public int
            n,
            horizontalLocation,
            werticalLocation;

        public List<int> sqareIndexes;
    }
}
