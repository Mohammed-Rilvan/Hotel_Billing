using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madurai_Mess
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime d=DateTime.Now;
            textBox1.Text="ITEMS               QUANTITY            PRICE               ";
            int prevoius_bill_num = int.Parse(File.ReadAllText("D:\\test\\Bill Number.txt"));
            prevoius_bill_num -= 1;
            string[] Bill = File.ReadAllLines("D:\\test\\Bills\\" + d.ToLongDateString() + "\\" + prevoius_bill_num + ".txt");
             
            for(int i=7;i<Bill.Length;i++)
            {
                BillBox.Items.Add(Bill[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
