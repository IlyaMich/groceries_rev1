using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace groceries_rev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<BaseTest> lst = new List<BaseTest>();

        #region utility_variables
        private bool bIsDairyCollapsed = true;
        private bool bIsMeatCollapsed = true;
        List<Product> pLst = new List<Product>();        


        #endregion
        /*int x = 0;
        int y = 0;
        int z = 0;

        string jsonString;*/


        private void B_Dairy_Click(object sender, EventArgs e)
        {
            // Dropdown
            T_Dairy.Start();
            
        }
        
        private void B_Meat_Click(object sender, EventArgs e)
        {
            // Dropdown
            T_Meat.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Dairy_Tick(object sender, EventArgs e)
        {
            if (bIsDairyCollapsed)
            {
                P_Dairy.Height += 10;
                if (P_Dairy.Size == P_Dairy.MaximumSize)
                {
                    T_Dairy.Stop();
                    bIsDairyCollapsed = false;
                }
            }
            else
            {
                P_Dairy.Height -= 10;
                if (P_Dairy.Size == P_Dairy.MinimumSize)
                {
                    T_Dairy.Stop();
                    bIsDairyCollapsed = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Meat_Tick(object sender, EventArgs e)
        {
            if (bIsMeatCollapsed)
            {
                P_Meat.Height += 10;
                if (P_Meat.Size == P_Meat.MaximumSize)
                {
                    T_Meat.Stop();
                    bIsMeatCollapsed = false;
                }
            }
            else
            {
                P_Meat.Height -= 10;
                if (P_Meat.Size == P_Meat.MinimumSize)
                {
                    T_Meat.Stop();
                    bIsMeatCollapsed = true;
                }
            }
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < 3; i++)
            {
                TestClassA newTest1 = new TestClassA(x++, y++, z++);
                TestClassB newTest2 = new TestClassB(x++, y++);
                lst.Add(newTest1);
                lst.Add(newTest2);
            }

            dataGridView1.DataSource = lst;*/
        }

        /// CHANGE LOGIC \\\
        private void B_YogurtOption_Click(object sender, EventArgs e)
        {
            Yogurt yYogurt = new Yogurt();
            Form2 _form = new Form2(yYogurt);
            _form.ShowDialog();
            ObjectHandler(yYogurt);
        }

        private void B_CheeseOption_Click(object sender, EventArgs e)
        {
            Cheese cCheese = new Cheese();
            Form2 _form = new Form2(cCheese);
            _form.ShowDialog();
            ObjectHandler(cCheese);
        }

        private void B_MilkOption_Click(object sender, EventArgs e)
        {
            Milk mMilk = new Milk();
            Form2 _form = new Form2(mMilk);
            _form.ShowDialog();
            ObjectHandler(mMilk);
        }

        private void B_SteakOption_Click(object sender, EventArgs e)
        {
            Steak sSteak = new Steak();
            Form2 _form = new Form2(sSteak);
            _form.ShowDialog();
            ObjectHandler(sSteak);
        }

        private void B_ChickenOption_Click(object sender, EventArgs e)
        {
            Chicken cChicken = new Chicken();
            Form2 _form = new Form2(cChicken);
            _form.ShowDialog();
            ObjectHandler(cChicken);
        }

        private void B_FishOption_Click(object sender, EventArgs e)
        {
            Fish fFish = new Fish();
            Form2 _form = new Form2(fFish);
            _form.ShowDialog();
            ObjectHandler(fFish);
        }

        private bool ObjectHandler(Product aProduct)
        {
            pLst.Add(aProduct);
            dataGridView1.DataSource = pLst;
           
            return false;
        }

        private void B_Send_Click(object sender, EventArgs e)
        {
            string stJsonString;
            string stFileName = @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson.json";
            JsonSerializerOptions jso = new JsonSerializerOptions { WriteIndented = true };
            stJsonString = JsonSerializer.Serialize(pLst, jso);
            SendEmail.Visible = true;
            email.Visible = true;
            if(!File.Exists(stFileName))
            {
                using (StreamWriter sw = File.CreateText(stFileName))
                {
                    sw.Write(stJsonString);
                }
            }
        }

        private void B_Restore_Click(object sender, EventArgs e)
        {
            string stJsonString = "";
            string stFileName = @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson.json";

            if(File.Exists(stFileName))
            {
                using (StreamReader sr = File.OpenText(stFileName))
                {
                    stJsonString = sr.ReadToEnd();
                }
            }
            pLst = new List<Product>(JsonSerializer.Deserialize<List<Product>>(stJsonString));
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
        /*private void button1_Click(object sender, EventArgs e)
        {
            TestClassA newTest1 = new TestClassA(x++, y++, z++);
            TestClassB newTest2 = new TestClassB(x++, y++);
            z++;

            lst.Add(newTest1);
            lst.Add(newTest2);

            if(dataGridView1.RowCount == 6)
            {
                JsonSerializerOptions jso = new JsonSerializerOptions { WriteIndented = true };
                jsonString = JsonSerializer.Serialize(lst, jso);

                MessageBox.Show(jsonString);

                List<BaseTest> testLst = new List<BaseTest>(JsonSerializer.Deserialize<List<BaseTest>>(jsonString));

                string stFileName = @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson.json";
                //File.WriteAllText(stFileName, jsonString);

                if(!File.Exists(stFileName))
                {
                    using (StreamWriter sw = File.CreateText(stFileName))
                    {
                        sw.Write(jsonString);
                    }
                }
            }
        }*/
}
