namespace PR_3
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
            panel1 = new Panel();
            TypesOfProducts = new Label();
            Types = new Label();
            panel2 = new Panel();
            TypesOfPartners = new Label();
            Types2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TypesOfProducts);
            panel1.Controls.Add(Types);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 202);
            panel1.TabIndex = 0;
            // 
            // TypesOfProducts
            // 
            TypesOfProducts.Font = new Font("Segoe UI", 14F);
            TypesOfProducts.Location = new Point(12, 38);
            TypesOfProducts.Name = "TypesOfProducts";
            TypesOfProducts.Size = new Size(776, 155);
            TypesOfProducts.TabIndex = 1;
            // 
            // Types
            // 
            Types.Font = new Font("Segoe UI", 14F);
            Types.Location = new Point(12, 9);
            Types.Name = "Types";
            Types.Size = new Size(164, 29);
            Types.TabIndex = 0;
            Types.Text = "Типы продукций:";
            // 
            // panel2
            // 
            panel2.Controls.Add(TypesOfPartners);
            panel2.Controls.Add(Types2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 1;
            // 
            // TypesOfPartners
            // 
            TypesOfPartners.Font = new Font("Segoe UI", 14F);
            TypesOfPartners.Location = new Point(12, 34);
            TypesOfPartners.Name = "TypesOfPartners";
            TypesOfPartners.Size = new Size(776, 210);
            TypesOfPartners.TabIndex = 3;
            // 
            // Types2
            // 
            Types2.Font = new Font("Segoe UI", 14F);
            Types2.Location = new Point(12, 5);
            Types2.Name = "Types2";
            Types2.Size = new Size(164, 29);
            Types2.TabIndex = 2;
            Types2.Text = "Типы продукций:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Types;
        private Label TypesOfProducts;
        private Panel panel2;
        private Label Types2;
        private Label TypesOfPartners;
    }
}
