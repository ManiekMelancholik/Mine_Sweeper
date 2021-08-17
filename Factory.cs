using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySaper
{
    public class Factory
    {
        private static Factory instance;
        //private List<Field> fields;




        private Factory()
        {

        }
        public static ref Factory GetInstance()
        {
            if (instance == null)
            {
                instance = new Factory();

            }
            return ref instance;

        }
        private Square sq;
        
        //funkcja twoży "matrycę/tabelę"elementów rows X columns
        public void CreateFields(ref List<Field> fields, int rows, int columns,int lastIndex)
        {
            
            for(int i=0; i<rows;i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    lastIndex++;
                    var f = new Field(lastIndex, j, i);
                    fields.Add(f);
                }
            }
            

        }
        public void CreateButtons(ref List<Button> buttons, int rows, int columns, int sH, int sW)
        {
            int x = 0,
                y = 0,
                ammountOfFields = rows * columns;

            System.Drawing.Size buttonSize = new System.Drawing.Size(sW, sH);

            for (int i = 0; i < ammountOfFields; i++)
            {
                Button button = new Button();
                buttons.Add(button);                
                button.Location = new System.Drawing.Point(x, y);
                button.Size = buttonSize;
                
                x += sW;
                if (x >= columns * sW)
                {
                    x = 0;
                    y += sH;
                }

            }

        }
        public void CreateSquares(ref List<Square> squares, int n, int columns, int rows)
        {
            int 
                shift,
                ammountOfFields = rows * columns,
                numOfSquares = ammountOfFields / (n ^ 2);

            for (int y = 0; y < rows / n; y++)
            {
                for (int x = 0; x < columns / n; x++)
                {
                    shift = ((n*y *columns) + (n * x));
                    squares.Add(this.CreateSquare(x, y, n, shift, columns));
                }
            }

        }
        private ref Square CreateSquare(int x, int y, int n, int shift, int columns)
        {
            sq.n=n;            
            sq.werticalLocation=y;
            sq.horizontalLocation=x;
            sq.sqareIndexes = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sq.sqareIndexes.Add(j + (i * columns) + shift);

                }

            }
            

            return ref sq;
        }
        
    }
}
