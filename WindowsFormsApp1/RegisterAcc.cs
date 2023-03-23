using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class RegisterAcc : Form
    {
        public RegisterAcc()
        {
            InitializeComponent();
            passwordTxtbox.PasswordChar = '●';
            confirmPassTxtbox.PasswordChar = '●';
            this.confirmPassTxtbox.TextChanged += new System.EventHandler(this.confirmPassTxtbox_TextChanged);
            this.confirmPassTxtbox.Leave += new System.EventHandler(this.confirmPassTxtbox_Leave);
            this.passwordTxtbox.TextChanged += new System.EventHandler(this.passwordTxtbox4_TextChanged);
            this.passwordTxtbox.Leave += new System.EventHandler(this.passwordTxtbox_Leave);
            this.usernameTxtbox.Leave += new System.EventHandler(this.usernameTxtbox_Leave);
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
        }

        public string accountLocation;
        public bool register = false;
        public bool forgotPass = false;
        public bool checkField = false;
        private void checkFieldContent()
        {
            if(usernameTxtbox.Text == "")
            {
                emptyLabel1.Visible = true;
                checkField = true;
            }

            if(passwordTxtbox.Text == "")
            {
                emptyLabel2.Visible = true;
                checkField = true;
            }

            if(confirmPassTxtbox.Text == "")
            {
                emptyLabel3.Visible = true;
                checkField = true;
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                checkFieldContent();

                if(confirmPassTxtbox.Text == passwordTxtbox.Text && confirmPassTxtbox.Text != "" && passwordTxtbox.Text != "" 
                    && usernameTxtbox.Text != "" && passwordTxtbox.Text.Length >= 8)
                {
                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbook xlSheet = xlApp.Workbooks.Open(accountLocation);

                    Microsoft.Office.Interop.Excel.Worksheet xlWorkbook = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                    Excel.Range usedRange = xlWorkbook.UsedRange;

                    int databaseCount = usedRange.Rows.Count;
                    bool exist = false;

                    if (register == true)
                    {
                        for (int i = 2; i <= databaseCount; i++)
                        {
                            if (xlWorkbook.Cells[i, 1].Text == usernameTxtbox.Text)
                            {
                                exist = true;
                            }
                        }

                        if (exist != true)
                        {
                            xlWorkbook.Cells[databaseCount + 1, 1].Value = usernameTxtbox.Text;
                            xlWorkbook.Cells[databaseCount + 1, 2].Value = passwordTxtbox.Text;

                            register = false;
                            MessageBox.Show("Account saved.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }

                        else if(exist == true)
                        {
                            MessageBox.Show("Username already exist.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        xlSheet.Close(true, Type.Missing, Type.Missing);
                        xlApp.Quit();
                        this.Close();
                    }

                    else if(forgotPass == true && usernameTxtbox.Text != "")
                    {
                        for (int i = 2; i <= databaseCount; i++)
                        {
                            if (xlWorkbook.Cells[i, 1].Text == usernameTxtbox.Text)
                            {
                                xlWorkbook.Cells[i, 2].Value = passwordTxtbox.Text;
                                forgotPass = false;
                                exist = true;
                            }
                        }

                        if (exist == true)
                        {
                            MessageBox.Show("Account updated.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else if (exist == false)
                        {

                            MessageBox.Show("Username doesn't exist.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        xlSheet.Close(true, Type.Missing, Type.Missing);
                        xlApp.Quit();
                        this.Close();

                    }
                }

                else if(usernameTxtbox.Text == "" || passwordTxtbox.Text == "" || confirmPassTxtbox.Text == "")
                {
                    MessageBox.Show("Fill up all fields.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if(confirmPassTxtbox.Text != passwordTxtbox.Text)
                {
                    MessageBox.Show("Password doesn't match.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernameTxtbox_Leave(object sender, EventArgs e)
        {
            if(usernameTxtbox.Text != "")
            {
                emptyLabel1.Visible = false;
            }

            else if(usernameTxtbox.Text == "")
            {
                emptyLabel1.Visible = true;
            }
        }

        private void passwordTxtbox_Leave(object sender, EventArgs e)
        {
            if(passwordTxtbox.Text != "")
            {
                emptyLabel2.Visible = false;
            }

            else if(passwordTxtbox.Text == "")
            {
                emptyLabel2.Visible = true;
            }
        }

        private void confirmPassTxtbox_Leave(object sender, EventArgs e)
        {
            if(confirmPassTxtbox.Text != "")
            {
                emptyLabel3.Visible = false;
            }

            else if(confirmPassTxtbox.Text == "")
            {
                emptyLabel3.Visible = true;
            }
        }

        private void confirmPassTxtbox_TextChanged(object sender, EventArgs e)
        {
            if(confirmPassTxtbox.Text != passwordTxtbox.Text)
            {
                emptyLabel3.Visible = true;
                confirmPassTxtbox.ForeColor = Color.Red;
            }

            else if(confirmPassTxtbox.Text == passwordTxtbox.Text)
            {
                emptyLabel3.Visible = false;
                confirmPassTxtbox.ForeColor = Color.MidnightBlue;
            }
        }

        private void passwordTxtbox4_TextChanged(object sender, EventArgs e)
        {

            if (passwordTxtbox.Text.Length < 8)
            {
                passwordTxtbox.ForeColor = Color.Red;
                confirmPassTxtbox.ReadOnly = true;
                passLengthLabel.Visible = true;
            }

            else if (passwordTxtbox.Text.Length >= 8)
            {
                passwordTxtbox.ForeColor = Color.MidnightBlue;
                confirmPassTxtbox.ReadOnly = false;
                passLengthLabel.Visible = false;
            }
        }

    }
}
