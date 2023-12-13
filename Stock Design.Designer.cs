namespace Stock
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
            label1 = new Label();
            label2 = new Label();
            datagrid = new DataGridView();
            updbtn = new Button();
            id = new DataGridViewTextBoxColumn();
            Medname = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            Mdate = new DataGridViewTextBoxColumn();
            Edate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(614, 9);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 0;
            label1.Text = "x";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(236, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 0;
            label2.Text = "STOCKS LIST";
            // 
            // datagrid
            // 
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Columns.AddRange(new DataGridViewColumn[] { id, Medname, qty, Mdate, Edate });
            datagrid.Location = new Point(49, 75);
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowTemplate.Height = 25;
            datagrid.Size = new Size(544, 288);
            datagrid.TabIndex = 1;
            datagrid.CellContentClick += dtg_CellContentClick;
            // 
            // updbtn
            // 
            updbtn.Location = new Point(518, 390);
            updbtn.Name = "updbtn";
            updbtn.Size = new Size(75, 23);
            updbtn.TabIndex = 2;
            updbtn.Text = "Show list";
            updbtn.UseVisualStyleBackColor = true;
            updbtn.Click += updbtn_Click;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Medname
            // 
            Medname.DataPropertyName = "medname";
            Medname.HeaderText = "Medicine Name";
            Medname.Name = "Medname";
            Medname.ReadOnly = true;
            // 
            // qty
            // 
            qty.DataPropertyName = "qty";
            qty.HeaderText = "Quantity";
            qty.Name = "qty";
            qty.ReadOnly = true;
            // 
            // Mdate
            // 
            Mdate.DataPropertyName = "Mdate";
            Mdate.HeaderText = "Manifacturing Date";
            Mdate.Name = "Mdate";
            Mdate.ReadOnly = true;
            // 
            // Edate
            // 
            Edate.DataPropertyName = "Edate";
            Edate.HeaderText = "Expiry Date";
            Edate.Name = "Edate";
            Edate.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(updbtn);
            Controls.Add(datagrid);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Stock ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView datagrid;
        private Button updbtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Medname;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn Mdate;
        private DataGridViewTextBoxColumn Edate;
    }
}