namespace Project_one
{
    public partial class Form1 : Form
    {
        private Task2 task2Instance; // Declare an instance of your Task2 class
        public Form1()
        {
            InitializeComponent();
            task2Instance = new Task2(UserDataGrid, this); // Initialize your Task2 instance
        }

        private void ExportToCSV_Click(object sender, EventArgs e)
        {
            task2Instance.ExportToCsv(); // Call the ExportToCsv method when the button is clicked
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            UserDataGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.HeaderText = "Age";
            ageColumn.Name = "Age";
            UserDataGrid.Columns.Add(ageColumn);

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.HeaderText = "Salary";
            salaryColumn.Name = "Salary";
            UserDataGrid.Columns.Add(salaryColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            //deleteButtonColoumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonCell buttonCellTemplate = new DataGridViewButtonCell();
            buttonCellTemplate.Value = "Delete"; // Set the button text for the cell template
            deleteButtonColumn.CellTemplate = buttonCellTemplate;

            // Set the cell template to a new DataGridViewButtonCell instance
            //deleteButtonColoumn.CellTemplate = new DataGridViewButtonCell();
            UserDataGrid.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            UserDataGrid.Columns.Add(editButtonColumn);

            UserDataGrid.AutoResizeColumns();

            //set a maximum width for columns
            foreach (DataGridViewColumn column in UserDataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Disable automatic sizing
                column.Width = 80;  // adjust this value to your preference
            }
            //foreach (DataGridViewRow row in UserDataGrid.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (cell.OwningColumn.Name == "Delete" && cell is DataGridViewButtonCell buttonCell)
            //        {
            //            buttonCell.Value = "Delete"; // Set the button text
            //        }
            //    }
            //}
            UserDataGrid.RowsAdded += UserDataGrid_RowsAdded;
            //UserDataGrid.DefaultValuesNeeded += UserDataGrid_DefaultValuesNeeded;
            UserDataGrid.CellClick += UserDataGrid_CellClick;
            // Prevent the DataGridView from showing an empty row for adding new data
            UserDataGrid.AllowUserToAddRows = false;
        }

        //private void UserDataGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        //{
        //    if (e.Row.Cells["Delete"] is DataGridViewButtonCell buttonCell)
        //    {
        //        buttonCell.Value = "Delete"; // Set the button text
        //    }
        //}
        private void UserDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Loop through the newly added rows and set button text for the "Delete" column
            for (int rowIndex = e.RowIndex; rowIndex < e.RowIndex + e.RowCount; rowIndex++)
            {
                foreach (DataGridViewCell cell in UserDataGrid.Rows[rowIndex].Cells)
                {
                    if (cell.OwningColumn.Name == "Delete" && cell is DataGridViewButtonCell buttonCell)
                    {
                        buttonCell.Value = "Delete"; // Set the button text
                    }
                }
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (UserDataGrid.Tag != null && int.TryParse(UserDataGrid.Tag.ToString(), out int rowIndex))
            {
                UpdateRowData(rowIndex);
                UserDataGrid.Tag = null; // Clear the stored index
            }
            else
            {
                DisplayDetails();
            }
        }

        private void UpdateRowData(int rowIndex)
        {
            DataGridViewRow row = UserDataGrid.Rows[rowIndex];
            row.Cells["Name"].Value = NameTextBox.Text;
            row.Cells["Age"].Value = AgeTextBox.Text;
            row.Cells["Salary"].Value = SalaryTextBox.Text;

            NameTextBox.Clear();
            AgeTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void DisplayDetails()
        {
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            string salary = SalaryTextBox.Text;

            //string details = $"Name= {name}\n Age= {age}\n Salary={salary}";

            //MessageBox.Show(details, "User Details");

            DataGridViewRow newraw = new DataGridViewRow();

            DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
            nameCell.Value = name;
            newraw.Cells.Add(nameCell);

            DataGridViewTextBoxCell ageCell = new DataGridViewTextBoxCell();
            ageCell.Value = age;
            newraw.Cells.Add(ageCell);

            DataGridViewTextBoxCell salaryCell = new DataGridViewTextBoxCell();
            salaryCell.Value = salary;
            newraw.Cells.Add(salaryCell);

            UserDataGrid.Rows.Add(newraw);

            NameTextBox.Clear();
            AgeTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void UserDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Delete" column
            if (e.ColumnIndex == UserDataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // If user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Remove the selected row from the DataGridView
                    UserDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == UserDataGrid.Columns["Edit"].Index)
            {
                EditRow(e.RowIndex);
            }
        }
        private void EditRow(int rowIndex)
        {
            DataGridViewRow row = UserDataGrid.Rows[rowIndex];
            NameTextBox.Text = row.Cells["Name"].Value.ToString();
            AgeTextBox.Text = row.Cells["Age"].Value.ToString();
            SalaryTextBox.Text = row.Cells["Salary"].Value.ToString();
            // Store the index of the edited row for later reference
            UserDataGrid.Tag = rowIndex;
        }


    }
}