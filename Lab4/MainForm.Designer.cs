namespace Lab4
{
    partial class MainForm
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
            this.funcDataGridView = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStudyingElementsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfElementsToPredictTextBox = new System.Windows.Forms.TextBox();
            this.startPointOfStudyTextBox = new System.Windows.Forms.TextBox();
            this.numberOfCoefficientsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.predictButton = new System.Windows.Forms.Button();
            this.makeChartButton = new System.Windows.Forms.Button();
            this.setStandardDataButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.predictedValuesDataGridView = new System.Windows.Forms.DataGridView();
            this.solvedSystemDataGridView = new System.Windows.Forms.DataGridView();
            this.compareStatsLabel = new System.Windows.Forms.Label();
            this.coefficientsValuesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictedValuesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solvedSystemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // funcDataGridView
            // 
            this.funcDataGridView.AllowUserToAddRows = false;
            this.funcDataGridView.AllowUserToDeleteRows = false;
            this.funcDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.funcDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.funcDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.FX});
            this.funcDataGridView.Location = new System.Drawing.Point(247, 56);
            this.funcDataGridView.Name = "funcDataGridView";
            this.funcDataGridView.RowHeadersVisible = false;
            this.funcDataGridView.Size = new System.Drawing.Size(163, 204);
            this.funcDataGridView.TabIndex = 0;
            // 
            // N
            // 
            this.N.HeaderText = "";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N.Width = 50;
            // 
            // FX
            // 
            this.FX.HeaderText = "F(x)";
            this.FX.Name = "FX";
            this.FX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FX.Width = 70;
            // 
            // numberOfStudyingElementsTextBox
            // 
            this.numberOfStudyingElementsTextBox.Location = new System.Drawing.Point(467, 56);
            this.numberOfStudyingElementsTextBox.Name = "numberOfStudyingElementsTextBox";
            this.numberOfStudyingElementsTextBox.Size = new System.Drawing.Size(68, 20);
            this.numberOfStudyingElementsTextBox.TabIndex = 1;
            this.numberOfStudyingElementsTextBox.Text = "8";
            this.numberOfStudyingElementsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfStudyingElementsTextBox.TextChanged += new System.EventHandler(this.numberOfStudyingElementsTextBox_TextChanged);
            // 
            // numberOfElementsToPredictTextBox
            // 
            this.numberOfElementsToPredictTextBox.Location = new System.Drawing.Point(467, 125);
            this.numberOfElementsToPredictTextBox.Name = "numberOfElementsToPredictTextBox";
            this.numberOfElementsToPredictTextBox.Size = new System.Drawing.Size(68, 20);
            this.numberOfElementsToPredictTextBox.TabIndex = 2;
            this.numberOfElementsToPredictTextBox.Text = "2";
            this.numberOfElementsToPredictTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfElementsToPredictTextBox.TextChanged += new System.EventHandler(this.numberOfElementsToPredictTextBox_TextChanged);
            // 
            // startPointOfStudyTextBox
            // 
            this.startPointOfStudyTextBox.Location = new System.Drawing.Point(467, 194);
            this.startPointOfStudyTextBox.Name = "startPointOfStudyTextBox";
            this.startPointOfStudyTextBox.Size = new System.Drawing.Size(68, 20);
            this.startPointOfStudyTextBox.TabIndex = 3;
            this.startPointOfStudyTextBox.Text = "3";
            this.startPointOfStudyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startPointOfStudyTextBox.TextChanged += new System.EventHandler(this.startPointOfStudyTextBox_TextChanged);
            // 
            // numberOfCoefficientsTextBox
            // 
            this.numberOfCoefficientsTextBox.Location = new System.Drawing.Point(467, 263);
            this.numberOfCoefficientsTextBox.Name = "numberOfCoefficientsTextBox";
            this.numberOfCoefficientsTextBox.Size = new System.Drawing.Size(68, 20);
            this.numberOfCoefficientsTextBox.TabIndex = 4;
            this.numberOfCoefficientsTextBox.Text = "4";
            this.numberOfCoefficientsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfCoefficientsTextBox.TextChanged += new System.EventHandler(this.numberOfCoefficientsTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(440, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кількість елементів навчання";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(440, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кількість прогнозованих елементів";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(440, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Початкова точка навчання";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(440, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кількість коефіцієнтів прогнозуючої моделі";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(40, 56);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(127, 23);
            this.predictButton.TabIndex = 9;
            this.predictButton.Text = "Зпрогнозувати";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // makeChartButton
            // 
            this.makeChartButton.Location = new System.Drawing.Point(40, 85);
            this.makeChartButton.Name = "makeChartButton";
            this.makeChartButton.Size = new System.Drawing.Size(127, 23);
            this.makeChartButton.TabIndex = 10;
            this.makeChartButton.Text = "Побудувати графік";
            this.makeChartButton.UseVisualStyleBackColor = true;
            this.makeChartButton.Click += new System.EventHandler(this.makeChartButton_Click);
            // 
            // setStandardDataButton
            // 
            this.setStandardDataButton.Location = new System.Drawing.Point(40, 114);
            this.setStandardDataButton.Name = "setStandardDataButton";
            this.setStandardDataButton.Size = new System.Drawing.Size(127, 23);
            this.setStandardDataButton.TabIndex = 11;
            this.setStandardDataButton.Text = "Стандартні значення";
            this.setStandardDataButton.UseVisualStyleBackColor = true;
            this.setStandardDataButton.Click += new System.EventHandler(this.setStandardDataButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(244, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Значення розподілу";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictedValuesDataGridView
            // 
            this.predictedValuesDataGridView.AllowUserToAddRows = false;
            this.predictedValuesDataGridView.AllowUserToDeleteRows = false;
            this.predictedValuesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.predictedValuesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.predictedValuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predictedValuesDataGridView.Location = new System.Drawing.Point(208, 305);
            this.predictedValuesDataGridView.Name = "predictedValuesDataGridView";
            this.predictedValuesDataGridView.ReadOnly = true;
            this.predictedValuesDataGridView.RowHeadersVisible = false;
            this.predictedValuesDataGridView.Size = new System.Drawing.Size(317, 150);
            this.predictedValuesDataGridView.TabIndex = 13;
            this.predictedValuesDataGridView.Visible = false;
            // 
            // solvedSystemDataGridView
            // 
            this.solvedSystemDataGridView.AllowUserToAddRows = false;
            this.solvedSystemDataGridView.AllowUserToDeleteRows = false;
            this.solvedSystemDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.solvedSystemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solvedSystemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solvedSystemDataGridView.ColumnHeadersVisible = false;
            this.solvedSystemDataGridView.Location = new System.Drawing.Point(12, 305);
            this.solvedSystemDataGridView.Name = "solvedSystemDataGridView";
            this.solvedSystemDataGridView.ReadOnly = true;
            this.solvedSystemDataGridView.RowHeadersVisible = false;
            this.solvedSystemDataGridView.Size = new System.Drawing.Size(155, 150);
            this.solvedSystemDataGridView.TabIndex = 14;
            this.solvedSystemDataGridView.Visible = false;
            // 
            // compareStatsLabel
            // 
            this.compareStatsLabel.Location = new System.Drawing.Point(205, 262);
            this.compareStatsLabel.Name = "compareStatsLabel";
            this.compareStatsLabel.Size = new System.Drawing.Size(238, 39);
            this.compareStatsLabel.TabIndex = 15;
            this.compareStatsLabel.Text = "Порівняльні характеристики результатів моделювання";
            this.compareStatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.compareStatsLabel.Visible = false;
            // 
            // coefficientsValuesLabel
            // 
            this.coefficientsValuesLabel.Location = new System.Drawing.Point(9, 243);
            this.coefficientsValuesLabel.Name = "coefficientsValuesLabel";
            this.coefficientsValuesLabel.Size = new System.Drawing.Size(133, 58);
            this.coefficientsValuesLabel.TabIndex = 16;
            this.coefficientsValuesLabel.Text = "Значення коефіцієнтів прогнозуючої моделі";
            this.coefficientsValuesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coefficientsValuesLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 467);
            this.Controls.Add(this.coefficientsValuesLabel);
            this.Controls.Add(this.compareStatsLabel);
            this.Controls.Add(this.solvedSystemDataGridView);
            this.Controls.Add(this.predictedValuesDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.setStandardDataButton);
            this.Controls.Add(this.makeChartButton);
            this.Controls.Add(this.predictButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfCoefficientsTextBox);
            this.Controls.Add(this.startPointOfStudyTextBox);
            this.Controls.Add(this.numberOfElementsToPredictTextBox);
            this.Controls.Add(this.numberOfStudyingElementsTextBox);
            this.Controls.Add(this.funcDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictedValuesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solvedSystemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView funcDataGridView;
        private System.Windows.Forms.TextBox numberOfStudyingElementsTextBox;
        private System.Windows.Forms.TextBox numberOfElementsToPredictTextBox;
        private System.Windows.Forms.TextBox startPointOfStudyTextBox;
        private System.Windows.Forms.TextBox numberOfCoefficientsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.Button makeChartButton;
        private System.Windows.Forms.Button setStandardDataButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView predictedValuesDataGridView;
        private System.Windows.Forms.DataGridView solvedSystemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn FX;
        private System.Windows.Forms.Label compareStatsLabel;
        private System.Windows.Forms.Label coefficientsValuesLabel;
    }
}

