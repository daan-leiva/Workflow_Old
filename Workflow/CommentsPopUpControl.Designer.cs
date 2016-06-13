namespace Workflow
{
    partial class CommentsPopUpControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.testCommentPopUp1 = new Workflow.TestCommentPopUp();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // testCommentPopUp1
            // 
            this.testCommentPopUp1.Location = new System.Drawing.Point(3, 32);
            this.testCommentPopUp1.Name = "testCommentPopUp1";
            this.testCommentPopUp1.Size = new System.Drawing.Size(236, 122);
            this.testCommentPopUp1.TabIndex = 1;
            // 
            // CommentsPopUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testCommentPopUp1);
            this.Controls.Add(this.button1);
            this.Name = "CommentsPopUpControl";
            this.Size = new System.Drawing.Size(240, 154);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TestCommentPopUp testCommentPopUp1;
    }
}
