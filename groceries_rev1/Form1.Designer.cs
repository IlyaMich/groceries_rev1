
namespace groceries_rev1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FLP_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.P_Dairy = new System.Windows.Forms.Panel();
            this.B_YogurtOption = new System.Windows.Forms.Button();
            this.B_CheeseOption = new System.Windows.Forms.Button();
            this.B_MilkOption = new System.Windows.Forms.Button();
            this.B_Dairy = new System.Windows.Forms.Button();
            this.P_Meat = new System.Windows.Forms.Panel();
            this.B_FishOption = new System.Windows.Forms.Button();
            this.B_SteakOption = new System.Windows.Forms.Button();
            this.B_ChickenOption = new System.Windows.Forms.Button();
            this.B_Meat = new System.Windows.Forms.Button();
            this.B_Remove = new System.Windows.Forms.Button();
            this.T_Dairy = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.T_Meat = new System.Windows.Forms.Timer(this.components);
            this.B_Send = new System.Windows.Forms.Button();
            this.B_Restore = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.SendEmail = new System.Windows.Forms.Button();
            this.FLP_Menu.SuspendLayout();
            this.P_Dairy.SuspendLayout();
            this.P_Meat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FLP_Menu
            // 
            this.FLP_Menu.Controls.Add(this.P_Dairy);
            this.FLP_Menu.Controls.Add(this.P_Meat);
            this.FLP_Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.FLP_Menu.Location = new System.Drawing.Point(416, 0);
            this.FLP_Menu.Name = "FLP_Menu";
            this.FLP_Menu.Size = new System.Drawing.Size(384, 450);
            this.FLP_Menu.TabIndex = 0;
            // 
            // P_Dairy
            // 
            this.P_Dairy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_Dairy.Controls.Add(this.B_YogurtOption);
            this.P_Dairy.Controls.Add(this.B_CheeseOption);
            this.P_Dairy.Controls.Add(this.B_MilkOption);
            this.P_Dairy.Controls.Add(this.B_Dairy);
            this.P_Dairy.Location = new System.Drawing.Point(3, 3);
            this.P_Dairy.MaximumSize = new System.Drawing.Size(378, 129);
            this.P_Dairy.MinimumSize = new System.Drawing.Size(378, 47);
            this.P_Dairy.Name = "P_Dairy";
            this.P_Dairy.Size = new System.Drawing.Size(378, 129);
            this.P_Dairy.TabIndex = 3;
            // 
            // B_YogurtOption
            // 
            this.B_YogurtOption.Location = new System.Drawing.Point(201, 99);
            this.B_YogurtOption.Name = "B_YogurtOption";
            this.B_YogurtOption.Size = new System.Drawing.Size(174, 23);
            this.B_YogurtOption.TabIndex = 6;
            this.B_YogurtOption.Text = "Yogurt";
            this.B_YogurtOption.UseVisualStyleBackColor = true;
            this.B_YogurtOption.Click += new System.EventHandler(this.B_YogurtOption_Click);
            // 
            // B_CheeseOption
            // 
            this.B_CheeseOption.Location = new System.Drawing.Point(201, 74);
            this.B_CheeseOption.Name = "B_CheeseOption";
            this.B_CheeseOption.Size = new System.Drawing.Size(174, 23);
            this.B_CheeseOption.TabIndex = 5;
            this.B_CheeseOption.Text = "Cheese";
            this.B_CheeseOption.UseVisualStyleBackColor = true;
            this.B_CheeseOption.Click += new System.EventHandler(this.B_CheeseOption_Click);
            // 
            // B_MilkOption
            // 
            this.B_MilkOption.Location = new System.Drawing.Point(201, 48);
            this.B_MilkOption.Name = "B_MilkOption";
            this.B_MilkOption.Size = new System.Drawing.Size(174, 23);
            this.B_MilkOption.TabIndex = 4;
            this.B_MilkOption.Text = "Milk";
            this.B_MilkOption.UseVisualStyleBackColor = true;
            this.B_MilkOption.Click += new System.EventHandler(this.B_MilkOption_Click);
            // 
            // B_Dairy
            // 
            this.B_Dairy.Location = new System.Drawing.Point(201, 3);
            this.B_Dairy.Name = "B_Dairy";
            this.B_Dairy.Size = new System.Drawing.Size(174, 39);
            this.B_Dairy.TabIndex = 2;
            this.B_Dairy.Text = "Dairy";
            this.B_Dairy.UseVisualStyleBackColor = true;
            this.B_Dairy.Click += new System.EventHandler(this.B_Dairy_Click);
            // 
            // P_Meat
            // 
            this.P_Meat.Controls.Add(this.B_FishOption);
            this.P_Meat.Controls.Add(this.B_SteakOption);
            this.P_Meat.Controls.Add(this.B_ChickenOption);
            this.P_Meat.Controls.Add(this.B_Meat);
            this.P_Meat.Location = new System.Drawing.Point(3, 138);
            this.P_Meat.MaximumSize = new System.Drawing.Size(378, 129);
            this.P_Meat.MinimumSize = new System.Drawing.Size(378, 47);
            this.P_Meat.Name = "P_Meat";
            this.P_Meat.Size = new System.Drawing.Size(378, 129);
            this.P_Meat.TabIndex = 7;
            // 
            // B_FishOption
            // 
            this.B_FishOption.Location = new System.Drawing.Point(201, 99);
            this.B_FishOption.Name = "B_FishOption";
            this.B_FishOption.Size = new System.Drawing.Size(174, 23);
            this.B_FishOption.TabIndex = 6;
            this.B_FishOption.Text = "Fish";
            this.B_FishOption.UseVisualStyleBackColor = true;
            this.B_FishOption.Click += new System.EventHandler(this.B_FishOption_Click);
            // 
            // B_SteakOption
            // 
            this.B_SteakOption.Location = new System.Drawing.Point(201, 74);
            this.B_SteakOption.Name = "B_SteakOption";
            this.B_SteakOption.Size = new System.Drawing.Size(174, 23);
            this.B_SteakOption.TabIndex = 5;
            this.B_SteakOption.Text = "Steak";
            this.B_SteakOption.UseVisualStyleBackColor = true;
            this.B_SteakOption.Click += new System.EventHandler(this.B_SteakOption_Click);
            // 
            // B_ChickenOption
            // 
            this.B_ChickenOption.Location = new System.Drawing.Point(201, 48);
            this.B_ChickenOption.Name = "B_ChickenOption";
            this.B_ChickenOption.Size = new System.Drawing.Size(174, 23);
            this.B_ChickenOption.TabIndex = 4;
            this.B_ChickenOption.Text = "Chicken";
            this.B_ChickenOption.UseVisualStyleBackColor = true;
            this.B_ChickenOption.Click += new System.EventHandler(this.B_ChickenOption_Click);
            // 
            // B_Meat
            // 
            this.B_Meat.Location = new System.Drawing.Point(201, 3);
            this.B_Meat.Name = "B_Meat";
            this.B_Meat.Size = new System.Drawing.Size(174, 39);
            this.B_Meat.TabIndex = 2;
            this.B_Meat.Text = "Meat";
            this.B_Meat.UseVisualStyleBackColor = true;
            this.B_Meat.Click += new System.EventHandler(this.B_Meat_Click);
            // 
            // B_Remove
            // 
            this.B_Remove.Location = new System.Drawing.Point(134, 413);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(75, 23);
            this.B_Remove.TabIndex = 2;
            this.B_Remove.Text = "Clear Cart";
            this.B_Remove.UseVisualStyleBackColor = true;
            this.B_Remove.Click += new System.EventHandler(this.B_RemoveAll_Click);
            // 
            // T_Dairy
            // 
            this.T_Dairy.Interval = 15;
            this.T_Dairy.Tick += new System.EventHandler(this.T_Dairy_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(415, 367);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // T_Meat
            // 
            this.T_Meat.Interval = 15;
            this.T_Meat.Tick += new System.EventHandler(this.T_Meat_Tick);
            // 
            // B_Send
            // 
            this.B_Send.Location = new System.Drawing.Point(338, 385);
            this.B_Send.Name = "B_Send";
            this.B_Send.Size = new System.Drawing.Size(75, 23);
            this.B_Send.TabIndex = 4;
            this.B_Send.Text = "Send";
            this.B_Send.UseVisualStyleBackColor = true;
            this.B_Send.Click += new System.EventHandler(this.B_Send_Click);
            // 
            // B_Restore
            // 
            this.B_Restore.Location = new System.Drawing.Point(12, 413);
            this.B_Restore.Name = "B_Restore";
            this.B_Restore.Size = new System.Drawing.Size(75, 23);
            this.B_Restore.TabIndex = 5;
            this.B_Restore.Text = "Restore";
            this.B_Restore.UseVisualStyleBackColor = true;
            this.B_Restore.Click += new System.EventHandler(this.B_Restore_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(229, 414);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 23);
            this.email.TabIndex = 6;
            this.email.Visible = false;
            // 
            // SendEmail
            // 
            this.SendEmail.Location = new System.Drawing.Point(335, 413);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(75, 23);
            this.SendEmail.TabIndex = 7;
            this.SendEmail.Text = "Send Mail";
            this.SendEmail.UseVisualStyleBackColor = true;
            this.SendEmail.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.B_Restore);
            this.Controls.Add(this.B_Send);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.B_Remove);
            this.Controls.Add(this.FLP_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FLP_Menu.ResumeLayout(false);
            this.P_Dairy.ResumeLayout(false);
            this.P_Meat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_Menu;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Panel P_Dairy;
        private System.Windows.Forms.Button B_YogurtOption;
        private System.Windows.Forms.Button B_CheeseOption;
        private System.Windows.Forms.Button B_MilkOption;
        private System.Windows.Forms.Button B_Dairy;
        private System.Windows.Forms.Panel P_Meat;
        private System.Windows.Forms.Button B_FishOption;
        private System.Windows.Forms.Button B_SteakOption;
        private System.Windows.Forms.Button B_ChickenOption;
        private System.Windows.Forms.Button B_Meat;
        private System.Windows.Forms.Timer T_Dairy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer T_Meat;
        private System.Windows.Forms.Button B_Send;
        private System.Windows.Forms.Button B_Restore;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button SendEmail;
    }
}

