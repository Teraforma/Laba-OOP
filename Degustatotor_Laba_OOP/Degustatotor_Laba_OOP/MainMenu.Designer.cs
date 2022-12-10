namespace Degustatotor_Laba_OOP
{
    partial class MainMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthyPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TastePoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexInDateStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Who_button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.Type,
            this.HealthyPoints,
            this.TastePoints,
            this.Note,
            this.Verified,
            this.PriceCol,
            this.StoreCol,
            this.IndexInDateStructure});
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 856);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.dataGridView1_RowDividerDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 9;
            this.NameCol.Name = "NameCol";
            this.NameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameCol.Width = 140;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 9;
            this.Type.Name = "Type";
            this.Type.Width = 120;
            // 
            // HealthyPoints
            // 
            this.HealthyPoints.HeaderText = "Healthy Points";
            this.HealthyPoints.MinimumWidth = 9;
            this.HealthyPoints.Name = "HealthyPoints";
            this.HealthyPoints.Width = 90;
            // 
            // TastePoints
            // 
            this.TastePoints.HeaderText = "Taste Points";
            this.TastePoints.MinimumWidth = 9;
            this.TastePoints.Name = "TastePoints";
            this.TastePoints.Width = 90;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 9;
            this.Note.Name = "Note";
            this.Note.Width = 400;
            // 
            // Verified
            // 
            this.Verified.HeaderText = "Verification day";
            this.Verified.MinimumWidth = 9;
            this.Verified.Name = "Verified";
            this.Verified.Width = 175;
            // 
            // PriceCol
            // 
            this.PriceCol.HeaderText = "Price";
            this.PriceCol.MinimumWidth = 9;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.Width = 80;
            // 
            // StoreCol
            // 
            this.StoreCol.HeaderText = "Store";
            this.StoreCol.MinimumWidth = 9;
            this.StoreCol.Name = "StoreCol";
            this.StoreCol.Width = 175;
            // 
            // IndexInDateStructure
            // 
            this.IndexInDateStructure.HeaderText = "Index";
            this.IndexInDateStructure.MinimumWidth = 9;
            this.IndexInDateStructure.Name = "IndexInDateStructure";
            this.IndexInDateStructure.Visible = false;
            this.IndexInDateStructure.Width = 175;
            // 
            // Who_button
            // 
            this.Who_button.Location = new System.Drawing.Point(1354, 657);
            this.Who_button.Name = "Who_button";
            this.Who_button.Size = new System.Drawing.Size(204, 199);
            this.Who_button.TabIndex = 1;
            this.Who_button.Text = "Who";
            this.Who_button.UseVisualStyleBackColor = true;
            this.Who_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Save_Button.Location = new System.Drawing.Point(1354, 440);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(108, 199);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1354, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 199);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Selected";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1354, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 199);
            this.button4.TabIndex = 4;
            this.button4.Text = "Input";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(1460, 440);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(98, 199);
            this.Load_button.TabIndex = 5;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 857);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Who_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button Who_button;
        private Button Save_Button;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn HealthyPoints;
        private DataGridViewTextBoxColumn TastePoints;
        private DataGridViewTextBoxColumn Note;
        private DataGridViewTextBoxColumn Verified;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn StoreCol;
        private DataGridViewTextBoxColumn IndexInDateStructure;
        private Button Load_button;
    }
}