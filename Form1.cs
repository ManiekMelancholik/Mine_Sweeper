using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyInitializer();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void MyInitializer()
        {
            b_List = new List<Button>();
            fields_List = new List<Field>();
            objectsFactory = Factory.GetInstance();
            randGenerator = MyRNG.GetInstance();
            indexOfThisElement = this.Controls.Count;
            sq_List = new List<Square>();
            cm = CollectionModifier.GetInstance();
        }

        List<Button> b_List; 
        List<Field> fields_List;
        List<Square> sq_List;
        Factory objectsFactory;
        MyRNG randGenerator;
        CollectionModifier cm;
        int x = 0,
            y = 0,
            n = 3,
            rows = 0,
            columns = 0,
            sH = 20,
            sW = 20,
            ammountOfFields = 0,
            indexOfThisElement = 0;

      

        private void b_Reset_Click(object sender, EventArgs e)
        {
            
            fields_List.Clear();
            foreach(Button b in b_List)
                this.Controls.RemoveAt(this.Controls.Count - 1);//usuwa ostatni element

            b_List.Clear();
            GenerateButton.Enabled = true;
            sq_List.Clear();
        }

        private void b_HMinus_Click(object sender, EventArgs e)
        {
            if (rows != 0)
            {
                rows -= 3;
                label_H.Text = rows.ToString();

            }
        }

        private void b_HPlus_Click(object sender, EventArgs e)
        {
            if (rows != 99)
            {
                rows += 3;
                label_H.Text = rows.ToString();
                
            }
            
        }

        private void b_WPlus_Click(object sender, EventArgs e)
        {
            if (columns != 99)
            {
                columns += 3;
                label_W.Text = columns.ToString();

            }
            
        }

        private void b_WMinus_Click(object sender, EventArgs e)
        {
            if (columns != 0)
            {
                columns -= 3;
                label_W.Text = columns.ToString();

            }
            
        }

        private void updateHashes_Click(object sender, EventArgs e)//błędna nazwqa
        {
            foreach (Field f in fields_List)
            {
                f.IncNearbyBCount(ref fields_List, columns);
                //try
                //{
                //    listBox1.Items.Add(this.cm.CountBInSQ(ref fields_List, f.x-1, f.y-1, columns));
                //}
                //catch(Exception exeption)
                //{

                //}
            }
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {


           
            objectsFactory.CreateButtons(ref b_List, rows, columns, sH, sW);
            objectsFactory.CreateFields(ref fields_List, rows, columns, indexOfThisElement);
            objectsFactory.CreateSquares(ref sq_List, n, columns, rows);
            cm.ModifyB(ref this.fields_List, ref this.sq_List, ref this.randGenerator, ref this.b_List);
            cm.ChangeNumbers(ref fields_List, ref b_List, columns);
            foreach (Button b in b_List)
            {
                b.MouseUp += Check;
                this.Controls.Add(b);
                

            }
            GenerateButton.Enabled = false;
          
        }
        
        private void Check(object sender, MouseEventArgs e)
        {
            
            Button b = sender as Button;
            
            if (e.Button == MouseButtons.Left)
                b.Text = "B";
            else if (e.Button == MouseButtons.Right)
            {
                if (b.Text != "B") 
                    b.Text = "F";
            }
            else
            {
                if (b.Text == "F")
                    b.Text = "";                
            }
        }
    }
}
