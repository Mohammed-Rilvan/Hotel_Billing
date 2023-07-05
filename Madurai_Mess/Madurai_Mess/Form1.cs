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
    public partial class Form1 : Form
    {
        List<string> Bill_items = new List<string>();
        public static string Item;
        public static int price;
        public static int quantity;
        public static int Total_cost ;
        public static int incre = 1;
        Form2 obj = new Form2();
       // StreamWriter writer = new StreamWriter("D:\\test\\Bill.txt", true);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            
          var product_name = (Items)int.Parse(textBox1.Text);
          label2.Text =  product_name.ToString();
          numericUpDown1.Focus();
        }
        enum Items
        {
            Idly=1,
            Dosa=2,Boori=3,Chappathi=4,Pongal=5,Idiyappam=6,Egg_dosa=7,Onion_dosa=8,
            parotta=9,kothu_parotta=10,Chilli_parotta=11,Veg_noodles=12,Chicken_noodles=13,Mushroom_Noddles=15,Chicken_fried_rice=16,Veg_fried_Rice=17
        }
        enum Price
        {
             Idly = 5,
             Dosa = 30,
            Boori = 15,
             Chappathi = 15,
             Pongal = 30,
             Idiyappam = 10,
            Egg_dosa = 45,
             Onion_dosa = 40,
             Parotta = 13,
             Kothu_Parotta = 80,
              Chilli_Parotta = 90,
              Veg_noodles = 60,
             Chicken_noodles = 80,
             Mushroom_noodles = 75,
            Chicken_fried_rice = 80,
        }
           
        private void Next__Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            while (incre < 2)
            {
                DateTime d=DateTime.Now;
                Bill_items.Add("                     INVOICE              ");
                Bill_items.Add("\nDATE : " + d.ToShortDateString() + "   " + d.ToShortTimeString());
                Bill_items.Add("\n.............................................................");
                Bill_items.Add("ITEMS               QUANTITY            PRICE               ");
                Bill_items.Add(".............................................................");
                incre++;
            }
           if (label2.Text == Price.Boori.ToString())
         {
             int temp =(int) numericUpDown1.Value * (int)Price.Boori;
          //H   
               Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
       
       
         else if (label2.Text == Price.Chappathi .ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Chappathi;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Chicken_fried_rice.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Chicken_fried_rice;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Chicken_noodles.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Chicken_noodles;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Chilli_Parotta.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Chilli_Parotta;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Chilli_Parotta.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Chilli_Parotta;
          //H
             //writer.WriteLine(setw(label2.Text, 20) + "                                    " + numericUpDown1.Value + "                                    " + temp);
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Dosa.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Dosa;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Egg_dosa.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Egg_dosa;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Idiyappam.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Idiyappam;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Kothu_Parotta.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Kothu_Parotta;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Mushroom_noodles.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Mushroom_noodles;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Onion_dosa.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Onion_dosa;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Parotta.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Parotta;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
         }
         else if (label2.Text == Price.Pongal.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Pongal;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = 
                 
                 Total_cost + temp;
             
         }
         else if (label2.Text == Price.Veg_noodles.ToString())
         {
             int temp = (int)numericUpDown1.Value * (int)Price.Veg_noodles;
          //H
             Bill_items.Add("\n"+ (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
             Total_cost = Total_cost + temp;
            }
             else if(label2.Text==Price.Idly.ToString())
             {
                 int temp = (int)numericUpDown1.Value * (int)Price.Idly;
                 Total_cost = Total_cost + temp;
                // obj.BillBox.Items.Add(label2.Text + "                                    " + numericUpDown1.Value + "                                    " + temp)
              //H
                 Bill_items.Add("\n" + (setw(label2.Text, 20) + numericUpDown1.Value + "                    " + temp));
                 Item = "idly";
                 quantity = (int)numericUpDown1.Value;
                 price = temp;
             }
           
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d=DateTime.Now;
            Bill_items.Add("\n\n\n\nTotal Cost You Pay : " + Total_cost);
            string BillNumPath = "D:\\test\\Bill Number.txt";
            int bill_Num = int.Parse(File.ReadAllText(BillNumPath));
            string input_filePAth="D:\\Test\\Bills\\"+d.ToLongDateString()+"\\"+bill_Num+".txt";
            StreamWriter writer = new StreamWriter(input_filePAth);
            foreach (string s in Bill_items)
                writer.WriteLine(s);
            writer.Close();
            bill_Num++;
            File.WriteAllText(BillNumPath,bill_Num.ToString());
           //Items.Add("Total Cost You Pay : " + Total_cost);
            //File.AppendAllText("D:\\test\\Bill.txt", "\n\n\nTotal Cost You Pay : " + Total_cost);
            button2.Enabled = false;
            obj.ShowDialog();
            
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            Directory.CreateDirectory("D:\\test\\Bills\\"+d.ToLongDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            button2.Enabled = true;
            textBox1.Clear();
            label2.Text = "(Product Name)";
            numericUpDown1.Value = 0;
            Bill_items.Clear();
            incre = 1;
            
           // obj.BillBox.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }
        public static string setw(string str, int n)
        {
            string blank = "";
            string blank2 = " ";
            for(int i=1;i<=n-str.Length;i++)
            {
                blank += blank2;
            }
            str += blank;
            return str;
        }
        


        
    }
}
