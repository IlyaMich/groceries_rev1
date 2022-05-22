using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace groceries_rev1
{
    public partial class Form2 : Form
    {
        Dairy dPreservedForm = null;
        Meat mPreservedForm = null;
        int nCount = 0;
        string stType = "";
        int nFat = 0;
        double dTotal = 0.0;
        Image imImg;


        /// 
        /// ====== DEBUG ======
        /// 

        Image TEST_IMG1 = Image.FromFile(@"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\smallCow.bmp");
        Image TEST_IMG2 = Image.FromFile(@"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\smallDog.bmp");
        Image TEST_IMG3 = Image.FromFile(@"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\smallSnake.bmp");

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Dairy objFromFirstForm) : this()
        {
            this.dPreservedForm = objFromFirstForm;
            if (!InitControls())
            {
                MessageBox.Show("Error");
                this.Close();
            }

        }
        
        public Form2(Meat objFromFirstForm) : this()
        {
            this.mPreservedForm = objFromFirstForm;
            InitControls();
        }

        private void B_Type_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            stType = bt.Text;
        }
        
        private void B_Fat_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            nFat = (int)Char.GetNumericValue(bt.Text[0]);
        }

        private void NUD_Count_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nCount = (int)nud.Value;
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            if(dPreservedForm != null && mPreservedForm == null)
            {
                dPreservedForm.Count = nCount;
                dPreservedForm.Fat = nFat;
                dPreservedForm.Type = stType;
                dPreservedForm.Total = nCount * dPreservedForm.Price;

                dPreservedForm.Images.TryGetValue(stType, out imImg);

                dPreservedForm.Image = imImg;
            }
            else if(mPreservedForm != null && dPreservedForm == null)
            {
                mPreservedForm.Count = nCount;
                mPreservedForm.Weight = nFat;
                mPreservedForm.Type = stType;
                mPreservedForm.Total = nFat * mPreservedForm.Price;

                mPreservedForm.Images.TryGetValue(stType, out imImg);

                mPreservedForm.Image = imImg;
            }

            MessageBox.Show("Updated, closing window");
            this.Close();
        }

        private bool InitControls()
        {
            if (dPreservedForm != null && mPreservedForm == null)
            {
                L_Fat.Text = "Fat:";
                B_1Option.Visible = true;
                B_3Option.Visible = true;
                B_5Option.Visible = true;

                B_Type1.Text = dPreservedForm.Types[0];
                B_TypeB.Text = dPreservedForm.Types[1];
                B_TypeC.Text = dPreservedForm.Types[2];

                return true;
            }
            else if (mPreservedForm != null && dPreservedForm == null)
            {
                L_Fat.Text = "Weight(g):";
                B_500Option.Visible = true;
                B_1000Option.Visible = true;
                B_1500Option.Visible = true;

                B_Type1.Text = mPreservedForm.Types[0];
                B_TypeB.Text = mPreservedForm.Types[1];
                B_TypeC.Text = mPreservedForm.Types[2];

                return true;
            }

            return false;
        }

        private void MatchImage()
        {

        }
    }
}
