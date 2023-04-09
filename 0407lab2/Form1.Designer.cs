namespace _0407lab2
{
    partial class Form1
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.TxtImport = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.TxtExport = new System.Windows.Forms.Button();
            this.XmlExport = new System.Windows.Forms.Button();
            this.XmlImport = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.Info;
            this.FirstName.Location = new System.Drawing.Point(41, 68);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(162, 20);
            this.FirstName.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.Info;
            this.Email.Location = new System.Drawing.Point(41, 204);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(162, 20);
            this.Email.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.Info;
            this.LastName.Location = new System.Drawing.Point(41, 134);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(162, 20);
            this.LastName.TabIndex = 2;
            // 
            // TxtImport
            // 
            this.TxtImport.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtImport.Location = new System.Drawing.Point(288, 359);
            this.TxtImport.Name = "TxtImport";
            this.TxtImport.Size = new System.Drawing.Size(158, 23);
            this.TxtImport.TabIndex = 3;
            this.TxtImport.Text = "Import from txt";
            this.TxtImport.UseVisualStyleBackColor = true;
            this.TxtImport.Click += new System.EventHandler(this.TxtImport_Click);
            // 
            // UsersList
            // 
            this.UsersList.BackColor = System.Drawing.SystemColors.Info;
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(288, 12);
            this.UsersList.Name = "UsersList";
            this.UsersList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsersList.Size = new System.Drawing.Size(522, 329);
            this.UsersList.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(44, 318);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // TxtExport
            // 
            this.TxtExport.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtExport.Location = new System.Drawing.Point(288, 399);
            this.TxtExport.Name = "TxtExport";
            this.TxtExport.Size = new System.Drawing.Size(158, 23);
            this.TxtExport.TabIndex = 6;
            this.TxtExport.Text = "Export to txt";
            this.TxtExport.UseVisualStyleBackColor = true;
            this.TxtExport.Click += new System.EventHandler(this.TxtExport_Click);
            // 
            // XmlExport
            // 
            this.XmlExport.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XmlExport.Location = new System.Drawing.Point(471, 399);
            this.XmlExport.Name = "XmlExport";
            this.XmlExport.Size = new System.Drawing.Size(158, 23);
            this.XmlExport.TabIndex = 8;
            this.XmlExport.Text = "Export to XML";
            this.XmlExport.UseVisualStyleBackColor = true;
            this.XmlExport.Click += new System.EventHandler(this.XmlExport_Click);
            // 
            // XmlImport
            // 
            this.XmlImport.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XmlImport.Location = new System.Drawing.Point(471, 359);
            this.XmlImport.Name = "XmlImport";
            this.XmlImport.Size = new System.Drawing.Size(158, 23);
            this.XmlImport.TabIndex = 7;
            this.XmlImport.Text = "Import from XML";
            this.XmlImport.UseVisualStyleBackColor = true;
            this.XmlImport.Click += new System.EventHandler(this.XmlImport_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(652, 359);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(158, 23);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.PhoneNumber.Location = new System.Drawing.Point(41, 276);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(162, 20);
            this.PhoneNumber.TabIndex = 13;
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(652, 399);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(158, 23);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.XmlExport);
            this.Controls.Add(this.XmlImport);
            this.Controls.Add(this.TxtExport);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.TxtImport);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button TxtImport;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button TxtExport;
        private System.Windows.Forms.Button XmlExport;
        private System.Windows.Forms.Button XmlImport;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Button Edit;
    }
}

