
namespace Product_Bill_Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Next = new System.Windows.Forms.Button();
            this.ID_Generated = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RC_RBN = new System.Windows.Forms.RadioButton();
            this.RC_RBY = new System.Windows.Forms.RadioButton();
            this.IsStudent = new System.Windows.Forms.CheckBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.SMan_ID = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PName = new System.Windows.Forms.ComboBox();
            this.PType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pprice = new System.Windows.Forms.TextBox();
            this.PCode = new System.Windows.Forms.TextBox();
            this.PName_Text = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Fprice = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.C_Input = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.S_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAmount = new System.Windows.Forms.Label();
            this.GST = new System.Windows.Forms.Label();
            this.TAmount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(28, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price of the Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(28, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(276, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sales Man ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(28, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Discount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(21, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(21, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Final Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Next);
            this.groupBox1.Controls.Add(this.ID_Generated);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.RC_RBN);
            this.groupBox1.Controls.Add(this.RC_RBY);
            this.groupBox1.Controls.Add(this.IsStudent);
            this.groupBox1.Controls.Add(this.CName);
            this.groupBox1.Controls.Add(this.SMan_ID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 201);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer and Retailer Details";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Next.Location = new System.Drawing.Point(196, 47);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(74, 25);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ID_Generated
            // 
            this.ID_Generated.AutoSize = true;
            this.ID_Generated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Generated.ForeColor = System.Drawing.Color.Azure;
            this.ID_Generated.Location = new System.Drawing.Point(152, 48);
            this.ID_Generated.Name = "ID_Generated";
            this.ID_Generated.Size = new System.Drawing.Size(46, 21);
            this.ID_Generated.TabIndex = 17;
            this.ID_Generated.Text = "2482";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(28, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Regular Customer:";
            // 
            // RC_RBN
            // 
            this.RC_RBN.AutoSize = true;
            this.RC_RBN.Checked = true;
            this.RC_RBN.Location = new System.Drawing.Point(257, 151);
            this.RC_RBN.Name = "RC_RBN";
            this.RC_RBN.Size = new System.Drawing.Size(44, 21);
            this.RC_RBN.TabIndex = 15;
            this.RC_RBN.TabStop = true;
            this.RC_RBN.Text = "No";
            this.RC_RBN.UseVisualStyleBackColor = true;
            // 
            // RC_RBY
            // 
            this.RC_RBY.AutoSize = true;
            this.RC_RBY.Location = new System.Drawing.Point(206, 151);
            this.RC_RBY.Name = "RC_RBY";
            this.RC_RBY.Size = new System.Drawing.Size(45, 21);
            this.RC_RBY.TabIndex = 14;
            this.RC_RBY.Text = "Yes";
            this.RC_RBY.UseVisualStyleBackColor = true;
            // 
            // IsStudent
            // 
            this.IsStudent.AutoSize = true;
            this.IsStudent.Location = new System.Drawing.Point(500, 153);
            this.IsStudent.Name = "IsStudent";
            this.IsStudent.Size = new System.Drawing.Size(71, 21);
            this.IsStudent.TabIndex = 9;
            this.IsStudent.Text = "Student";
            this.IsStudent.UseVisualStyleBackColor = true;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(206, 99);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(365, 25);
            this.CName.TabIndex = 7;
            // 
            // SMan_ID
            // 
            this.SMan_ID.ForeColor = System.Drawing.Color.Black;
            this.SMan_ID.FormattingEnabled = true;
            this.SMan_ID.Items.AddRange(new object[] {
            "S.Man ID 01",
            "S.Man ID 02",
            "S.Man ID 03",
            "S.Man ID 04",
            "S.Man ID 05",
            "S.Man ID 06",
            "S.Man ID 07",
            "S.Man ID 08",
            "S.Man ID 09"});
            this.SMan_ID.Location = new System.Drawing.Point(386, 47);
            this.SMan_ID.Name = "SMan_ID";
            this.SMan_ID.Size = new System.Drawing.Size(185, 25);
            this.SMan_ID.TabIndex = 6;
            this.SMan_ID.Text = "-Please Select-";
            this.SMan_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SMan_ID_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(134, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PName);
            this.groupBox2.Controls.Add(this.PType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Pprice);
            this.groupBox2.Controls.Add(this.PCode);
            this.groupBox2.Controls.Add(this.PName_Text);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // PName
            // 
            this.PName.ForeColor = System.Drawing.Color.Black;
            this.PName.FormattingEnabled = true;
            this.PName.Location = new System.Drawing.Point(191, 85);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(159, 25);
            this.PName.TabIndex = 13;
            this.PName.Text = "-Please Select-";
            this.PName.SelectedIndexChanged += new System.EventHandler(this.PName_SelectedIndexChanged);
            this.PName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PName_KeyPress);
            // 
            // PType
            // 
            this.PType.ForeColor = System.Drawing.Color.Black;
            this.PType.FormattingEnabled = true;
            this.PType.Items.AddRange(new object[] {
            "General Items",
            "Stationary Items",
            "Food and Snacks",
            "Electronics and Gadgets",
            "Textiles and Wearables",
            "Furnitures"});
            this.PType.Location = new System.Drawing.Point(191, 37);
            this.PType.Name = "PType";
            this.PType.Size = new System.Drawing.Size(185, 25);
            this.PType.TabIndex = 12;
            this.PType.Text = "-Please Select-";
            this.PType.SelectedIndexChanged += new System.EventHandler(this.PType_SelectedIndexChanged);
            this.PType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PType_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(28, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Product Type:";
            // 
            // Pprice
            // 
            this.Pprice.Location = new System.Drawing.Point(191, 183);
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(365, 25);
            this.Pprice.TabIndex = 10;
            this.Pprice.TextChanged += new System.EventHandler(this.Pprice_TextChanged);
            this.Pprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pprice_KeyPress);
            // 
            // PCode
            // 
            this.PCode.Location = new System.Drawing.Point(191, 134);
            this.PCode.Name = "PCode";
            this.PCode.Size = new System.Drawing.Size(365, 25);
            this.PCode.TabIndex = 9;
            this.PCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PCode_KeyPress);
            // 
            // PName_Text
            // 
            this.PName_Text.ForeColor = System.Drawing.Color.Gray;
            this.PName_Text.Location = new System.Drawing.Point(359, 85);
            this.PName_Text.Name = "PName_Text";
            this.PName_Text.Size = new System.Drawing.Size(197, 25);
            this.PName_Text.TabIndex = 8;
            this.PName_Text.Text = "Enter the Product Name";
            this.PName_Text.Enter += new System.EventHandler(this.PName_Text_Enter);
            this.PName_Text.Leave += new System.EventHandler(this.PName_Text_Leave);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.White;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Generate.Location = new System.Drawing.Point(1062, 588);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(122, 32);
            this.Generate.TabIndex = 14;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Fprice);
            this.groupBox3.Controls.Add(this.Tax);
            this.groupBox3.Controls.Add(this.Discount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 189);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pricing Details";
            // 
            // Fprice
            // 
            this.Fprice.Location = new System.Drawing.Point(111, 134);
            this.Fprice.Name = "Fprice";
            this.Fprice.Size = new System.Drawing.Size(167, 25);
            this.Fprice.TabIndex = 20;
            this.Fprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fprice_KeyPress);
            // 
            // Tax
            // 
            this.Tax.Location = new System.Drawing.Point(111, 88);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(167, 25);
            this.Tax.TabIndex = 19;
            this.Tax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tax_KeyPress);
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(111, 42);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(167, 25);
            this.Discount.TabIndex = 18;
            this.Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Discount_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.C_Input);
            this.groupBox4.Controls.Add(this.Update);
            this.groupBox4.Controls.Add(this.Remove);
            this.groupBox4.Controls.Add(this.Add);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(314, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 189);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commands";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // C_Input
            // 
            this.C_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.C_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_Input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Input.ForeColor = System.Drawing.Color.DodgerBlue;
            this.C_Input.Location = new System.Drawing.Point(156, 115);
            this.C_Input.Name = "C_Input";
            this.C_Input.Size = new System.Drawing.Size(122, 32);
            this.C_Input.TabIndex = 3;
            this.C_Input.Text = "Clear Input";
            this.C_Input.UseVisualStyleBackColor = false;
            this.C_Input.Click += new System.EventHandler(this.C_Input_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Update.Location = new System.Drawing.Point(16, 115);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(122, 32);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Remove.Location = new System.Drawing.Point(156, 50);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(122, 32);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Add.Location = new System.Drawing.Point(16, 50);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(122, 32);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.Window;
            this.Info.BackgroundImage = global::Product_Bill_Calculator.Properties.Resources.About;
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Info.FlatAppearance.BorderSize = 0;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Location = new System.Drawing.Point(1190, 596);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(24, 24);
            this.Info.TabIndex = 4;
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_No,
            this.Product_Name,
            this.Mrp,
            this.Discount1,
            this.Tax1,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(619, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 618);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // S_No
            // 
            this.S_No.HeaderText = "S.No";
            this.S_No.Name = "S_No";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Mrp
            // 
            this.Mrp.HeaderText = "MRP";
            this.Mrp.Name = "Mrp";
            // 
            // Discount1
            // 
            this.Discount1.HeaderText = "Discount";
            this.Discount1.Name = "Discount1";
            // 
            // Tax1
            // 
            this.Tax1.HeaderText = "Tax";
            this.Tax1.Name = "Tax1";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // NAmount
            // 
            this.NAmount.AutoSize = true;
            this.NAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAmount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NAmount.Location = new System.Drawing.Point(1046, 532);
            this.NAmount.Name = "NAmount";
            this.NAmount.Size = new System.Drawing.Size(95, 21);
            this.NAmount.TabIndex = 14;
            this.NAmount.Text = "Net Amount";
            // 
            // GST
            // 
            this.GST.AutoSize = true;
            this.GST.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GST.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GST.Location = new System.Drawing.Point(1046, 562);
            this.GST.Name = "GST";
            this.GST.Size = new System.Drawing.Size(38, 21);
            this.GST.TabIndex = 15;
            this.GST.Text = "GST";
            // 
            // TAmount
            // 
            this.TAmount.AutoSize = true;
            this.TAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAmount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TAmount.Location = new System.Drawing.Point(1046, 594);
            this.TAmount.Name = "TAmount";
            this.TAmount.Size = new System.Drawing.Size(102, 21);
            this.TAmount.TabIndex = 16;
            this.TAmount.Text = "Total Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1222, 642);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.TAmount);
            this.Controls.Add(this.GST);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.NAmount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1238, 681);
            this.MinimumSize = new System.Drawing.Size(1238, 681);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Bill Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.ComboBox SMan_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Pprice;
        private System.Windows.Forms.TextBox PCode;
        private System.Windows.Forms.TextBox PName_Text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox PName;
        private System.Windows.Forms.ComboBox PType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton RC_RBN;
        private System.Windows.Forms.RadioButton RC_RBY;
        private System.Windows.Forms.CheckBox IsStudent;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button C_Input;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label ID_Generated;
        private System.Windows.Forms.TextBox Fprice;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label NAmount;
        private System.Windows.Forms.Label GST;
        private System.Windows.Forms.Label TAmount;
    }
}

