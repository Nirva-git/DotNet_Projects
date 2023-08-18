namespace Project_one
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
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            SalaryTextBox = new TextBox();
            NameLabel = new Label();
            AgeLabel = new Label();
            SalaryLabel = new Label();
            SubmitButton = new Button();
            UserDataGrid = new DataGridView();
            ExportToCSV = new Button();
            ImportFromCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(101, 58);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(175, 23);
            NameTextBox.TabIndex = 0;
            NameTextBox.Text = " ";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(101, 109);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(175, 23);
            AgeTextBox.TabIndex = 1;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(101, 167);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(175, 23);
            SalaryTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(31, 66);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "FullName :";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(31, 117);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(34, 15);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age :";
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(31, 175);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(44, 15);
            SalaryLabel.TabIndex = 5;
            SalaryLabel.Text = "Salary :";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(91, 228);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 6;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // UserDataGrid
            // 
            UserDataGrid.BackgroundColor = SystemColors.Control;
            UserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGrid.GridColor = SystemColors.Window;
            UserDataGrid.Location = new Point(331, 66);
            UserDataGrid.Name = "UserDataGrid";
            UserDataGrid.RowTemplate.Height = 25;
            UserDataGrid.Size = new Size(417, 150);
            UserDataGrid.TabIndex = 7;
            // 
            // ExportToCSV
            // 
            ExportToCSV.Location = new Point(620, 228);
            ExportToCSV.Name = "ExportToCSV";
            ExportToCSV.Size = new Size(97, 23);
            ExportToCSV.TabIndex = 8;
            ExportToCSV.Text = "ExportToCSV";
            ExportToCSV.UseVisualStyleBackColor = true;
            this.ExportToCSV.Click += new System.EventHandler(this.ExportToCSV_Click);
            // 
            // ImportFromCSV
            // 
            ImportFromCSV.Location = new Point(375, 228);
            ImportFromCSV.Name = "ImportFromCSV";
            ImportFromCSV.Size = new Size(125, 23);
            ImportFromCSV.TabIndex = 9;
            ImportFromCSV.Text = "ImportFromCSV";
            ImportFromCSV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImportFromCSV);
            Controls.Add(ExportToCSV);
            Controls.Add(UserDataGrid);
            Controls.Add(SubmitButton);
            Controls.Add(SalaryLabel);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Controls.Add(SalaryTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(NameTextBox);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox NameTextBox;
        private TextBox AgeTextBox;
        private TextBox SalaryTextBox;
        private Label NameLabel;
        private Label AgeLabel;
        private Label SalaryLabel;
        private Button SubmitButton;
        private DataGridView UserDataGrid;
        private Button ExportToCSV;
        private Button ImportFromCSV;
    }
}