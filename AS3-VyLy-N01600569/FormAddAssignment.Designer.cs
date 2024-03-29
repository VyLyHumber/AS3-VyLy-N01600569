namespace AS3_VyLy_N01600569
{
    partial class FormAddAssignment
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
            this.textBoxASScore = new System.Windows.Forms.TextBox();
            this.textBoxASName = new System.Windows.Forms.TextBox();
            this.textBoxASID = new System.Windows.Forms.TextBox();
            this.textBoxIDStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxASTotal = new System.Windows.Forms.TextBox();
            this.btnAddAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxASScore
            // 
            this.textBoxASScore.Location = new System.Drawing.Point(200, 319);
            this.textBoxASScore.Name = "textBoxASScore";
            this.textBoxASScore.Size = new System.Drawing.Size(276, 26);
            this.textBoxASScore.TabIndex = 33;
            // 
            // textBoxASName
            // 
            this.textBoxASName.Location = new System.Drawing.Point(200, 237);
            this.textBoxASName.Name = "textBoxASName";
            this.textBoxASName.Size = new System.Drawing.Size(276, 26);
            this.textBoxASName.TabIndex = 32;
            // 
            // textBoxASID
            // 
            this.textBoxASID.Location = new System.Drawing.Point(200, 158);
            this.textBoxASID.Name = "textBoxASID";
            this.textBoxASID.Size = new System.Drawing.Size(276, 26);
            this.textBoxASID.TabIndex = 31;
            // 
            // textBoxIDStudent
            // 
            this.textBoxIDStudent.Location = new System.Drawing.Point(200, 81);
            this.textBoxIDStudent.Name = "textBoxIDStudent";
            this.textBoxIDStudent.Size = new System.Drawing.Size(276, 26);
            this.textBoxIDStudent.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Assignment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Assignment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Total Score:";
            // 
            // textBoxASTotal
            // 
            this.textBoxASTotal.Location = new System.Drawing.Point(200, 400);
            this.textBoxASTotal.Name = "textBoxASTotal";
            this.textBoxASTotal.Size = new System.Drawing.Size(276, 26);
            this.textBoxASTotal.TabIndex = 35;
            // 
            // btnAddAS
            // 
            this.btnAddAS.Location = new System.Drawing.Point(157, 473);
            this.btnAddAS.Name = "btnAddAS";
            this.btnAddAS.Size = new System.Drawing.Size(224, 54);
            this.btnAddAS.TabIndex = 36;
            this.btnAddAS.Text = "Add";
            this.btnAddAS.UseVisualStyleBackColor = true;
            this.btnAddAS.Click += new System.EventHandler(this.btnAddAS_Click);
            // 
            // FormAddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 577);
            this.Controls.Add(this.btnAddAS);
            this.Controls.Add(this.textBoxASTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxASScore);
            this.Controls.Add(this.textBoxASName);
            this.Controls.Add(this.textBoxASID);
            this.Controls.Add(this.textBoxIDStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddAssignment";
            this.Text = "FormAddAssignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxASScore;
        private System.Windows.Forms.TextBox textBoxASName;
        private System.Windows.Forms.TextBox textBoxASID;
        private System.Windows.Forms.TextBox textBoxIDStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxASTotal;
        private System.Windows.Forms.Button btnAddAS;
    }
}