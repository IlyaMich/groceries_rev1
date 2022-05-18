
namespace groceries_rev1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_Count = new System.Windows.Forms.Label();
            this.L_Type = new System.Windows.Forms.Label();
            this.L_Fat = new System.Windows.Forms.Label();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            this.B_Type1 = new System.Windows.Forms.Button();
            this.B_1Option = new System.Windows.Forms.Button();
            this.B_5Option = new System.Windows.Forms.Button();
            this.B_3Option = new System.Windows.Forms.Button();
            this.B_TypeB = new System.Windows.Forms.Button();
            this.B_TypeC = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_500Option = new System.Windows.Forms.Button();
            this.B_1000Option = new System.Windows.Forms.Button();
            this.B_1500Option = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Count
            // 
            this.L_Count.Location = new System.Drawing.Point(12, 33);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(50, 15);
            this.L_Count.TabIndex = 0;
            this.L_Count.Text = "Count:";
            // 
            // L_Type
            // 
            this.L_Type.AutoSize = true;
            this.L_Type.Location = new System.Drawing.Point(12, 157);
            this.L_Type.Name = "L_Type";
            this.L_Type.Size = new System.Drawing.Size(34, 15);
            this.L_Type.TabIndex = 1;
            this.L_Type.Text = "Type:";
            // 
            // L_Fat
            // 
            this.L_Fat.AutoSize = true;
            this.L_Fat.Location = new System.Drawing.Point(12, 90);
            this.L_Fat.Name = "L_Fat";
            this.L_Fat.Size = new System.Drawing.Size(26, 15);
            this.L_Fat.TabIndex = 2;
            this.L_Fat.Text = "Fat:";
            // 
            // NUD_Count
            // 
            this.NUD_Count.Location = new System.Drawing.Point(77, 31);
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(120, 23);
            this.NUD_Count.TabIndex = 3;
            this.NUD_Count.ValueChanged += new System.EventHandler(this.NUD_Count_ValueChanged);
            // 
            // B_Type1
            // 
            this.B_Type1.Location = new System.Drawing.Point(59, 153);
            this.B_Type1.Name = "B_Type1";
            this.B_Type1.Size = new System.Drawing.Size(75, 23);
            this.B_Type1.TabIndex = 5;
            this.B_Type1.UseVisualStyleBackColor = true;
            this.B_Type1.Click += new System.EventHandler(this.B_Type_Click);
            // 
            // B_1Option
            // 
            this.B_1Option.Location = new System.Drawing.Point(93, 86);
            this.B_1Option.Name = "B_1Option";
            this.B_1Option.Size = new System.Drawing.Size(75, 23);
            this.B_1Option.TabIndex = 6;
            this.B_1Option.Text = "1%";
            this.B_1Option.UseVisualStyleBackColor = true;
            this.B_1Option.Visible = false;
            this.B_1Option.Click += new System.EventHandler(this.B_Fat_Click);
            // 
            // B_5Option
            // 
            this.B_5Option.Location = new System.Drawing.Point(255, 86);
            this.B_5Option.Name = "B_5Option";
            this.B_5Option.Size = new System.Drawing.Size(75, 23);
            this.B_5Option.TabIndex = 7;
            this.B_5Option.Text = "5%";
            this.B_5Option.UseVisualStyleBackColor = true;
            this.B_5Option.Visible = false;
            this.B_5Option.Click += new System.EventHandler(this.B_Fat_Click);
            // 
            // B_3Option
            // 
            this.B_3Option.Location = new System.Drawing.Point(174, 86);
            this.B_3Option.Name = "B_3Option";
            this.B_3Option.Size = new System.Drawing.Size(75, 23);
            this.B_3Option.TabIndex = 8;
            this.B_3Option.Text = "3%";
            this.B_3Option.UseVisualStyleBackColor = true;
            this.B_3Option.Visible = false;
            this.B_3Option.Click += new System.EventHandler(this.B_Fat_Click);
            // 
            // B_TypeB
            // 
            this.B_TypeB.Location = new System.Drawing.Point(140, 153);
            this.B_TypeB.Name = "B_TypeB";
            this.B_TypeB.Size = new System.Drawing.Size(75, 23);
            this.B_TypeB.TabIndex = 9;
            this.B_TypeB.UseVisualStyleBackColor = true;
            this.B_TypeB.Click += new System.EventHandler(this.B_Type_Click);
            // 
            // B_TypeC
            // 
            this.B_TypeC.Location = new System.Drawing.Point(221, 153);
            this.B_TypeC.Name = "B_TypeC";
            this.B_TypeC.Size = new System.Drawing.Size(75, 23);
            this.B_TypeC.TabIndex = 10;
            this.B_TypeC.UseVisualStyleBackColor = true;
            this.B_TypeC.Click += new System.EventHandler(this.B_Type_Click);
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(140, 226);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(75, 23);
            this.B_Add.TabIndex = 11;
            this.B_Add.Text = "Add";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_500Option
            // 
            this.B_500Option.Location = new System.Drawing.Point(93, 86);
            this.B_500Option.Name = "B_500Option";
            this.B_500Option.Size = new System.Drawing.Size(75, 23);
            this.B_500Option.TabIndex = 12;
            this.B_500Option.Text = "500g";
            this.B_500Option.UseVisualStyleBackColor = true;
            this.B_500Option.Visible = false;
            // 
            // B_1000Option
            // 
            this.B_1000Option.Location = new System.Drawing.Point(174, 86);
            this.B_1000Option.Name = "B_1000Option";
            this.B_1000Option.Size = new System.Drawing.Size(75, 23);
            this.B_1000Option.TabIndex = 13;
            this.B_1000Option.Text = "1kg";
            this.B_1000Option.UseVisualStyleBackColor = true;
            this.B_1000Option.Visible = false;
            // 
            // B_1500Option
            // 
            this.B_1500Option.Location = new System.Drawing.Point(255, 86);
            this.B_1500Option.Name = "B_1500Option";
            this.B_1500Option.Size = new System.Drawing.Size(75, 23);
            this.B_1500Option.TabIndex = 14;
            this.B_1500Option.Text = "1.5kg";
            this.B_1500Option.UseVisualStyleBackColor = true;
            this.B_1500Option.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 286);
            this.Controls.Add(this.B_1500Option);
            this.Controls.Add(this.B_1000Option);
            this.Controls.Add(this.B_500Option);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_TypeC);
            this.Controls.Add(this.B_TypeB);
            this.Controls.Add(this.B_3Option);
            this.Controls.Add(this.B_5Option);
            this.Controls.Add(this.B_1Option);
            this.Controls.Add(this.B_Type1);
            this.Controls.Add(this.NUD_Count);
            this.Controls.Add(this.L_Fat);
            this.Controls.Add(this.L_Type);
            this.Controls.Add(this.L_Count);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Count;
        private System.Windows.Forms.Label L_Type;
        private System.Windows.Forms.Label L_Fat;
        private System.Windows.Forms.NumericUpDown NUD_Count;
        private System.Windows.Forms.Button B_Type1;
        private System.Windows.Forms.Button B_1Option;
        private System.Windows.Forms.Button B_5Option;
        private System.Windows.Forms.Button B_3Option;
        private System.Windows.Forms.Button B_TypeB;
        private System.Windows.Forms.Button B_TypeC;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_500Option;
        private System.Windows.Forms.Button B_1000Option;
        private System.Windows.Forms.Button B_1500Option;
    }
}