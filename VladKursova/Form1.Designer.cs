namespace VladKursova
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchByCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchQueryTB = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CancelSearchBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.ApartmentsAmnNUD = new System.Windows.Forms.NumericUpDown();
            this.ToMetroMinNUD = new System.Windows.Forms.NumericUpDown();
            this.PriceNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActualityCB = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmentsAmnNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToMetroMinNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SaveBtn);
            this.tabPage2.Controls.Add(this.CancelSearchBtn);
            this.tabPage2.Controls.Add(this.SearchBtn);
            this.tabPage2.Controls.Add(this.SearchQueryTB);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.SearchByCB);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Записи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(7, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(704, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchByCB
            // 
            this.SearchByCB.FormattingEnabled = true;
            this.SearchByCB.Items.AddRange(new object[] {
            "містом",
            "кількостю кімнат >= заданої",
            "кількостю кімнат <= заданої",
            "часом пішки до метро",
            "загальний"});
            this.SearchByCB.Location = new System.Drawing.Point(65, 6);
            this.SearchByCB.Name = "SearchByCB";
            this.SearchByCB.Size = new System.Drawing.Size(173, 21);
            this.SearchByCB.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Пошук за";
            // 
            // SearchQueryTB
            // 
            this.SearchQueryTB.Location = new System.Drawing.Point(244, 6);
            this.SearchQueryTB.Name = "SearchQueryTB";
            this.SearchQueryTB.Size = new System.Drawing.Size(99, 20);
            this.SearchQueryTB.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(349, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Шукати";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CancelSearchBtn
            // 
            this.CancelSearchBtn.Location = new System.Drawing.Point(430, 4);
            this.CancelSearchBtn.Name = "CancelSearchBtn";
            this.CancelSearchBtn.Size = new System.Drawing.Size(106, 23);
            this.CancelSearchBtn.TabIndex = 5;
            this.CancelSearchBtn.Text = "Відмінити пошук";
            this.CancelSearchBtn.UseVisualStyleBackColor = true;
            this.CancelSearchBtn.Click += new System.EventHandler(this.CancelSearchBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ActualityCB);
            this.tabPage1.Controls.Add(this.AddBtn);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PriceNUD);
            this.tabPage1.Controls.Add(this.ToMetroMinNUD);
            this.tabPage1.Controls.Add(this.ApartmentsAmnNUD);
            this.tabPage1.Controls.Add(this.AddressTB);
            this.tabPage1.Controls.Add(this.CityTB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Додати";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(335, 18);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(157, 20);
            this.CityTB.TabIndex = 0;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(335, 44);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(157, 20);
            this.AddressTB.TabIndex = 1;
            // 
            // ApartmentsAmnNUD
            // 
            this.ApartmentsAmnNUD.Location = new System.Drawing.Point(335, 124);
            this.ApartmentsAmnNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ApartmentsAmnNUD.Name = "ApartmentsAmnNUD";
            this.ApartmentsAmnNUD.Size = new System.Drawing.Size(58, 20);
            this.ApartmentsAmnNUD.TabIndex = 3;
            this.ApartmentsAmnNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ToMetroMinNUD
            // 
            this.ToMetroMinNUD.Location = new System.Drawing.Point(335, 150);
            this.ToMetroMinNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ToMetroMinNUD.Name = "ToMetroMinNUD";
            this.ToMetroMinNUD.Size = new System.Drawing.Size(58, 20);
            this.ToMetroMinNUD.TabIndex = 6;
            // 
            // PriceNUD
            // 
            this.PriceNUD.Location = new System.Drawing.Point(335, 98);
            this.PriceNUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PriceNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceNUD.Name = "PriceNUD";
            this.PriceNUD.Size = new System.Drawing.Size(88, 20);
            this.PriceNUD.TabIndex = 8;
            this.PriceNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Назва міста:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адреса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Актуальність:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Кількість кімнат:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ціна оренди(грн/міс):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Пішки до метро(хв):";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(272, 188);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 36);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Додати відпустку";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // ActualityCB
            // 
            this.ActualityCB.FormattingEnabled = true;
            this.ActualityCB.Items.AddRange(new object[] {
            "здана",
            "не здана"});
            this.ActualityCB.Location = new System.Drawing.Point(335, 71);
            this.ActualityCB.Name = "ActualityCB";
            this.ActualityCB.Size = new System.Drawing.Size(121, 21);
            this.ActualityCB.TabIndex = 19;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(589, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(106, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Зберегти файл";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Видалити";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Місто";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адреса";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "К-ть кімнат";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ціна оренди";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Скільки пішки до метро";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Актуальність";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата і час внесення";
            this.Column8.Name = "Column8";
            this.Column8.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 288);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmentsAmnNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToMetroMinNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CancelSearchBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchQueryTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SearchByCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PriceNUD;
        private System.Windows.Forms.NumericUpDown ToMetroMinNUD;
        private System.Windows.Forms.NumericUpDown ApartmentsAmnNUD;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox ActualityCB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

