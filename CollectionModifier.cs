using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySaper
{
    public class CollectionModifier
    {
        private static CollectionModifier instance;
        private CollectionModifier()
        {
            
        }
        
        public static ref CollectionModifier GetInstance()
        {
            if(instance==null)
            {
                instance = new CollectionModifier();
            }
            return ref instance;

        }

        // takes references to lists of squares and fields and sets Bees in correct fields acording to rng 
        public void ModifyB(ref List<Field> f, ref List<Square> sqs, ref MyRNG rng, ref List<Button> b)
        {

            int n;
            
            SqRNG sqrng;
            foreach (Square sq in sqs )
            {
                n = sq.n;
                
                sqrng = rng.NxNSqare(n);
                for (int i = 0; i < n*n; i++)
                {
                    
                    if (sqrng.squaresDecisions[i] == true)
                    {
                        f[sq.sqareIndexes[i]].SetB(1);
                        b[sq.sqareIndexes[i]].BackColor = System.Drawing.Color.FromArgb(255, 255, 0);
                    }
                }
            }
        }
        public void ChangeNumbers(ref List<Field> fields,ref List<Button> buttons, int columns)
        {
            foreach (Field f in fields)
            {
                f.IncNearbyBCount(ref fields, columns);
            }

            int i = 0;
            foreach(Button b in buttons)
            {
                b.Text = fields[i].GetNumOfB();
                if (fields[i].IsItAB() == 1)
                    b.Text = "";
                i++;
            }

        }
        // takes starting x and y to count amount of bees in the 3 by 3 square
        public int CountBInSQ(ref List<Field> f, int x, int y, int columns)
        {
            int ans = 0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ans += f[x + i + (y + j) * columns].IsItAB();//shift 
                        
                }
            }

            return ans;

        }
        


    }
}
