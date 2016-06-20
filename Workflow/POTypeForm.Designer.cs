namespace Workflow
{
    partial class POTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.hondaButton = new System.Windows.Forms.Button();
            this.rollsRoyceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What PO Form would you like to open?";
            // 
            // hondaButton
            // 
            this.hondaButton.Location = new System.Drawing.Point(93, 51);
            this.hondaButton.Name = "hondaButton";
            this.hondaButton.Size = new System.Drawing.Size(75, 23);
            this.hondaButton.TabIndex = 1;
            this.hondaButton.Text = "Honda PO";
            this.hondaButton.UseVisualStyleBackColor = true;
            this.hondaButton.Click += new System.EventHandler(this.hondaButton_Click);
            // 
            // rollsRoyceButton
            // 
            this.rollsRoyceButton.Location = new System.Drawing.Point(93, 92);
            this.rollsRoyceButton.Name = "rollsRoyceButton";
            this.rollsRoyceButton.Size = new System.Drawing.Size(75, 23);
            this.rollsRoyceButton.TabIndex = 2;
            this.rollsRoyceButton.Text = "Rolls Royce PO";
            this.rollsRoyceButton.UseVisualStyleBackColor = true;
            this.rollsRoyceButton.Click += new System.EventHandler(this.rollsRoyceButton_Click);
            // 
            // POTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 154);
            this.Controls.Add(this.rollsRoyceButton);
            this.Controls.Add(this.hondaButton);
            this.Controls.Add(this.label1);
            this.Name = "POTypeForm";
            this.Text = "PO Form Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hondaButton;
        private System.Windows.Forms.Button rollsRoyceButton;
    }
}