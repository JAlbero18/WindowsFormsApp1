namespace WindowsFormsApp1
{
    partial class RegisterAcc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passLengthLabel = new System.Windows.Forms.Label();
            this.emptyLabel3 = new System.Windows.Forms.Label();
            this.emptyLabel2 = new System.Windows.Forms.Label();
            this.emptyLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassTxtbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passregLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passLengthLabel);
            this.panel1.Controls.Add(this.emptyLabel3);
            this.panel1.Controls.Add(this.emptyLabel2);
            this.panel1.Controls.Add(this.emptyLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.confirmPassTxtbox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordTxtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.usernameTxtbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.doneBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 474);
            this.panel1.TabIndex = 0;
            // 
            // passLengthLabel
            // 
            this.passLengthLabel.AutoSize = true;
            this.passLengthLabel.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.passLengthLabel.ForeColor = System.Drawing.Color.Red;
            this.passLengthLabel.Location = new System.Drawing.Point(117, 176);
            this.passLengthLabel.Name = "passLengthLabel";
            this.passLengthLabel.Size = new System.Drawing.Size(161, 19);
            this.passLengthLabel.TabIndex = 26;
            this.passLengthLabel.Text = "Requires 8 characters!";
            this.passLengthLabel.Visible = false;
            // 
            // emptyLabel3
            // 
            this.emptyLabel3.AutoSize = true;
            this.emptyLabel3.BackColor = System.Drawing.Color.White;
            this.emptyLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel3.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel3.Location = new System.Drawing.Point(385, 274);
            this.emptyLabel3.Name = "emptyLabel3";
            this.emptyLabel3.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel3.TabIndex = 25;
            this.emptyLabel3.Text = "!";
            this.emptyLabel3.Visible = false;
            // 
            // emptyLabel2
            // 
            this.emptyLabel2.AutoSize = true;
            this.emptyLabel2.BackColor = System.Drawing.Color.White;
            this.emptyLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel2.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel2.Location = new System.Drawing.Point(385, 201);
            this.emptyLabel2.Name = "emptyLabel2";
            this.emptyLabel2.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel2.TabIndex = 24;
            this.emptyLabel2.Text = "!";
            this.emptyLabel2.Visible = false;
            // 
            // emptyLabel1
            // 
            this.emptyLabel1.AutoSize = true;
            this.emptyLabel1.BackColor = System.Drawing.Color.White;
            this.emptyLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel1.ForeColor = System.Drawing.Color.Red;
            this.emptyLabel1.Location = new System.Drawing.Point(384, 130);
            this.emptyLabel1.Name = "emptyLabel1";
            this.emptyLabel1.Size = new System.Drawing.Size(15, 22);
            this.emptyLabel1.TabIndex = 23;
            this.emptyLabel1.Text = "!";
            this.emptyLabel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm password:";
            // 
            // confirmPassTxtbox
            // 
            this.confirmPassTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.confirmPassTxtbox.Location = new System.Drawing.Point(105, 271);
            this.confirmPassTxtbox.Name = "confirmPassTxtbox";
            this.confirmPassTxtbox.ReadOnly = true;
            this.confirmPassTxtbox.Size = new System.Drawing.Size(296, 27);
            this.confirmPassTxtbox.TabIndex = 19;
            this.confirmPassTxtbox.TabStop = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.passwordLabel.Location = new System.Drawing.Point(12, 168);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(108, 23);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.passwordTxtbox.Location = new System.Drawing.Point(105, 198);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(296, 27);
            this.passwordTxtbox.TabIndex = 17;
            this.passwordTxtbox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username:";
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.usernameTxtbox.Location = new System.Drawing.Point(105, 127);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(296, 27);
            this.usernameTxtbox.TabIndex = 15;
            this.usernameTxtbox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.passregLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 67);
            this.panel2.TabIndex = 14;
            // 
            // passregLabel
            // 
            this.passregLabel.AutoSize = true;
            this.passregLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passregLabel.ForeColor = System.Drawing.Color.White;
            this.passregLabel.Location = new System.Drawing.Point(100, 3);
            this.passregLabel.Name = "passregLabel";
            this.passregLabel.Size = new System.Drawing.Size(228, 56);
            this.passregLabel.TabIndex = 5;
            this.passregLabel.Text = "REGISTER";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cancelBtn.Location = new System.Drawing.Point(215, 424);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 38);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doneBtn.Location = new System.Drawing.Point(98, 424);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(111, 38);
            this.doneBtn.TabIndex = 12;
            this.doneBtn.Text = "DONE";
            this.doneBtn.UseVisualStyleBackColor = false;
            // 
            // registerAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 474);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox confirmPassTxtbox;
        public System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emptyLabel3;
        private System.Windows.Forms.Label emptyLabel2;
        private System.Windows.Forms.Label emptyLabel1;
        public System.Windows.Forms.Label passregLabel;
        public System.Windows.Forms.Label passLengthLabel;
    }
}