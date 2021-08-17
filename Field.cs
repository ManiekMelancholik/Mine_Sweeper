using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySaper
{
    public class Field
    {
        private bool  flaged;

        private int 
            x,
            y,            
            indexNumber;
        private int 
            b,
            numOfBInSquare;

        public Field (int idn, int x, int y)
        {
            
            this.b = 0;
            this.flaged = false;
            this.numOfBInSquare = 0;
            this.indexNumber = idn;
            this.x = x;
            this.y = y;

        }
        ~Field() { }
        public void SetB (int b)
        {
            
            this.b = b;

        }
        public void AddB(int b)
        {
            this.numOfBInSquare += b;
        }
        public void SetFlag(bool f)
        {
            flaged = f;
        }
        public void IncNearbyBCount(ref List<Field> f, int columns)
        {
            //if (this.x > 0 && this.x < columns - 1 && this.y > 0 && this.y < columns - 1)
            //{
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                    try
                    {
                        f[(this.x + j + ((this.y + i) * columns))].AddB(this.IsItAB());//shift 
                    }
                    catch (Exception exception)
                    {

                    }
                    finally { }

                }
                }
            //}
        }
        public string GetNumOfB()
        {

            return this.numOfBInSquare.ToString();
        }
        public int IsItAB ()
        {
            return this.b;

        }
        public int GetIndex()
        {
            return this.indexNumber;
        }
       

    }
}
