namespace Workflow
{
    partial class TestPracticeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</para>m
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_FullName = new System.Windows.Forms.Label();
            this.textBox1_FirstName = new System.Windows.Forms.TextBox();
            this.textBox2_MiddleName = new System.Windows.Forms.TextBox();
            this.textBox3_LastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1_FullName
            // 
            this.label1_FullName.AutoSize = true;
            this.label1_FullName.Location = new System.Drawing.Point(30, 41);
            this.label1_FullName.Name = "label1_FullName";
            this.label1_FullName.Size = new System.Drawing.Size(35, 13);
            this.label1_FullName.TabIndex = 0;
            this.label1_FullName.Text = "label1";
            this.label1_FullName.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_FullName_Paint);
            // 
            // textBox1_FirstName
            // 
            this.textBox1_FirstName.Location = new System.Drawing.Point(33, 103);
            this.textBox1_FirstName.Name = "textBox1_FirstName";
            this.textBox1_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox1_FirstName.TabIndex = 1;
            // 
            // textBox2_MiddleName
            // 
            this.textBox2_MiddleName.Location = new System.Drawing.Point(33, 154);
            this.textBox2_MiddleName.Name = "textBox2_MiddleName";
            this.textBox2_MiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBox2_MiddleName.TabIndex = 2;
            // 
            // textBox3_LastName
            // 
            this.textBox3_LastName.Location = new System.Drawing.Point(33, 201);
            this.textBox3_LastName.Name = "textBox3_LastName";
            this.textBox3_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox3_LastName.TabIndex = 3;
            // 
            // TestPracticeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3_LastName);
            this.Controls.Add(this.textBox2_MiddleName);
            this.Controls.Add(this.textBox1_FirstName);
            this.Controls.Add(this.label1_FullName);
            this.Name = "TestPracticeControl";
            this.Size = new System.Drawing.Size(313, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_FullName;
        private System.Windows.Forms.TextBox textBox1_FirstName;
        private System.Windows.Forms.TextBox textBox2_MiddleName;
        private System.Windows.Forms.TextBox textBox3_LastName;
    }
}
