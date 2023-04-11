namespace test_K
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_abonent = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.abonent_number = new System.Windows.Forms.TextBox();
            this.abonent_thems = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_abonentn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_abonentt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thems_abobus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time_calling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_abonent
            // 
            this.name_abonent.Location = new System.Drawing.Point(16, 118);
            this.name_abonent.MaxLength = 60;
            this.name_abonent.Name = "name_abonent";
            this.name_abonent.Size = new System.Drawing.Size(100, 20);
            this.name_abonent.TabIndex = 0;
            this.name_abonent.Text = "chel";
            this.name_abonent.TextChanged += new System.EventHandler(this.name_abonent_TextChanged);
            this.name_abonent.Enter += new System.EventHandler(this.name_abonent_Enter);
            this.name_abonent.Leave += new System.EventHandler(this.name_abonent_Leave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "abonent";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(330, 87);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "priority";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(224, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "thems";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(118, 87);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(59, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "number";
            // 
            // abonent_number
            // 
            this.abonent_number.Location = new System.Drawing.Point(122, 118);
            this.abonent_number.MaxLength = 12;
            this.abonent_number.Name = "abonent_number";
            this.abonent_number.Size = new System.Drawing.Size(100, 20);
            this.abonent_number.TabIndex = 5;
            this.abonent_number.Text = "+79XXXXXXXXX";
            this.abonent_number.TextChanged += new System.EventHandler(this.abonent_number_TextChanged);
            this.abonent_number.Enter += new System.EventHandler(this.abonent_number_Enter);
            this.abonent_number.Leave += new System.EventHandler(this.abonent_number_Leave);
            // 
            // abonent_thems
            // 
            this.abonent_thems.Location = new System.Drawing.Point(228, 118);
            this.abonent_thems.MaxLength = 20;
            this.abonent_thems.Name = "abonent_thems";
            this.abonent_thems.Size = new System.Drawing.Size(100, 20);
            this.abonent_thems.TabIndex = 6;
            this.abonent_thems.Text = "programming";
            this.abonent_thems.Enter += new System.EventHandler(this.abonent_thems_Enter);
            this.abonent_thems.Leave += new System.EventHandler(this.abonent_thems_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(334, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Black;
            this.materialFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialFlatButton1.Location = new System.Drawing.Point(485, 102);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(99, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "create call";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index_number,
            this.priority_number,
            this.number_abonentn,
            this.name_abonentt,
            this.thems_abobus,
            this.start_time_calling});
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 171);
            this.dataGridView1.TabIndex = 9;
            // 
            // index_number
            // 
            this.index_number.HeaderText = "idx";
            this.index_number.MaxInputLength = 3;
            this.index_number.Name = "index_number";
            this.index_number.ReadOnly = true;
            // 
            // priority_number
            // 
            this.priority_number.HeaderText = "priority";
            this.priority_number.Name = "priority_number";
            this.priority_number.ReadOnly = true;
            // 
            // number_abonentn
            // 
            this.number_abonentn.HeaderText = "number";
            this.number_abonentn.Name = "number_abonentn";
            this.number_abonentn.ReadOnly = true;
            // 
            // name_abonentt
            // 
            this.name_abonentt.HeaderText = "name";
            this.name_abonentt.Name = "name_abonentt";
            this.name_abonentt.ReadOnly = true;
            // 
            // thems_abobus
            // 
            this.thems_abobus.HeaderText = "Thems";
            this.thems_abobus.Name = "thems_abobus";
            this.thems_abobus.ReadOnly = true;
            // 
            // start_time_calling
            // 
            this.start_time_calling.HeaderText = "start_time";
            this.start_time_calling.Name = "start_time_calling";
            this.start_time_calling.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.abonent_thems);
            this.Controls.Add(this.abonent_number);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.name_abonent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox name_abonent;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox abonent_number;
        private System.Windows.Forms.TextBox abonent_thems;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_abonentn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_abonentt;
        private System.Windows.Forms.DataGridViewTextBoxColumn thems_abobus;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time_calling;
    }
}

