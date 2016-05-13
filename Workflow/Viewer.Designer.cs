namespace Workflow
{
    partial class Viewer
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
            this.viewContractReviewButton = new System.Windows.Forms.Button();
            this.viewQuickReleaseButton = new System.Windows.Forms.Button();
            this.viewPOFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewContractReviewButton
            // 
            this.viewContractReviewButton.Location = new System.Drawing.Point(80, 80);
            this.viewContractReviewButton.Name = "viewContractReviewButton";
            this.viewContractReviewButton.Size = new System.Drawing.Size(89, 38);
            this.viewContractReviewButton.TabIndex = 0;
            this.viewContractReviewButton.Text = "Contract Review";
            this.viewContractReviewButton.UseVisualStyleBackColor = true;
            this.viewContractReviewButton.Click += new System.EventHandler(this.viewContractReviewButton_Click);
            // 
            // viewQuickReleaseButton
            // 
            this.viewQuickReleaseButton.Location = new System.Drawing.Point(175, 80);
            this.viewQuickReleaseButton.Name = "viewQuickReleaseButton";
            this.viewQuickReleaseButton.Size = new System.Drawing.Size(89, 38);
            this.viewQuickReleaseButton.TabIndex = 1;
            this.viewQuickReleaseButton.Text = "Quick Release";
            this.viewQuickReleaseButton.UseVisualStyleBackColor = true;
            this.viewQuickReleaseButton.Click += new System.EventHandler(this.viewQuickReleaseButton_Click);
            // 
            // viewPOFormButton
            // 
            this.viewPOFormButton.Location = new System.Drawing.Point(270, 80);
            this.viewPOFormButton.Name = "viewPOFormButton";
            this.viewPOFormButton.Size = new System.Drawing.Size(89, 38);
            this.viewPOFormButton.TabIndex = 2;
            this.viewPOFormButton.Text = "PO Form";
            this.viewPOFormButton.UseVisualStyleBackColor = true;
            this.viewPOFormButton.Click += new System.EventHandler(this.viewPOFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Viewer";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewPOFormButton);
            this.Controls.Add(this.viewQuickReleaseButton);
            this.Controls.Add(this.viewContractReviewButton);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewContractReviewButton;
        private System.Windows.Forms.Button viewQuickReleaseButton;
        private System.Windows.Forms.Button viewPOFormButton;
        private System.Windows.Forms.Label label1;
    }
}