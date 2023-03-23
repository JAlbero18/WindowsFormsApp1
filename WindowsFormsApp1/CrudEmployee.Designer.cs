namespace WindowsFormsApp1
{
    partial class CrudEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimizeBtn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIEW = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hireBtn = new System.Windows.Forms.Button();
            this.viewContracts = new System.Windows.Forms.Button();
            this.emptyLabel6 = new System.Windows.Forms.Label();
            this.emptyLabel5 = new System.Windows.Forms.Label();
            this.emptyLabel4 = new System.Windows.Forms.Label();
            this.emptyLabel3 = new System.Windows.Forms.Label();
            this.emptyLabel2 = new System.Windows.Forms.Label();
            this.emptyLabel1 = new System.Windows.Forms.Label();
            this.clearSearch = new System.Windows.Forms.Button();
            this.importLabel = new System.Windows.Forms.LinkLabel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.contactTxtbox = new System.Windows.Forms.TextBox();
            this.professionTxtbox = new System.Windows.Forms.TextBox();
            this.experienceTxtbox = new System.Windows.Forms.TextBox();
            this.resumeTxtbox = new System.Windows.Forms.TextBox();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeBtn1
            // 
            this.minimizeBtn1.FlatAppearance.BorderSize = 0;
            this.minimizeBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.minimizeBtn1.Location = new System.Drawing.Point(1104, 0);
            this.minimizeBtn1.Name = "minimizeBtn1";
            this.minimizeBtn1.Size = new System.Drawing.Size(41, 35);
            this.minimizeBtn1.TabIndex = 2;
            this.minimizeBtn1.TabStop = false;
            this.minimizeBtn1.Text = "__";
            this.minimizeBtn1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 67);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "WeHire";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.Location = new System.Drawing.Point(1022, 17);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(111, 38);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "LOG OUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbox.ForeColor = System.Drawing.Color.Gray;
            this.searchTxtbox.Location = new System.Drawing.Point(14, 165);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(177, 27);
            this.searchTxtbox.TabIndex = 5;
            this.searchTxtbox.TabStop = false;
            this.searchTxtbox.Text = "Search Profession";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(1024, 154);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 38);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Profession,
            this.Column5,
            this.Column6,
            this.VIEW});
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 334);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Address";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 157;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contact No.";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Profession
            // 
            this.Profession.HeaderText = "Profession";
            this.Profession.MinimumWidth = 8;
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            this.Profession.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Experience(Years)";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Resume";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // VIEW
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.VIEW.DefaultCellStyle = dataGridViewCellStyle1;
            this.VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VIEW.HeaderText = "View Resume";
            this.VIEW.MinimumWidth = 8;
            this.VIEW.Name = "VIEW";
            this.VIEW.ReadOnly = true;
            this.VIEW.Text = "VIEW";
            this.VIEW.UseColumnTextForButtonValue = true;
            this.VIEW.Width = 150;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(1024, 598);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 38);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(907, 598);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 38);
            this.editBtn.TabIndex = 9;
            this.editBtn.TabStop = false;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(790, 598);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 38);
            this.addBtn.TabIndex = 10;
            this.addBtn.TabStop = false;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hireBtn);
            this.panel1.Controls.Add(this.viewContracts);
            this.panel1.Controls.Add(this.emptyLabel6);
            this.panel1.Controls.Add(this.emptyLabel5);
            this.panel1.Controls.Add(this.emptyLabel4);
            this.panel1.Controls.Add(this.emptyLabel3);
            this.panel1.Controls.Add(this.emptyLabel2);
            this.panel1.Controls.Add(this.emptyLabel1);
            this.panel1.Controls.Add(this.clearSearch);
            this.panel1.Controls.Add(this.importLabel);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.doneBtn);
            this.panel1.Controls.Add(this.addressTxtbox);
            this.panel1.Controls.Add(this.contactTxtbox);
            this.panel1.Controls.Add(this.professionTxtbox);
            this.panel1.Controls.Add(this.experienceTxtbox);
            this.panel1.Controls.Add(this.resumeTxtbox);
            this.panel1.Controls.Add(this.nameTxtbox);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.searchTxtbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.minimizeBtn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 700);
            this.panel1.TabIndex = 3;
            // 
            // hireBtn
            // 
            this.hireBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.hireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireBtn.ForeColor = System.Drawing.Color.White;
            this.hireBtn.Location = new System.Drawing.Point(673, 598);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(111, 38);
            this.hireBtn.TabIndex = 29;
            this.hireBtn.TabStop = false;
            this.hireBtn.Text = "HIRE";
            this.hireBtn.UseVisualStyleBackColor = false;
            // 
            // viewContracts
            // 
            this.viewContracts.BackColor = System.Drawing.Color.MidnightBlue;
            this.viewContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewContracts.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewContracts.ForeColor = System.Drawing.Color.White;
            this.viewContracts.Location = new System.Drawing.Point(823, 154);
            this.viewContracts.Name = "viewContracts";
            this.viewContracts.Size = new System.Drawing.Size(195, 38);
            this.viewContracts.TabIndex = 28;
            this.viewContracts.TabStop = false;
            this.viewContracts.Text = "VIEW CONTRACTS";
            this.viewContracts.UseVisualStyleBackColor = false;
            // 
            // emptyLabel6
            // 
            this.emptyLabel6.AutoSize = true;
            this.emptyLabel6.BackColor = System.Drawing.Color.White;
            this.emptyLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel6.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel6.Location = new System.Drawing.Point(1089, 561);
            this.emptyLabel6.Name = "emptyLabel6";
            this.emptyLabel6.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel6.TabIndex = 27;
            this.emptyLabel6.Text = "!";
            this.emptyLabel6.Visible = false;
            // 
            // emptyLabel5
            // 
            this.emptyLabel5.AutoSize = true;
            this.emptyLabel5.BackColor = System.Drawing.Color.White;
            this.emptyLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel5.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel5.Location = new System.Drawing.Point(934, 561);
            this.emptyLabel5.Name = "emptyLabel5";
            this.emptyLabel5.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel5.TabIndex = 26;
            this.emptyLabel5.Text = "!";
            this.emptyLabel5.Visible = false;
            // 
            // emptyLabel4
            // 
            this.emptyLabel4.AutoSize = true;
            this.emptyLabel4.BackColor = System.Drawing.Color.White;
            this.emptyLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel4.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel4.Location = new System.Drawing.Point(751, 561);
            this.emptyLabel4.Name = "emptyLabel4";
            this.emptyLabel4.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel4.TabIndex = 25;
            this.emptyLabel4.Text = "!";
            this.emptyLabel4.Visible = false;
            // 
            // emptyLabel3
            // 
            this.emptyLabel3.AutoSize = true;
            this.emptyLabel3.BackColor = System.Drawing.Color.White;
            this.emptyLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel3.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel3.Location = new System.Drawing.Point(568, 562);
            this.emptyLabel3.Name = "emptyLabel3";
            this.emptyLabel3.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel3.TabIndex = 24;
            this.emptyLabel3.Text = "!";
            this.emptyLabel3.Visible = false;
            // 
            // emptyLabel2
            // 
            this.emptyLabel2.AutoSize = true;
            this.emptyLabel2.BackColor = System.Drawing.Color.White;
            this.emptyLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel2.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel2.Location = new System.Drawing.Point(385, 562);
            this.emptyLabel2.Name = "emptyLabel2";
            this.emptyLabel2.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel2.TabIndex = 23;
            this.emptyLabel2.Text = "!";
            this.emptyLabel2.Visible = false;
            // 
            // emptyLabel1
            // 
            this.emptyLabel1.AutoSize = true;
            this.emptyLabel1.BackColor = System.Drawing.Color.White;
            this.emptyLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel1.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel1.Location = new System.Drawing.Point(173, 562);
            this.emptyLabel1.Name = "emptyLabel1";
            this.emptyLabel1.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel1.TabIndex = 22;
            this.emptyLabel1.Text = "!";
            this.emptyLabel1.Visible = false;
            // 
            // clearSearch
            // 
            this.clearSearch.BackColor = System.Drawing.Color.White;
            this.clearSearch.FlatAppearance.BorderSize = 0;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearch.Font = new System.Drawing.Font("Century Gothic", 5F);
            this.clearSearch.Location = new System.Drawing.Point(167, 166);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(23, 28);
            this.clearSearch.TabIndex = 20;
            this.clearSearch.TabStop = false;
            this.clearSearch.Text = "x";
            this.clearSearch.UseVisualStyleBackColor = false;
            this.clearSearch.Visible = false;
            // 
            // importLabel
            // 
            this.importLabel.AutoSize = true;
            this.importLabel.BackColor = System.Drawing.SystemColors.Control;
            this.importLabel.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.importLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importLabel.ForeColor = System.Drawing.Color.Gray;
            this.importLabel.LinkColor = System.Drawing.Color.Gray;
            this.importLabel.Location = new System.Drawing.Point(1110, 562);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(22, 21);
            this.importLabel.TabIndex = 19;
            this.importLabel.TabStop = true;
            this.importLabel.Text = "...";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cancelBtn.Location = new System.Drawing.Point(907, 598);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 38);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(790, 598);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(111, 38);
            this.doneBtn.TabIndex = 17;
            this.doneBtn.TabStop = false;
            this.doneBtn.Text = "DONE";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Visible = false;
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addressTxtbox.Location = new System.Drawing.Point(195, 559);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.ReadOnly = true;
            this.addressTxtbox.Size = new System.Drawing.Size(206, 27);
            this.addressTxtbox.TabIndex = 16;
            this.addressTxtbox.TabStop = false;
            // 
            // contactTxtbox
            // 
            this.contactTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.contactTxtbox.Location = new System.Drawing.Point(407, 559);
            this.contactTxtbox.MaxLength = 9;
            this.contactTxtbox.Name = "contactTxtbox";
            this.contactTxtbox.ReadOnly = true;
            this.contactTxtbox.Size = new System.Drawing.Size(177, 27);
            this.contactTxtbox.TabIndex = 15;
            this.contactTxtbox.TabStop = false;
            // 
            // professionTxtbox
            // 
            this.professionTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professionTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.professionTxtbox.Location = new System.Drawing.Point(590, 559);
            this.professionTxtbox.MaxLength = 9;
            this.professionTxtbox.Name = "professionTxtbox";
            this.professionTxtbox.ReadOnly = true;
            this.professionTxtbox.Size = new System.Drawing.Size(177, 27);
            this.professionTxtbox.TabIndex = 14;
            this.professionTxtbox.TabStop = false;
            // 
            // experienceTxtbox
            // 
            this.experienceTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienceTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.experienceTxtbox.Location = new System.Drawing.Point(773, 559);
            this.experienceTxtbox.Name = "experienceTxtbox";
            this.experienceTxtbox.ReadOnly = true;
            this.experienceTxtbox.Size = new System.Drawing.Size(177, 27);
            this.experienceTxtbox.TabIndex = 13;
            this.experienceTxtbox.TabStop = false;
            // 
            // resumeTxtbox
            // 
            this.resumeTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.resumeTxtbox.Location = new System.Drawing.Point(956, 559);
            this.resumeTxtbox.Name = "resumeTxtbox";
            this.resumeTxtbox.ReadOnly = true;
            this.resumeTxtbox.Size = new System.Drawing.Size(177, 27);
            this.resumeTxtbox.TabIndex = 12;
            this.resumeTxtbox.TabStop = false;
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nameTxtbox.Location = new System.Drawing.Point(12, 559);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.ReadOnly = true;
            this.nameTxtbox.Size = new System.Drawing.Size(177, 27);
            this.nameTxtbox.TabIndex = 11;
            this.nameTxtbox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // crudEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crudEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        public System.Windows.Forms.TextBox searchTxtbox;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button doneBtn;
        public System.Windows.Forms.TextBox addressTxtbox;
        public System.Windows.Forms.TextBox contactTxtbox;
        public System.Windows.Forms.TextBox professionTxtbox;
        public System.Windows.Forms.TextBox experienceTxtbox;
        public System.Windows.Forms.TextBox resumeTxtbox;
        public System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.LinkLabel importLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn VIEW;
        public System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.Label emptyLabel1;
        private System.Windows.Forms.Label emptyLabel6;
        private System.Windows.Forms.Label emptyLabel5;
        private System.Windows.Forms.Label emptyLabel4;
        private System.Windows.Forms.Label emptyLabel3;
        private System.Windows.Forms.Label emptyLabel2;
        private System.Windows.Forms.Button viewContracts;
        private System.Windows.Forms.Button hireBtn;
        public System.Windows.Forms.Button saveBtn;
    }
}