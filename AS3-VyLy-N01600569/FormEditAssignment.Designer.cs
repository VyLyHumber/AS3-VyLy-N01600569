namespace AS3_VyLy_N01600569
{
    partial class FormEditAssignment
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
            this.btnEditAS = new System.Windows.Forms.Button();
            this.textBoxASTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxASScore = new System.Windows.Forms.TextBox();
            this.textBoxASName = new System.Windows.Forms.TextBox();
            this.textBoxASID = new System.Windows.Forms.TextBox();
            this.textBoxIDStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditAS
            // 
            this.btnEditAS.Location = new System.Drawing.Point(160, 457);
            this.btnEditAS.Name = "btnEditAS";
            this.btnEditAS.Size = new System.Drawing.Size(224, 54);
            this.btnEditAS.TabIndex = 47;
            this.btnEditAS.Text = "Edit";
            this.btnEditAS.UseVisualStyleBackColor = true;
            this.btnEditAS.Click += new System.EventHandler(this.btnEditAS_Click);
            // 
            // textBoxASTotal
            // 
            this.textBoxASTotal.Location = new System.Drawing.Point(203, 384);
            this.textBoxASTotal.Name = "textBoxASTotal";
            this.textBoxASTotal.Size = new System.Drawing.Size(276, 26);
            this.textBoxASTotal.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Total Score:";
            // 
            // textBoxASScore
            // 
            this.textBoxASScore.Location = new System.Drawing.Point(203, 303);
            this.textBoxASScore.Name = "textBoxASScore";
            this.textBoxASScore.Size = new System.Drawing.Size(276, 26);
            this.textBoxASScore.TabIndex = 44;
            // 
            // textBoxASName
            // 
            this.textBoxASName.Location = new System.Drawing.Point(203, 221);
            this.textBoxASName.Name = "textBoxASName";
            this.textBoxASName.Size = new System.Drawing.Size(276, 26);
            this.textBoxASName.TabIndex = 43;
            // 
            // textBoxASID
            // 
            this.textBoxASID.Location = new System.Drawing.Point(203, 142);
            this.textBoxASID.Name = "textBoxASID";
            this.textBoxASID.Size = new System.Drawing.Size(276, 26);
            this.textBoxASID.TabIndex = 42;
            // 
            // textBoxIDStudent
            // 
            this.textBoxIDStudent.Location = new System.Drawing.Point(203, 65);
            this.textBoxIDStudent.Name = "textBoxIDStudent";
            this.textBoxIDStudent.ReadOnly = true;
            this.textBoxIDStudent.Size = new System.Drawing.Size(276, 26);
            this.textBoxIDStudent.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Assignment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Assignment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Student ID:";
            // 
            // FormEditAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 577);
            this.Controls.Add(this.btnEditAS);
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
            this.Name = "FormEditAssignment";
            this.Text = "FormEditAssignment";
            this.Load += new System.EventHandler(this.FormEditAssignment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditAS;
        private System.Windows.Forms.TextBox textBoxASTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxASScore;
        private System.Windows.Forms.TextBox textBoxASName;
        private System.Windows.Forms.TextBox textBoxASID;
        private System.Windows.Forms.TextBox textBoxIDStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}