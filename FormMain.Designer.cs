namespace RMLP
{
	partial class FormMain
	{
		/// <summary>
		/// Требуется переменная конструктора.
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
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridIn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridOut = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGenSin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.udCountIn = new System.Windows.Forms.NumericUpDown();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.btPrognoz = new System.Windows.Forms.Button();
            this.udCountOut = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbError = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.udEpoch = new System.Windows.Forms.NumericUpDown();
            this.udNeurons = new System.Windows.Forms.NumericUpDown();
            this.btTrain = new System.Windows.Forms.Button();
            this.btSaveIn = new System.Windows.Forms.Button();
            this.btSaveOut = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCountIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCountOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNeurons)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridIn
            // 
            this.gridIn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridIn.Location = new System.Drawing.Point(2, 132);
            this.gridIn.Name = "gridIn";
            this.gridIn.RowHeadersVisible = false;
            this.gridIn.Size = new System.Drawing.Size(151, 325);
            this.gridIn.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // gridOut
            // 
            this.gridOut.AllowUserToAddRows = false;
            this.gridOut.AllowUserToDeleteRows = false;
            this.gridOut.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3});
            this.gridOut.Location = new System.Drawing.Point(0, 79);
            this.gridOut.Name = "gridOut";
            this.gridOut.RowHeadersVisible = false;
            this.gridOut.Size = new System.Drawing.Size(206, 246);
            this.gridOut.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // btGenSin
            // 
            this.btGenSin.Location = new System.Drawing.Point(0, 103);
            this.btGenSin.Name = "btGenSin";
            this.btGenSin.Size = new System.Drawing.Size(151, 23);
            this.btGenSin.TabIndex = 4;
            this.btGenSin.Text = "Сгенерировать";
            this.btGenSin.UseVisualStyleBackColor = true;
            this.btGenSin.Click += new System.EventHandler(this.btGenSin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество:";
            // 
            // udCountIn
            // 
            this.udCountIn.Location = new System.Drawing.Point(77, 45);
            this.udCountIn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udCountIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCountIn.Name = "udCountIn";
            this.udCountIn.Size = new System.Drawing.Size(70, 20);
            this.udCountIn.TabIndex = 7;
            this.udCountIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbGraph
            // 
            this.pbGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGraph.Location = new System.Drawing.Point(360, 19);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(565, 466);
            this.pbGraph.TabIndex = 8;
            this.pbGraph.TabStop = false;
            this.pbGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraph_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "График:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Шаг:";
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(77, 70);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(70, 20);
            this.tbStep.TabIndex = 11;
            // 
            // btPrognoz
            // 
            this.btPrognoz.Location = new System.Drawing.Point(0, 50);
            this.btPrognoz.Name = "btPrognoz";
            this.btPrognoz.Size = new System.Drawing.Size(206, 23);
            this.btPrognoz.TabIndex = 12;
            this.btPrognoz.Text = "Прогноз";
            this.btPrognoz.UseVisualStyleBackColor = true;
            this.btPrognoz.Click += new System.EventHandler(this.btPrognoz_Click);
            // 
            // udCountOut
            // 
            this.udCountOut.Location = new System.Drawing.Point(81, 24);
            this.udCountOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCountOut.Name = "udCountOut";
            this.udCountOut.Size = new System.Drawing.Size(69, 20);
            this.udCountOut.TabIndex = 15;
            this.udCountOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Количество:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Эпох:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ошибка:";
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(166, 43);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(34, 20);
            this.tbError.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Нейронов в скрытом слое:";
            // 
            // udEpoch
            // 
            this.udEpoch.Location = new System.Drawing.Point(46, 43);
            this.udEpoch.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.udEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udEpoch.Name = "udEpoch";
            this.udEpoch.Size = new System.Drawing.Size(58, 20);
            this.udEpoch.TabIndex = 22;
            this.udEpoch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udNeurons
            // 
            this.udNeurons.Location = new System.Drawing.Point(166, 75);
            this.udNeurons.Name = "udNeurons";
            this.udNeurons.Size = new System.Drawing.Size(34, 20);
            this.udNeurons.TabIndex = 23;
            // 
            // btTrain
            // 
            this.btTrain.Location = new System.Drawing.Point(154, 106);
            this.btTrain.Name = "btTrain";
            this.btTrain.Size = new System.Drawing.Size(206, 23);
            this.btTrain.TabIndex = 24;
            this.btTrain.Text = "Обучить";
            this.btTrain.UseVisualStyleBackColor = true;
            this.btTrain.Click += new System.EventHandler(this.btTrain_Click);
            // 
            // btSaveIn
            // 
            this.btSaveIn.Location = new System.Drawing.Point(1, 462);
            this.btSaveIn.Name = "btSaveIn";
            this.btSaveIn.Size = new System.Drawing.Size(153, 23);
            this.btSaveIn.TabIndex = 25;
            this.btSaveIn.Text = "Сохранить в файл";
            this.btSaveIn.UseVisualStyleBackColor = true;
            this.btSaveIn.Click += new System.EventHandler(this.btSaveIn_Click);
            // 
            // btSaveOut
            // 
            this.btSaveOut.Location = new System.Drawing.Point(154, 462);
            this.btSaveOut.Name = "btSaveOut";
            this.btSaveOut.Size = new System.Drawing.Size(206, 23);
            this.btSaveOut.TabIndex = 26;
            this.btSaveOut.Text = "Сохранить в файл";
            this.btSaveOut.UseVisualStyleBackColor = true;
            this.btSaveOut.Click += new System.EventHandler(this.btSaveOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.udCountIn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbStep);
            this.groupBox1.Controls.Add(this.gridIn);
            this.groupBox1.Controls.Add(this.btGenSin);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 457);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация последовательности";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.udEpoch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbError);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.udNeurons);
            this.groupBox2.Location = new System.Drawing.Point(154, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 104);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обучение последовательности";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.udCountOut);
            this.groupBox3.Controls.Add(this.btPrognoz);
            this.groupBox3.Controls.Add(this.gridOut);
            this.groupBox3.Location = new System.Drawing.Point(154, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 325);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прогнозирование";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSaveOut);
            this.Controls.Add(this.btSaveIn);
            this.Controls.Add(this.btTrain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbGraph);
            this.Name = "FormMain";
            this.Text = "Рекуррентный многослойный персептрон";
            ((System.ComponentModel.ISupportInitialize)(this.gridIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCountIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCountOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNeurons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridView gridIn;
        private System.Windows.Forms.DataGridView gridOut;
        private System.Windows.Forms.Button btGenSin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown udCountIn;
		private System.Windows.Forms.PictureBox pbGraph;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Button btPrognoz;
		private System.Windows.Forms.NumericUpDown udCountOut;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbError;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown udEpoch;
		private System.Windows.Forms.NumericUpDown udNeurons;
		private System.Windows.Forms.Button btTrain;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button btSaveIn;
		private System.Windows.Forms.Button btSaveOut;
		private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
	}
}

