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

        /// 
        /// DEBUGGGG
        /// 

        public static Image IMAGE_TEST;

        public Form1()
        {
            InitializeComponent();
            BindGrid(pLst);
            //dataGridView1.Rows.
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
                P_Dairy1.Height += 10;
                if (P_Dairy1.Size == P_Dairy1.MaximumSize)
                {
                    T_Dairy.Stop();
                    bIsDairyCollapsed = false;
                }
            }
            else
            {
                P_Dairy1.Height -= 10;
                if (P_Dairy1.Size == P_Dairy1.MinimumSize)
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
                P_Meat1.Height += 10;
                if (P_Meat1.Size == P_Meat1.MaximumSize)
                {
                    T_Meat.Stop();
                    bIsMeatCollapsed = false;
                }
            }
            else
            {
                P_Meat1.Height -= 10;
                if (P_Meat1.Size == P_Meat1.MinimumSize)
                {
                    T_Meat.Stop();
                    bIsMeatCollapsed = true;
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView _DataGridView = (DataGridView)sender;
            int nRowIndex;

            nRowIndex = _DataGridView.CurrentCell.RowIndex;

            try
            {
                pLst.RemoveAt(nRowIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pLst;
            }
            catch
            {
                MessageBox.Show("Error removing item");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_RemoveAll_Click(object sender, EventArgs e)
        {
            //DataGridView _DataGridView = (DataGridView)sender;

            try
            {
                pLst.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pLst;
            }
            catch
            {
                MessageBox.Show("Error clearing cart");
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

        #region Options Clicks
        /// CHANGE LOGIC \\\
        private void B_YogurtOption_Click(object sender, EventArgs e)
        {
            Yogurt yYogurt = new Yogurt();
            Form2 _form = new Form2(yYogurt);
            _form.ShowDialog();
            //pLst.Add(yYogurt);
            if (!ObjectHandler(yYogurt)) { MessageBox.Show("No items were added"); }
        }

        private void B_CheeseOption_Click(object sender, EventArgs e)
        {
            Cheese cCheese = new Cheese();
            Form2 _form = new Form2(cCheese);
            _form.ShowDialog();
            //pLst.Add(cCheese);
            if (!ObjectHandler(cCheese)) { MessageBox.Show("No items were added"); }
        }

        private void B_MilkOption_Click(object sender, EventArgs e)
        {
            Milk mMilk = new Milk();
            Form2 _form = new Form2(mMilk);
            _form.ShowDialog();
            //pLst.Add(mMilk);
            if (!ObjectHandler(mMilk)) { MessageBox.Show("No items were added"); }
        }

        private void B_SteakOption_Click(object sender, EventArgs e)
        {
            Steak sSteak = new Steak();
            Form2 _form = new Form2(sSteak);
            _form.ShowDialog();
            //pLst.Add(sSteak);
            if (!ObjectHandler(sSteak)) { MessageBox.Show("No items were added"); }
        }

        private void B_ChickenOption_Click(object sender, EventArgs e)
        {
            Chicken cChicken = new Chicken();
            Form2 _form = new Form2(cChicken);
            _form.ShowDialog();
            //pLst.Add(cChicken);
            if (!ObjectHandler(cChicken)) { MessageBox.Show("No items were added"); }
        }

        private void B_FishOption_Click(object sender, EventArgs e)
        {
            Fish fFish = new Fish();
            Form2 _form = new Form2(fFish);
            _form.ShowDialog();
            //pLst.Add(fFish);
            if (!ObjectHandler(fFish)) { MessageBox.Show("No items were added"); }
        }

        #endregion

        private void B_Send_Click(object sender, EventArgs e)
        {
            if (pLst.Count == 0) { MessageBox.Show("No items in cart!"); return; }

            var rRand = new Random();
            string stJsonString;
            //string stFileName = String.Format(@"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson{0}.json", rRand.Next(0, 20));
            string stFileName = @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson1.json";
            JsonSerializerOptions jso = new JsonSerializerOptions { WriteIndented = true };
            stJsonString = JsonSerializer.Serialize(pLst, jso);

            //File.Create(stFileName);
            if (File.Exists(stFileName))
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
            //string stFileName = @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson.json";\
            string stFileName = @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\testJson1.json";
            byte[] byteArray;
            List<Product> testList = new List<Product>();

            Utf8JsonReader utf8Reader;

            //try
            //{
                if(File.Exists(stFileName))
                {
                    using (StreamReader sr = File.OpenText(stFileName))
                    {
                        stJsonString = sr.ReadToEnd();
                    }
/*
                    byteArray = Encoding.ASCII.GetBytes(stJsonString);
                    utf8Reader = new Utf8JsonReader(byteArray);
                    List<Product> deList = JsonSerializer.Deserialize<List<Product>>(ref utf8Reader);*/
                    pLst = JsonSerializer.Deserialize<List<Product>>(stJsonString);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = pLst;
                }
                else
                {
                    MessageBox.Show("No file like this is avalible");
                }
            //}
            /*catch
            {
                MessageBox.Show("Error loading cart");
            }*/
        }

        private void BindGrid(List<Product> apList)
        {
            dataGridView1.AutoGenerateColumns = false;

            // Create Cells
            DataGridViewCell ButtonCell = new DataGridViewButtonCell();
            DataGridViewCell ImageCell = new DataGridViewImageCell();
            DataGridViewCell TypeCell = new DataGridViewTextBoxCell();
            DataGridViewCell CountCell = new DataGridViewTextBoxCell();
            DataGridViewCell PriceCell = new DataGridViewTextBoxCell();
            //DataGridViewCell btCell = new DataGridViewButtonCell();
            //ButtonCell.Value = ;

            // Create Columns
            DataGridViewButtonColumn colButtonColumn = new DataGridViewButtonColumn()
            {
                CellTemplate = ButtonCell,
                Name = "Remove",
                HeaderText = "",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            };

            DataGridViewImageColumn colImageColumm = new DataGridViewImageColumn()
            {
                CellTemplate = ImageCell,
                Name = "Image",
                HeaderText = "",
                DataPropertyName = "Image"
            };

            DataGridViewTextBoxColumn colTypeColumn = new DataGridViewTextBoxColumn()
            {
                CellTemplate = TypeCell,
                Name = "Type",
                HeaderText = "Product",
                DataPropertyName = "Type"
            };
            
            DataGridViewTextBoxColumn colCountColumn = new DataGridViewTextBoxColumn()
            {
                CellTemplate = CountCell,
                Name = "Count",
                HeaderText = "Amount",
                DataPropertyName = "Count"
            };
            
            DataGridViewTextBoxColumn colPriceColumn = new DataGridViewTextBoxColumn()
            {
                CellTemplate = PriceCell,
                Name = "Price",
                HeaderText = "Total",
                DataPropertyName = "Total"
            };


            /*DataGridViewTextBoxColumn cloFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Header Text",
                DataPropertyName = "Value"
            };*/

            dataGridView1.Columns.Add(colButtonColumn);
            dataGridView1.Columns.Add(colImageColumm);
            dataGridView1.Columns.Add(colTypeColumn);
            dataGridView1.Columns.Add(colCountColumn);
            dataGridView1.Columns.Add(colPriceColumn);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            //var fileNamesList = new BindingList<Product>(pLst);
            dataGridView1.DataSource = pLst;
            dataGridView1.Invalidate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["Remove"].Index) return;

            DataGridView _DataGridView = (DataGridView)sender;
            int nRowIndex;

            nRowIndex = _DataGridView.CurrentCell.RowIndex;

            try
            {
                pLst.RemoveAt(nRowIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pLst;
            }
            catch
            {
                MessageBox.Show("Error removing item");
            }
        }

        private bool BindList(/*List<Product> aProducts*/)
        {
            var fileNamesList = new BindingList<Product>(pLst);

            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = fileNamesList;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aProduct"></param>
        /// <returns></returns>
        private bool ObjectHandler(Product aProduct)
        {
            if(aProduct.Type != "")
            {
                pLst.Add(aProduct);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pLst;
                return true;
            }

            return false;
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
