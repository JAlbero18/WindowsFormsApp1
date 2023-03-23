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
    public partial class ContractCompYears : Form
    {
        public ContractCompYears()
        {
            InitializeComponent();

            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            this.contractTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractTxtbox_KeyPress);
        }

        public string name, contact, address, profession, experience, resume;


        public int rowIndex;

        static string workingDirectory = Environment.CurrentDirectory;
        public string databaseDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        private void contractTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            CrudEmployee f2 = new CrudEmployee();
            string database = databaseDirectory + @"\WindowsFormsApp1\contract\Contract.xlsx";

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlSheet = xlApp.Workbooks.Open(database);

            Microsoft.Office.Interop.Excel.Worksheet xlWorkbook = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            try
            {
                if (companyTxtbox.Text != "" && contractTxtbox.Text != "")
                {

                    Excel.Range usedRange = xlWorkbook.UsedRange;

                    int databaseCount = usedRange.Rows.Count;

                    if (databaseCount >= 1)
                    {
                        xlWorkbook.Cells[databaseCount + 1, 1].Value = name;
                        xlWorkbook.Cells[databaseCount + 1, 2].Value = address;
                        xlWorkbook.Cells[databaseCount + 1, 3].Value = contact;
                        xlWorkbook.Cells[databaseCount + 1, 4].Value = profession;
                        xlWorkbook.Cells[databaseCount + 1, 5].Value = experience;
                        xlWorkbook.Cells[databaseCount + 1, 6].Value = resume;
                        xlWorkbook.Cells[databaseCount + 1, 7].Value = companyTxtbox.Text;
                        xlWorkbook.Cells[databaseCount + 1, 8].Value = contractTxtbox.Text;
                    }

                    else
                    {
                        xlWorkbook.Cells[2, 1].Value = name;
                        xlWorkbook.Cells[2, 2].Value = address;
                        xlWorkbook.Cells[2, 3].Value = contact;
                        xlWorkbook.Cells[2, 4].Value = profession;
                        xlWorkbook.Cells[2, 5].Value = experience;
                        xlWorkbook.Cells[2, 6].Value = resume;
                        xlWorkbook.Cells[2, 7].Value = companyTxtbox.Text;
                        xlWorkbook.Cells[2, 8].Value = contractTxtbox.Text;
                    }


                    xlSheet.Close(true, Type.Missing, Type.Missing);
                    xlApp.Quit();

                    MessageBox.Show("This person has been hired", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
