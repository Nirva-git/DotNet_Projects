using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_one
{
    internal class Task2
    {

        private DataGridView UserDataGrid; // Private field to store the DataGridView instance
        private Form1 formInstance; // Reference to the Form1 instance

        public Task2(DataGridView userDataGrid, Form1 formInstance)
        {
            this.UserDataGrid = userDataGrid;
            this.formInstance = formInstance;
        }
        

        //private void ExportToCSV_Click(object sender, EventArgs e)
        //{
        //    formInstance.task2Instance.ExportToCsv(); // Call the ExportToCsv method when the button is clicked
        //}

        public void ExportToCsv()
        {
            StringBuilder csvContent = new StringBuilder();

            // Add headers
            foreach (DataGridViewColumn column in UserDataGrid.Columns)
            {
                csvContent.Append(column.HeaderText); // Get the column header text
                csvContent.Append(","); // Add a comma separator
            }
            csvContent.AppendLine(); // Move to the next line after adding headers

            // Add data rows
            foreach (DataGridViewRow row in UserDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csvContent.Append(cell.Value); // Get the cell value
                    csvContent.Append(","); // Add a comma separator
                }
                csvContent.AppendLine(); // Move to the next line after adding a row
            }

            // Save to a CSV file
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string csvFilePath = Path.Combine(documentsPath, "data.csv");
            File.WriteAllText(csvFilePath, csvContent.ToString()); // Write content to file

            MessageBox.Show("Data exported to CSV file.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}
