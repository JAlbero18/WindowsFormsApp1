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
    public partial class CrudEmployee : Form
    {
        public CrudEmployee()
        {
            InitializeComponent();
            this.minimizeBtn1.Click += new System.EventHandler(this.minimizeBtn1_Click);
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            this.searchTxtbox.Enter += new System.EventHandler(this.searchTxtbox_Enter);
            this.searchTxtbox.Leave += new System.EventHandler(this.searchTxtbox_Leave);
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.hireBtn.Click += new System.EventHandler(this.hireBtn_Click);
            this.viewContracts.Click += new System.EventHandler(this.viewContracts_Click);
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            this.importLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.importLabel_LinkClicked);
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            this.addressTxtbox.Enter += new System.EventHandler(this.addressTxtbox_Enter);
            this.addressTxtbox.Leave += new System.EventHandler(this.addressTxtbox_Leave);
            this.contactTxtbox.Enter += new System.EventHandler(this.contactTxtbox_Enter);
            this.contactTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactTxtbox_KeyPress);
            this.contactTxtbox.Leave += new System.EventHandler(this.contactTxtbox_Leave);
            this.professionTxtbox.Enter += new System.EventHandler(this.professionTxtbox_Enter);
            this.professionTxtbox.Leave += new System.EventHandler(this.professionTxtbox_Leave);
            this.experienceTxtbox.Enter += new System.EventHandler(this.experienceTxtbox_Enter);
            this.experienceTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.experienceTxtbox_KeyPress);
            this.experienceTxtbox.Leave += new System.EventHandler(this.experienceTxtbox_Leave);
            this.nameTxtbox.Enter += new System.EventHandler(this.nameTxtbox_Enter);
            this.nameTxtbox.Leave += new System.EventHandler(this.nameTxtbox_Leave);
            this.Load += new System.EventHandler(this.crudEmployee_Load);
        }

        public int rowIndex;
        public bool rowIndexHasValue = false;
        bool add = false;
        bool edit = false;
        bool isSave = true;
        bool isFieldValid = true;
        public bool cancelF6 = false;

        static string workingDirectory = Environment.CurrentDirectory;
        public string databaseDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        private void viewButton()
        {
            if(doneBtn.Visible == false && cancelBtn.Visible == false)
            {
                addBtn.Visible = false;
                editBtn.Visible = false;
                deleteBtn.Visible = false;
                hireBtn.Visible = false;
                doneBtn.Visible = true;
                cancelBtn.Visible = true;

            }
            else
            {
                addBtn.Visible = true;
                editBtn.Visible = true;
                deleteBtn.Visible = true;
                hireBtn.Visible = true;
                doneBtn.Visible = false;
                cancelBtn.Visible = false;
            }
        }

        public void clearTxtbox()
        {
            nameTxtbox.Text = "";
            contactTxtbox.Text = "";
            addressTxtbox.Text = "";
            professionTxtbox.Text = "";
            experienceTxtbox.Text = "";
            resumeTxtbox.Text = "";

        }

        private void labeltxtbox()
        {
            nameTxtbox.ForeColor = Color.Gray;
            contactTxtbox.ForeColor = Color.Gray;
            addressTxtbox.ForeColor = Color.Gray;   
            professionTxtbox.ForeColor = Color.Gray;
            experienceTxtbox.ForeColor = Color.Gray;
            resumeTxtbox.ForeColor = Color.Gray;

            nameTxtbox.Text = "Full Name";
            contactTxtbox.Text = "Contact No.";
            addressTxtbox.Text = "Address";
            professionTxtbox.Text = "Profession";
            experienceTxtbox.Text = "Experience(ex. 1, 2...)";
            resumeTxtbox.Text = "Import Resume...          ";

        }

        private void checkField()
        {
            if (nameTxtbox.Text != "Full Name" && addressTxtbox.Text != "Address" && contactTxtbox.Text != "Contact No."
                && professionTxtbox.Text != "Profession" && experienceTxtbox.Text != "Experience(ex. 1, 2...)" && resumeTxtbox.Text != "Import Resume...          ") 
            {
                isFieldValid = true;
            }

            else
            {
                isFieldValid = false;
            }
        }

        public void addToContract()
        {

        }

        private void minimizeBtn1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSave == false)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes before exit? If not your edit would not be saved to the database.", "WeHire", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            saveBtn_Click(sender, e);
                            RegLog f1 = new RegLog();
                            this.Close();
                            f1.Show();
                        }

                        else if (result == DialogResult.No)
                        {
                            RegLog f1 = new RegLog();
                            this.Close();
                            f1.Show();
                        }

                    }
                }

                else if (isSave == true)
                {
                    RegLog f1 = new RegLog();
                    this.Close();
                    f1.Show();

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            add = true;
            nameTxtbox.ReadOnly = false;
            contactTxtbox.ReadOnly = false;
            addressTxtbox.ReadOnly = false;
            professionTxtbox.ReadOnly = false;
            experienceTxtbox.ReadOnly = false;
            viewButton();
            labeltxtbox();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(rowIndexHasValue == true)
            {
                edit = true;
                isSave = false;
                viewButton();
                nameTxtbox.ReadOnly = false;
                nameTxtbox.ForeColor = Color.MidnightBlue;
                contactTxtbox.ReadOnly = false;
                contactTxtbox.ForeColor = Color.MidnightBlue;
                addressTxtbox.ReadOnly = false;
                professionTxtbox.ReadOnly = false;
                professionTxtbox.ForeColor = Color.MidnightBlue;
                experienceTxtbox.ReadOnly = false;
                experienceTxtbox.ForeColor = Color.MidnightBlue;

            }

            else
            {
                MessageBox.Show("Please select a row to edit.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowIndexHasValue == true)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record? Once you deleted the record you cant undo to save it.", "WeHire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        rowIndex = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        rowIndexHasValue = false;
                        isSave = false;

                        dataGridView1.ClearSelection();
                        clearTxtbox();
                    }

                }

                else
                {
                    MessageBox.Show("Please select a row first.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "VIEW" && rowIndexHasValue == true)
            {
                ViewResume f3 = new ViewResume();
                f3.webBrowser1.Navigate(dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
                f3.Show();
            }

            else
            {
                MessageBox.Show("Please select a row first.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            checkField();

            if(add == true && isFieldValid == true)
            {
                dataGridView1.Rows.Add(nameTxtbox.Text, addressTxtbox.Text, contactTxtbox.Text,
                    professionTxtbox.Text, experienceTxtbox.Text, resumeTxtbox.Text);

                add = false;
                nameTxtbox.ReadOnly = true;
                contactTxtbox.ReadOnly = true;
                addressTxtbox.ReadOnly = true;
                professionTxtbox.ReadOnly = true;
                experienceTxtbox.ReadOnly = true;


                clearTxtbox();
                viewButton();
            }

            else if(isFieldValid == false)
            {
                if(nameTxtbox.Text == "Full Name")
                {
                    emptyLabel1.Visible = true;
                }

                if(addressTxtbox.Text == "Address")
                {
                    emptyLabel2.Visible = true;
                }

                if(contactTxtbox.Text == "Contact No.")
                {
                    emptyLabel3.Visible = true;
                }

                if(professionTxtbox.Text == "Profession")
                {
                    emptyLabel4.Visible = true;
                }

                if(experienceTxtbox.Text == "Experience(ex. 1, 2...)")
                {
                    emptyLabel5.Visible = true;
                }

                if(resumeTxtbox.Text == "Import Resume...          ")
                {
                    emptyLabel6.Visible = true;
                }


                MessageBox.Show("Fill up all fields.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if(edit == true)
            {
                try
                {
                    DataGridViewRow editData = dataGridView1.Rows[rowIndex];
                    editData.Cells[0].Value = nameTxtbox.Text;
                    editData.Cells[1].Value = contactTxtbox.Text;
                    editData.Cells[2].Value = addressTxtbox.Text;
                    editData.Cells[3].Value = professionTxtbox.Text;
                    editData.Cells[4].Value = experienceTxtbox.Text;
                    editData.Cells[5].Value = resumeTxtbox.Text;


                    edit = false;
                    rowIndexHasValue = false;
                    nameTxtbox.ReadOnly = true;
                    contactTxtbox.ReadOnly = true;
                    addressTxtbox.ReadOnly = true;
                    professionTxtbox.ReadOnly = true;
                    experienceTxtbox.ReadOnly = true;

                    dataGridView1.ClearSelection();
                    clearTxtbox();
                    viewButton();

                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            nameTxtbox.ReadOnly = true;
            contactTxtbox.ReadOnly = true;
            addressTxtbox.ReadOnly = true;
            professionTxtbox.ReadOnly = true;
            experienceTxtbox.ReadOnly = true;
            rowIndexHasValue = false;

            emptyLabel1.Visible = false;
            emptyLabel2.Visible = false;
            emptyLabel3.Visible = false;
            emptyLabel4.Visible = false;
            emptyLabel5.Visible = false;
            emptyLabel6.Visible = false;

            dataGridView1.ClearSelection();
            clearTxtbox();
            viewButton();
        }

        private void importLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog resumeLoc = new OpenFileDialog();
            resumeLoc.Filter = "Pdf Files|*.pdf";
            if(resumeLoc.ShowDialog() == DialogResult.OK)
            {
                resumeTxtbox.Text = resumeLoc.FileName;
                emptyLabel6.Visible = false;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && add == false)
                {
                    rowIndex = e.RowIndex;
                    rowIndexHasValue = true;
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    nameTxtbox.Text = row.Cells[0].Value.ToString();
                    addressTxtbox.Text = row.Cells[1].Value.ToString();
                    contactTxtbox.Text = row.Cells[2].Value.ToString();
                    professionTxtbox.Text = row.Cells[3].Value.ToString();
                    experienceTxtbox.Text = row.Cells[4].Value.ToString();
                    resumeTxtbox.Text = row.Cells[5].Value.ToString();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void nameTxtbox_Enter(object sender, EventArgs e)
        {
            if(nameTxtbox.Text == "Full Name")
            {
                nameTxtbox.Text = "";
                nameTxtbox.ForeColor = Color.MidnightBlue;
            }
        }

        private void nameTxtbox_Leave(object sender, EventArgs e)
        {
            if(nameTxtbox.Text == "" && cancelBtn.Visible == true)
            {
                nameTxtbox.Text = "Full Name";
                nameTxtbox.ForeColor = Color.Gray;
                emptyLabel1.Visible = true;
                emptyLabel1.BackColor = Color.White;
            }

            else if(nameTxtbox.Text != "")
            {
                emptyLabel1.Visible = false;
            }

        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            if(searchTxtbox.Text != "" && searchTxtbox.Text != "Search Profession")
            {
                clearSearch.Visible = true;
                int i = 0;
                for( ; i < dataGridView1.Rows.Count; i++)
                {
                    if (!dataGridView1.Rows[i].Cells[3].Value.ToString().ToLower().Contains(searchTxtbox.Text.ToLower()))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }

            else if (searchTxtbox.Text == "Search Profession" || searchTxtbox.Text == "")
            {
                clearSearch.Visible = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }

        }

        private void addressTxtbox_Enter(object sender, EventArgs e)
        {
            if (addressTxtbox.Text == "Address")
            {
                addressTxtbox.Text = "";
                addressTxtbox.ForeColor = Color.MidnightBlue;
            }

        }

        private void contactTxtbox_Enter(object sender, EventArgs e)
        {
            if (contactTxtbox.Text == "Contact No.")
            {
                contactTxtbox.Text = "";
               contactTxtbox.ForeColor = Color.MidnightBlue;

            }

        }

        private void professionTxtbox_Enter(object sender, EventArgs e)
        {
            if (professionTxtbox.Text == "Profession")
            {
                professionTxtbox.Text = "";
                professionTxtbox.ForeColor = Color.MidnightBlue;
            }

        }

        private void experienceTxtbox_Enter(object sender, EventArgs e)
        {
            if (experienceTxtbox.Text == "Experience(ex. 1, 2...)")
            {
                experienceTxtbox.Text = "";
                experienceTxtbox.ForeColor = Color.MidnightBlue;
            }
        }

        private void addressTxtbox_Leave(object sender, EventArgs e)
        {
            if (addressTxtbox.Text == "" && cancelBtn.Visible == true)
            {
                addressTxtbox.Text = "Address";
                addressTxtbox.ForeColor = Color.Gray;
                emptyLabel2.Visible = true;
                emptyLabel2.BackColor = Color.White;
            }
            else if (addressTxtbox.Text != "")
            {
                emptyLabel2.Visible = false;
            }

        }

        private void contactTxtbox_Leave(object sender, EventArgs e)
        {
            if (contactTxtbox.Text == "" && cancelBtn.Visible == true)
            {
                contactTxtbox.Text = "Contact No.";
                contactTxtbox.ForeColor = Color.Gray;
                emptyLabel3.Visible = true;
            }
            else if (contactTxtbox.Text != "")
            {
                emptyLabel3.Visible = false;
            }

        }

        private void professionTxtbox_Leave(object sender, EventArgs e)
        {
            if (professionTxtbox.Text == "" && cancelBtn.Visible == true)
            {
                professionTxtbox.Text = "Profession";
                professionTxtbox.ForeColor = Color.Gray;
                emptyLabel4.Visible = true;
                emptyLabel4.BackColor = Color.White;
            }

            else if (professionTxtbox.Text != "")
            {
                emptyLabel4.Visible = false;
            }

        }

        private void experienceTxtbox_Leave(object sender, EventArgs e)
        {
            if (experienceTxtbox.Text == "" && cancelBtn.Visible == true)
            {
                experienceTxtbox.Text = "Experience(ex. 1, 2...)";
                experienceTxtbox.ForeColor = Color.Gray;
                emptyLabel5.Visible = true;
                emptyLabel5.BackColor = Color.White;
            }
            else if (experienceTxtbox.Text != "")
            {
                emptyLabel5.Visible = false;
            }

        }

        private void searchTxtbox_Enter(object sender, EventArgs e)
        {
            if (searchTxtbox.Text == "Search Profession")
            {
                searchTxtbox.Text = "";
                searchTxtbox.ForeColor = Color.MidnightBlue;
            }

        }

        private void searchTxtbox_Leave(object sender, EventArgs e)
        {
            if (searchTxtbox.Text == "")
            {
                searchTxtbox.Text = "Search Profession";
                searchTxtbox.ForeColor = Color.Gray;
            }

        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            searchTxtbox.Text = "Search Profession";
            searchTxtbox.ForeColor = Color.Gray;
        }

        public void saveBtn_Click(object sender, EventArgs e)
        {

            string database = databaseDirectory + @"\WindowsFormsApp1\database\Database.xlsx";

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlSheet = xlApp.Workbooks.Open(database);

            Microsoft.Office.Interop.Excel.Worksheet xlWorkbook = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            try
            {
                isSave = true;

                int dgv = 0;
                int i = 1;

                Excel.Range usedRange = xlWorkbook.UsedRange;

                int databaseCount = usedRange.Rows.Count;
                int datagridCount = dataGridView1.Rows.Count;

                for (; i <= datagridCount; i++)
                {
                    xlWorkbook.Cells[i + 1, 1].Value = dataGridView1.Rows[dgv].Cells[0].Value.ToString();
                    xlWorkbook.Cells[i + 1, 2].Value = dataGridView1.Rows[dgv].Cells[1].Value.ToString();
                    xlWorkbook.Cells[i + 1, 3].Value = dataGridView1.Rows[dgv].Cells[2].Value.ToString();
                    xlWorkbook.Cells[i + 1, 4].Value = dataGridView1.Rows[dgv].Cells[3].Value.ToString();
                    xlWorkbook.Cells[i + 1, 5].Value = dataGridView1.Rows[dgv].Cells[4].Value.ToString();
                    xlWorkbook.Cells[i + 1, 6].Value = dataGridView1.Rows[dgv].Cells[5].Value.ToString();

                    dgv++;
                }

                if (datagridCount != databaseCount)
                {
                    while (datagridCount <= databaseCount)
                    {
                        xlWorkbook.Cells[i + 1, 1].Value = "";
                        xlWorkbook.Cells[i + 1, 2].Value = "";
                        xlWorkbook.Cells[i + 1, 3].Value = "";
                        xlWorkbook.Cells[i + 1, 4].Value = "";
                        xlWorkbook.Cells[i + 1, 5].Value = "";
                        xlWorkbook.Cells[i + 1, 6].Value = "";

                        i++;
                        datagridCount++;
                    }

                }

                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();

                MessageBox.Show("Updates saved.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch(Exception ex)
            {
                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void contactTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void experienceTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void viewContracts_Click(object sender, EventArgs e)
        {
            ContractView f5 = new ContractView();
            f5.Show();
            this.Close();
        }

        private void hireBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowIndexHasValue == true)
                {
                    DialogResult result = MessageBox.Show("Do you want to hire this person?", "WeHire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        ContractCompYears f6 = new ContractCompYears();
                        f6.name = nameTxtbox.Text;
                        f6.contact = contactTxtbox.Text;
                        f6.address = addressTxtbox.Text;
                        f6.profession = professionTxtbox.Text;
                        f6.experience = experienceTxtbox.Text;
                        f6.resume = resumeTxtbox.Text;
                        f6.ShowDialog();

                        rowIndex = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        saveBtn_Click(sender, e);
                    }

                }

                else
                {
                    MessageBox.Show("Please select a row first.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crudEmployee_Load(object sender, EventArgs e)
        {
            string database = databaseDirectory + @"\WindowsFormsApp1\database\Database.xlsx";

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
                        dataGridView1.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text,
                            xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text,
                            xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text);

                    }

                }

                xlWorkbook.Close();
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);
            }

            catch (Exception ex)
            {
                xlWorkbook.Close();
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
