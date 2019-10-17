namespace LottoGenerator
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TotalCost = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.line3 = new System.Windows.Forms.TextBox();
            this.line6 = new System.Windows.Forms.TextBox();
            this.line5 = new System.Windows.Forms.TextBox();
            this.line4 = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.TextBox();
            this.LinesList = new System.Windows.Forms.ComboBox();
            this.HowManyLines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Lotto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost.Enabled = false;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost.Location = new System.Drawing.Point(121, 192);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(82, 15);
            this.TotalCost.TabIndex = 1;
            this.TotalCost.Text = "Ticket Cost: ";
            // 
            // line1
            // 
            this.line1.Enabled = false;
            this.line1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1.Location = new System.Drawing.Point(45, 33);
            this.line1.Name = "line1";
            this.line1.ReadOnly = true;
            this.line1.Size = new System.Drawing.Size(264, 20);
            this.line1.TabIndex = 5;
            // 
            // textBox37
            // 
            this.textBox37.Enabled = false;
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox37.Location = new System.Drawing.Point(209, 189);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(100, 20);
            this.textBox37.TabIndex = 41;
            // 
            // line3
            // 
            this.line3.Enabled = false;
            this.line3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line3.Location = new System.Drawing.Point(45, 85);
            this.line3.Name = "line3";
            this.line3.ReadOnly = true;
            this.line3.Size = new System.Drawing.Size(264, 20);
            this.line3.TabIndex = 42;
            // 
            // line6
            // 
            this.line6.Enabled = false;
            this.line6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line6.Location = new System.Drawing.Point(45, 163);
            this.line6.Name = "line6";
            this.line6.ReadOnly = true;
            this.line6.Size = new System.Drawing.Size(264, 20);
            this.line6.TabIndex = 43;
            // 
            // line5
            // 
            this.line5.Enabled = false;
            this.line5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line5.Location = new System.Drawing.Point(45, 137);
            this.line5.Name = "line5";
            this.line5.ReadOnly = true;
            this.line5.Size = new System.Drawing.Size(264, 20);
            this.line5.TabIndex = 44;
            // 
            // line4
            // 
            this.line4.Enabled = false;
            this.line4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line4.Location = new System.Drawing.Point(45, 111);
            this.line4.Name = "line4";
            this.line4.ReadOnly = true;
            this.line4.Size = new System.Drawing.Size(264, 20);
            this.line4.TabIndex = 45;
            // 
            // line2
            // 
            this.line2.Enabled = false;
            this.line2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2.Location = new System.Drawing.Point(45, 59);
            this.line2.Name = "line2";
            this.line2.ReadOnly = true;
            this.line2.Size = new System.Drawing.Size(264, 20);
            this.line2.TabIndex = 46;
            // 
            // LinesList
            // 
            this.LinesList.AllowDrop = true;
            this.LinesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LinesList.FormattingEnabled = true;
            this.LinesList.Location = new System.Drawing.Point(182, 6);
            this.LinesList.MaxDropDownItems = 6;
            this.LinesList.Name = "LinesList";
            this.LinesList.Size = new System.Drawing.Size(69, 21);
            this.LinesList.TabIndex = 47;
            this.LinesList.SelectedIndexChanged += new System.EventHandler(this.LinesList_SelectedIndexChanged);
            // 
            // HowManyLines
            // 
            this.HowManyLines.AutoSize = true;
            this.HowManyLines.Location = new System.Drawing.Point(12, 9);
            this.HowManyLines.Name = "HowManyLines";
            this.HowManyLines.Size = new System.Drawing.Size(164, 13);
            this.HowManyLines.TabIndex = 48;
            this.HowManyLines.Text = "How many Lines would you like? ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(376, 229);
            this.Controls.Add(this.HowManyLines);
            this.Controls.Add(this.LinesList);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line6);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.textBox37);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Lotto Quick Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.TextBox line1;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox line3;
        private System.Windows.Forms.TextBox line6;
        private System.Windows.Forms.TextBox line5;
        private System.Windows.Forms.TextBox line4;
        private System.Windows.Forms.TextBox line2;
        private System.Windows.Forms.ComboBox LinesList;
        private System.Windows.Forms.Label HowManyLines;
    }
}