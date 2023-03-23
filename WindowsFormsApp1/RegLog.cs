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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class RegLog : Form
    {
        public RegLog()
        {
            InitializeComponent();
            passwordTxtbox.PasswordChar = '●';

            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.forgotPasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLabel_LinkClicked);
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.passwordTxtbox.Click += new System.EventHandler(this.passwordTxtbox_Click);
            this.usernameTxtbox.Click += new System.EventHandler(this.usernameTxtbox_Click);
            this.usernameTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTxtbox_KeyDown);
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
        }

        bool accountExist = false;
        bool userpassNotMatch = false;

        //EMPOLOYEE DATABASE DIRECTORY
        static string workingDirectory = Environment.CurrentDirectory;
        string databaseDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        private void checkAccount()
        {
            string accountLocation = databaseDirectory + @"\WindowsFormsApp1\account\Account.xlsx";
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlSheet = xlApp.Workbooks.Open(accountLocation);

            Microsoft.Office.Interop.Excel.Worksheet xlWorkbook = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            try
            {
                Excel.Range usedRange = xlWorkbook.UsedRange;

                int databaseCount = usedRange.Rows.Count;

                for (int i = 2; i <= databaseCount; i++)
                {
                    if (xlWorkbook.Cells[i, 1].Text == usernameTxtbox.Text && xlWorkbook.Cells[i, 2].Text == passwordTxtbox.Text)
                    {
                        accountExist = true;
                    }

                    else if (xlWorkbook.Cells[i, 1].Text == usernameTxtbox.Text && xlWorkbook.Cells[i, 2].Text != passwordTxtbox.Text)
                    {
                        userpassNotMatch = true;
                    }
                }


                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();

            }

            catch(Exception ex)
            {
                xlSheet.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void usernameTxtbox_Click(object sender, EventArgs e)
        {
            usernameTxtbox.BackColor = Color.White;
            panel3.BackColor = Color.White;
            passwordTxtbox.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void passwordTxtbox_Click(object sender, EventArgs e)
        {
            passwordTxtbox.BackColor = Color.White;
            panel4.BackColor = Color.White;
            usernameTxtbox.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            checkAccount();

            if (accountExist == true && userpassNotMatch == false)
            {
                CrudEmployee f2 = new CrudEmployee();
                MessageBox.Show("You are logged in.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                f2.Show();

            }

            if (accountExist == false && userpassNotMatch == false)
            {
                MessageBox.Show("Account doesn't exist.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (accountExist == false && userpassNotMatch == true)
            {
                MessageBox.Show("Password incorrect.", "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void usernameTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                passwordTxtbox.BackColor = Color.White;
                panel4.BackColor = Color.White;
                usernameTxtbox.BackColor = SystemColors.Control;
                panel3.BackColor = SystemColors.Control;
                SendKeys.Send("{TAB}");
            }
        }

        private void forgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterAcc f4 = new RegisterAcc();
            f4.passregLabel.Text = "NEW PASSWORD";
            f4.passregLabel.Location = new System.Drawing.Point(10, 3);
            f4.passwordLabel.Text = "New password:";

            f4.forgotPass = true;
            f4.accountLocation = databaseDirectory + @"\WindowsFormsApp1\account\Account.xlsx";
            f4.ShowDialog();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterAcc f4 = new RegisterAcc();
                f4.register = true;
                f4.accountLocation = databaseDirectory + @"\WindowsFormsApp1\account\Account.xlsx";
                f4.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WeHire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
