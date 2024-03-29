namespace AS3_VyLy_N01600569
{
    partial class FormStudentManagement
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
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.textBoxSearchSD = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSearchAS = new System.Windows.Forms.TextBox();
            this.btnSearchAS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonEditAS = new System.Windows.Forms.RadioButton();
            this.radioButtonExit = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteSD = new System.Windows.Forms.RadioButton();
            this.radioButtonEditSD = new System.Windows.Forms.RadioButton();
            this.radioButtonAddSD = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteAS = new System.Windows.Forms.RadioButton();
            this.radioButtonAddAS = new System.Windows.Forms.RadioButton();
            this.btnPerform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAS)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(28, 107);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 62;
            this.dataGridViewStudent.RowTemplate.Height = 28;
            this.dataGridViewStudent.Size = new System.Drawing.Size(707, 262);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellContentClick);
            // 
            // textBoxSearchSD
            // 
            this.textBoxSearchSD.Location = new System.Drawing.Point(163, 32);
            this.textBoxSearchSD.Name = "textBoxSearchSD";
            this.textBoxSearchSD.Size = new System.Drawing.Size(309, 23);
            this.textBoxSearchSD.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Tomato;
            this.btnSearch.Location = new System.Drawing.Point(490, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Enter ID, First name, or Last name of student to search";
            // 
            // dataGridViewAS
            // 
            this.dataGridViewAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAS.Location = new System.Drawing.Point(28, 501);
            this.dataGridViewAS.Name = "dataGridViewAS";
            this.dataGridViewAS.RowHeadersWidth = 62;
            this.dataGridViewAS.RowTemplate.Height = 28;
            this.dataGridViewAS.Size = new System.Drawing.Size(707, 156);
            this.dataGridViewAS.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Assignment List";
            // 
            // txtBoxSearchAS
            // 
            this.txtBoxSearchAS.Location = new System.Drawing.Point(163, 433);
            this.txtBoxSearchAS.Name = "txtBoxSearchAS";
            this.txtBoxSearchAS.Size = new System.Drawing.Size(309, 23);
            this.txtBoxSearchAS.TabIndex = 9;
            // 
            // btnSearchAS
            // 
            this.btnSearchAS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchAS.Location = new System.Drawing.Point(490, 427);
            this.btnSearchAS.Name = "btnSearchAS";
            this.btnSearchAS.Size = new System.Drawing.Size(172, 40);
            this.btnSearchAS.TabIndex = 10;
            this.btnSearchAS.Text = "Search Assignment";
            this.btnSearchAS.UseVisualStyleBackColor = false;
            this.btnSearchAS.Click += new System.EventHandler(this.btnSearchAS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(28, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "* Enter ID Assignment, Assignment name, or Student ID to search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student List";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonEditAS);
            this.groupBox.Controls.Add(this.radioButtonExit);
            this.groupBox.Controls.Add(this.radioButtonDeleteSD);
            this.groupBox.Controls.Add(this.radioButtonEditSD);
            this.groupBox.Controls.Add(this.radioButtonAddSD);
            this.groupBox.Controls.Add(this.radioButtonDeleteAS);
            this.groupBox.Controls.Add(this.radioButtonAddAS);
            this.groupBox.Location = new System.Drawing.Point(766, 34);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(234, 540);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Operation";
            // 
            // radioButtonEditAS
            // 
            this.radioButtonEditAS.AutoSize = true;
            this.radioButtonEditAS.Location = new System.Drawing.Point(50, 108);
            this.radioButtonEditAS.Name = "radioButtonEditAS";
            this.radioButtonEditAS.Size = new System.Drawing.Size(149, 21);
            this.radioButtonEditAS.TabIndex = 7;
            this.radioButtonEditAS.TabStop = true;
            this.radioButtonEditAS.Text = "Edit Assignment";
            this.radioButtonEditAS.UseVisualStyleBackColor = true;
            // 
            // radioButtonExit
            // 
            this.radioButtonExit.AutoSize = true;
            this.radioButtonExit.Location = new System.Drawing.Point(50, 482);
            this.radioButtonExit.Name = "radioButtonExit";
            this.radioButtonExit.Size = new System.Drawing.Size(59, 21);
            this.radioButtonExit.TabIndex = 6;
            this.radioButtonExit.TabStop = true;
            this.radioButtonExit.Text = "Exit";
            this.radioButtonExit.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteSD
            // 
            this.radioButtonDeleteSD.AutoSize = true;
            this.radioButtonDeleteSD.Location = new System.Drawing.Point(50, 404);
            this.radioButtonDeleteSD.Name = "radioButtonDeleteSD";
            this.radioButtonDeleteSD.Size = new System.Drawing.Size(141, 21);
            this.radioButtonDeleteSD.TabIndex = 5;
            this.radioButtonDeleteSD.TabStop = true;
            this.radioButtonDeleteSD.Text = "Delete Student";
            this.radioButtonDeleteSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonEditSD
            // 
            this.radioButtonEditSD.AutoSize = true;
            this.radioButtonEditSD.Location = new System.Drawing.Point(50, 325);
            this.radioButtonEditSD.Name = "radioButtonEditSD";
            this.radioButtonEditSD.Size = new System.Drawing.Size(122, 21);
            this.radioButtonEditSD.TabIndex = 4;
            this.radioButtonEditSD.TabStop = true;
            this.radioButtonEditSD.Text = "Edit Student";
            this.radioButtonEditSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddSD
            // 
            this.radioButtonAddSD.AutoSize = true;
            this.radioButtonAddSD.Location = new System.Drawing.Point(50, 249);
            this.radioButtonAddSD.Name = "radioButtonAddSD";
            this.radioButtonAddSD.Size = new System.Drawing.Size(122, 21);
            this.radioButtonAddSD.TabIndex = 3;
            this.radioButtonAddSD.TabStop = true;
            this.radioButtonAddSD.Text = "Add Student";
            this.radioButtonAddSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteAS
            // 
            this.radioButtonDeleteAS.AutoSize = true;
            this.radioButtonDeleteAS.Location = new System.Drawing.Point(50, 177);
            this.radioButtonDeleteAS.Name = "radioButtonDeleteAS";
            this.radioButtonDeleteAS.Size = new System.Drawing.Size(168, 21);
            this.radioButtonDeleteAS.TabIndex = 2;
            this.radioButtonDeleteAS.TabStop = true;
            this.radioButtonDeleteAS.Text = "Delete Assignment";
            this.radioButtonDeleteAS.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddAS
            // 
            this.radioButtonAddAS.AutoSize = true;
            this.radioButtonAddAS.Location = new System.Drawing.Point(50, 44);
            this.radioButtonAddAS.Name = "radioButtonAddAS";
            this.radioButtonAddAS.Size = new System.Drawing.Size(149, 21);
            this.radioButtonAddAS.TabIndex = 0;
            this.radioButtonAddAS.TabStop = true;
            this.radioButtonAddAS.Text = "Add Assignment";
            this.radioButtonAddAS.UseVisualStyleBackColor = true;
            // 
            // btnPerform
            // 
            this.btnPerform.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPerform.Location = new System.Drawing.Point(768, 605);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(232, 52);
            this.btnPerform.TabIndex = 14;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = false;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // FormStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 694);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchAS);
            this.Controls.Add(this.txtBoxSearchAS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearchSD);
            this.Controls.Add(this.dataGridViewStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormStudentManagement";
            this.Text = "FormStudentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAS)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TextBox textBoxSearchSD;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSearchAS;
        private System.Windows.Forms.Button btnSearchAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonExit;
        private System.Windows.Forms.RadioButton radioButtonDeleteSD;
        private System.Windows.Forms.RadioButton radioButtonEditSD;
        private System.Windows.Forms.RadioButton radioButtonAddSD;
        private System.Windows.Forms.RadioButton radioButtonDeleteAS;
        private System.Windows.Forms.RadioButton radioButtonAddAS;
        private System.Windows.Forms.RadioButton radioButtonEditAS;
        private System.Windows.Forms.Button btnPerform;
    }
}