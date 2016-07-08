namespace Workflow
{
    partial class StatusPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.partNoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jobNoLabel = new System.Windows.Forms.Label();
            this.workflowListBox = new System.Windows.Forms.ListBox();
            this.step1Details = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.step2Details = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.step3Details = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.step4Details = new System.Windows.Forms.GroupBox();
            this.step1Label = new System.Windows.Forms.Label();
            this.step2Label = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.step4Label = new System.Windows.Forms.Label();
            this.createWorkflowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.step1Details.SuspendLayout();
            this.step2Details.SuspendLayout();
            this.step3Details.SuspendLayout();
            this.step4Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status Page";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.11111F));
            this.tableLayoutPanel1.Controls.Add(this.customerLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.partNoLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.jobNoLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(347, 38);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(842, 19);
            this.customerLabel.TabIndex = 7;
            this.customerLabel.Text = "UTC";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partNoLabel
            // 
            this.partNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partNoLabel.AutoSize = true;
            this.partNoLabel.Location = new System.Drawing.Point(347, 19);
            this.partNoLabel.Name = "partNoLabel";
            this.partNoLabel.Size = new System.Drawing.Size(842, 19);
            this.partNoLabel.TabIndex = 6;
            this.partNoLabel.Text = "CH540-261";
            this.partNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Part No";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Job";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jobNoLabel
            // 
            this.jobNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobNoLabel.AutoSize = true;
            this.jobNoLabel.Location = new System.Drawing.Point(347, 0);
            this.jobNoLabel.Name = "jobNoLabel";
            this.jobNoLabel.Size = new System.Drawing.Size(842, 19);
            this.jobNoLabel.TabIndex = 4;
            this.jobNoLabel.Text = "33154";
            this.jobNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workflowListBox
            // 
            this.workflowListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.workflowListBox.FormattingEnabled = true;
            this.workflowListBox.Location = new System.Drawing.Point(20, 212);
            this.workflowListBox.Name = "workflowListBox";
            this.workflowListBox.Size = new System.Drawing.Size(120, 160);
            this.workflowListBox.TabIndex = 2;
            this.workflowListBox.SelectedIndexChanged += new System.EventHandler(this.workflowList_SelectedIndexChanged);
            // 
            // step1Details
            // 
            this.step1Details.Controls.Add(this.label12);
            this.step1Details.Controls.Add(this.label27);
            this.step1Details.Controls.Add(this.label26);
            this.step1Details.Location = new System.Drawing.Point(158, 287);
            this.step1Details.Name = "step1Details";
            this.step1Details.Size = new System.Drawing.Size(260, 85);
            this.step1Details.TabIndex = 38;
            this.step1Details.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Status";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Timestamp";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label26.Location = new System.Drawing.Point(6, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Username";
            // 
            // step2Details
            // 
            this.step2Details.Controls.Add(this.label19);
            this.step2Details.Controls.Add(this.label20);
            this.step2Details.Controls.Add(this.label21);
            this.step2Details.Location = new System.Drawing.Point(424, 287);
            this.step2Details.Name = "step2Details";
            this.step2Details.Size = new System.Drawing.Size(260, 85);
            this.step2Details.TabIndex = 46;
            this.step2Details.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Status";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Timestamp";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label21.Location = new System.Drawing.Point(6, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Username";
            // 
            // step3Details
            // 
            this.step3Details.Controls.Add(this.label25);
            this.step3Details.Controls.Add(this.label28);
            this.step3Details.Controls.Add(this.label29);
            this.step3Details.Location = new System.Drawing.Point(690, 287);
            this.step3Details.Name = "step3Details";
            this.step3Details.Size = new System.Drawing.Size(260, 85);
            this.step3Details.TabIndex = 50;
            this.step3Details.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Status";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Timestamp";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label29.Location = new System.Drawing.Point(6, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Username";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label32.Location = new System.Drawing.Point(6, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(55, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "Username";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 39);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 13);
            this.label31.TabIndex = 1;
            this.label31.Text = "Timestamp";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 57);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Status";
            // 
            // step4Details
            // 
            this.step4Details.Controls.Add(this.label30);
            this.step4Details.Controls.Add(this.label31);
            this.step4Details.Controls.Add(this.label32);
            this.step4Details.Location = new System.Drawing.Point(956, 287);
            this.step4Details.Name = "step4Details";
            this.step4Details.Size = new System.Drawing.Size(260, 85);
            this.step4Details.TabIndex = 52;
            this.step4Details.TabStop = false;
            // 
            // step1Label
            // 
            this.step1Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.step1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.step1Label.ForeColor = System.Drawing.SystemColors.Window;
            this.step1Label.Location = new System.Drawing.Point(158, 272);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(260, 23);
            this.step1Label.TabIndex = 54;
            this.step1Label.Text = "PO Reivew";
            this.step1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.step1Label.DoubleClick += new System.EventHandler(this.step1Label_DoubleClick);
            // 
            // step2Label
            // 
            this.step2Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.step2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.step2Label.ForeColor = System.Drawing.SystemColors.Window;
            this.step2Label.Location = new System.Drawing.Point(424, 272);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(260, 23);
            this.step2Label.TabIndex = 55;
            this.step2Label.Text = "PO Reivew";
            this.step2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.step2Label.DoubleClick += new System.EventHandler(this.step2Label_DoubleClick_1);
            // 
            // step3Label
            // 
            this.step3Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.step3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.step3Label.ForeColor = System.Drawing.SystemColors.Window;
            this.step3Label.Location = new System.Drawing.Point(690, 272);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(260, 23);
            this.step3Label.TabIndex = 56;
            this.step3Label.Text = "PO Reivew";
            this.step3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.step3Label.DoubleClick += new System.EventHandler(this.step3Label_DoubleClick_1);
            // 
            // step4Label
            // 
            this.step4Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.step4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.step4Label.ForeColor = System.Drawing.SystemColors.Window;
            this.step4Label.Location = new System.Drawing.Point(956, 272);
            this.step4Label.Name = "step4Label";
            this.step4Label.Size = new System.Drawing.Size(260, 23);
            this.step4Label.TabIndex = 57;
            this.step4Label.Text = "PO Reivew";
            this.step4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.step4Label.DoubleClick += new System.EventHandler(this.step4Label_DoubleClick_1);
            // 
            // createWorkflowButton
            // 
            this.createWorkflowButton.Location = new System.Drawing.Point(158, 212);
            this.createWorkflowButton.Name = "createWorkflowButton";
            this.createWorkflowButton.Size = new System.Drawing.Size(96, 23);
            this.createWorkflowButton.TabIndex = 58;
            this.createWorkflowButton.Text = "Create Workflow";
            this.createWorkflowButton.UseVisualStyleBackColor = true;
            this.createWorkflowButton.Click += new System.EventHandler(this.createWorkflowButton_Click);
            // 
            // StatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1227, 383);
            this.Controls.Add(this.createWorkflowButton);
            this.Controls.Add(this.step4Label);
            this.Controls.Add(this.step3Label);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.step1Label);
            this.Controls.Add(this.step4Details);
            this.Controls.Add(this.step3Details);
            this.Controls.Add(this.step2Details);
            this.Controls.Add(this.step1Details);
            this.Controls.Add(this.workflowListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "StatusPage";
            this.Text = "StatusPage";
            this.Load += new System.EventHandler(this.StatusPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.step1Details.ResumeLayout(false);
            this.step1Details.PerformLayout();
            this.step2Details.ResumeLayout(false);
            this.step2Details.PerformLayout();
            this.step3Details.ResumeLayout(false);
            this.step3Details.PerformLayout();
            this.step4Details.ResumeLayout(false);
            this.step4Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label partNoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label jobNoLabel;
        private System.Windows.Forms.ListBox workflowListBox;
        private System.Windows.Forms.GroupBox step1Details;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox step2Details;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox step3Details;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox step4Details;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Label step4Label;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.Button createWorkflowButton;
    }
}