using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class ContractView : Form
    {
        public ContractView()
        {
            InitializeComponent();
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            this.searchTxtbox.Enter += new System.EventHandler(this.searchTxtbox_Enter);
            this.searchTxtbox.Leave += new System.EventHandler(this.searchTxtbox_Leave);
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            this.Load += new System.EventHandler(this.contractView_Load);
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            CrudEmployee f2 = new CrudEmployee();
            f2.Show();
            this.Close();
        }

        static string workingDirectory = Environment.CurrentDirectory;
        public string databaseDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        int rowIndex;
        string name, contact, address, profession, experience, resume;

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchTxtbox.Text = "Search Work";
            searchTxtbox.ForeColor = Color.Gray;
        }

        private void searchTxtbox_Enter(object sender, EventArgs e)
        {
            if (searchTxtbox.Text == "Search Work")
            {
                searchTxtbox.Text = "";
                searchTxtbox.ForeColor = Color.MidnightBlue;
            }
        }

        private void searchTxtbox_Leave(object sender, EventArgs e)
        {
            if (searchTxtbox.Text == "")
            {
                searchTxtbox.Text = "Search Work";
                searchTxtbox.ForeColor = Color.Gray;
            }
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtbox.Text != "" && searchTxtbox.Text != "Search Work")
            {
                clearSearchBtn.Visible = true;
                int i = 0;
                for (; i < dataGridView1.Rows.Count; i++)
                {
                    if (!dataGridView1.Rows[i].Cells[1].Value.ToString().ToLower().Contains(searchTxtbox.Text.ToLower()))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }

            else if (searchTxtbox.Text == "Search Work" || searchTxtbox.Text == "")
            {
                clearSearchBtn.Visible = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
        }

        private void contractView_Load(object sender, EventArgs e)
        {
            string database = databaseDirectory + @"\WindowsFormsApp1\contract\Contract.xlsx";

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(database);
            xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
            xlRange = xlWorksheet.UsedRange;

            try
            {


                if (xlRange.Rows.Count > 0)
                {
                    for (int xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        dataGridView1.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 4].Text,
                            xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text);

                    }

                }

                xlWorkbook.Close();
                xlApp.Quit();

            }

            catch (Exception ex)
            {
                xlWorkbook.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateContract()
        {
            string database = databaseDirectory + @"\WindowsFormsApp1\contract\Contract.xlsx";

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlSheet = xlApp.Workbooks.Open(database);

            Microsoft.Office.Interop.Excel.Worksheet xlWorkbook = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;


            Excel.Range usedRange = xlWorkbook.UsedRange;

            try
            {

                name = xlWorkbook.Cells[rowIndex + 2, 1].Value.ToString();
                address = xlWorkbook.Cells[rowIndex + 2, 2].Value.ToString();
                contact = xlWorkbook.Cells[rowIndex + 2, 3].Value.ToString();
                profession = xlWorkbook.Cells[rowIndex + 2, 4].Value.ToString();
                experience = xlWorkbook.Cells[rowIndex + 2, 5].Value.ToString();
                resume = xlWorkbook.Cells[rowIndex + 2, 6].Value.ToString();

                xlWorkbook.Cells[rowIndex + 2, 1].EntireRow.Delete();

                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();

            }

            catch (Exception ex)
            {
                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "END" && rowIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to end the contract of this person?", "WeHire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        updateContract();

                        string database = databaseDirectory + @"\WindowsFormsApp1\database\Database.xlsx";

                        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                        Microsoft.Office.Interop.Excel.Workbook xlSheet = xlApp.Workbooks.Open(database);

                        Microsoft.Office.Interop.Excel.Worksheet xlWorkbook = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                        Excel.Range usedRange = xlWorkbook.UsedRange;

                        int databaseCount = usedRange.Rows.Count;

                        xlWorkbook.Cells[databaseCount + 1, 1].Value = name;
                        xlWorkbook.Cells[databaseCount + 1, 2].Value = address;
                        xlWorkbook.Cells[databaseCount + 1, 3].Value = contact;
                        xlWorkbook.Cells[databaseCount + 1, 4].Value = profession;
                        xlWorkbook.Cells[databaseCount + 1, 5].Value = experience;
                        xlWorkbook.Cells[databaseCount + 1, 6].Value = resume;


                        xlSheet.Close(true, Type.Missing, Type.Missing);
                        xlApp.Quit();


                        MessageBox.Show("The contract of this person has been ended.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                else
                {
                    MessageBox.Show("Please select the row you want to end the contract", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
            }
        }
    }
}
