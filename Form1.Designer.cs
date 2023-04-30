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
            this.priority_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_abonentn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_abonentt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thems_abobus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time_calling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key_materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Key_comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.end_call_textbox = new System.Windows.Forms.TextBox();
            this.End_call_materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.key_visible = new System.Windows.Forms.TextBox();
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
            this.name_abonent.TextChanged += new System.EventHandler(this.Name_abonent_TextChanged);
            this.name_abonent.Enter += new System.EventHandler(this.Name_abonent_Enter);
            this.name_abonent.Leave += new System.EventHandler(this.Name_abonent_Leave);
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
            this.abonent_number.TextChanged += new System.EventHandler(this.Abonent_number_TextChanged);
            this.abonent_number.Enter += new System.EventHandler(this.Abonent_number_Enter);
            this.abonent_number.Leave += new System.EventHandler(this.Abonent_number_Leave);
            // 
            // abonent_thems
            // 
            this.abonent_thems.Location = new System.Drawing.Point(228, 118);
            this.abonent_thems.MaxLength = 20;
            this.abonent_thems.Name = "abonent_thems";
            this.abonent_thems.Size = new System.Drawing.Size(100, 20);
            this.abonent_thems.TabIndex = 6;
            this.abonent_thems.Text = "programming";
            this.abonent_thems.Enter += new System.EventHandler(this.Abonent_thems_Enter);
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
            this.materialFlatButton1.Location = new System.Drawing.Point(629, 102);
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
            // Key_materialLabel5
            // 
            this.Key_materialLabel5.AutoSize = true;
            this.Key_materialLabel5.Depth = 0;
            this.Key_materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.Key_materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_materialLabel5.Location = new System.Drawing.Point(457, 87);
            this.Key_materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Key_materialLabel5.Name = "Key_materialLabel5";
            this.Key_materialLabel5.Size = new System.Drawing.Size(33, 19);
            this.Key_materialLabel5.TabIndex = 10;
            this.Key_materialLabel5.Text = "Key";
            // 
            // Key_comboBox2
            // 
            this.Key_comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Key_comboBox2.FormattingEnabled = true;
            this.Key_comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Key_comboBox2.Items.AddRange(new object[] {
            "Abonent",
            "Numbers",
            "Thems",
            "Priority"});
            this.Key_comboBox2.Location = new System.Drawing.Point(461, 117);
            this.Key_comboBox2.Name = "Key_comboBox2";
            this.Key_comboBox2.Size = new System.Drawing.Size(121, 21);
            this.Key_comboBox2.TabIndex = 11;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(625, 186);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "end call by key";
            // 
            // end_call_textbox
            // 
            this.end_call_textbox.Location = new System.Drawing.Point(629, 220);
            this.end_call_textbox.Name = "end_call_textbox";
            this.end_call_textbox.Size = new System.Drawing.Size(100, 20);
            this.end_call_textbox.TabIndex = 13;
            // 
            // End_call_materialFlatButton2
            // 
            this.End_call_materialFlatButton2.AutoSize = true;
            this.End_call_materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.End_call_materialFlatButton2.BackColor = System.Drawing.Color.Black;
            this.End_call_materialFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.End_call_materialFlatButton2.Depth = 0;
            this.End_call_materialFlatButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.End_call_materialFlatButton2.Location = new System.Drawing.Point(640, 258);
            this.End_call_materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.End_call_materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.End_call_materialFlatButton2.Name = "End_call_materialFlatButton2";
            this.End_call_materialFlatButton2.Primary = false;
            this.End_call_materialFlatButton2.Size = new System.Drawing.Size(75, 36);
            this.End_call_materialFlatButton2.TabIndex = 14;
            this.End_call_materialFlatButton2.Text = "end call";
            this.End_call_materialFlatButton2.UseVisualStyleBackColor = false;
            this.End_call_materialFlatButton2.Click += new System.EventHandler(this.End_call_materialFlatButton2_Click);
            // 
            // key_visible
            // 
            this.key_visible.Location = new System.Drawing.Point(496, 88);
            this.key_visible.Name = "key_visible";
            this.key_visible.Size = new System.Drawing.Size(100, 20);
            this.key_visible.TabIndex = 15;
            this.key_visible.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.key_visible);
            this.Controls.Add(this.End_call_materialFlatButton2);
            this.Controls.Add(this.end_call_textbox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.Key_comboBox2);
            this.Controls.Add(this.Key_materialLabel5);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn priority_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_abonentn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_abonentt;
        private System.Windows.Forms.DataGridViewTextBoxColumn thems_abobus;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time_calling;
        private MaterialSkin.Controls.MaterialLabel Key_materialLabel5;
        private System.Windows.Forms.ComboBox Key_comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox end_call_textbox;
        private MaterialSkin.Controls.MaterialFlatButton End_call_materialFlatButton2;
        private System.Windows.Forms.TextBox key_visible;
    }
}

