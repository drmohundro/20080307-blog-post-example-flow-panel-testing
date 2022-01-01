namespace GUI
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cboFlowDirection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkWrapContents = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(427, 267);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(445, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboFlowDirection
            // 
            this.cboFlowDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFlowDirection.FormattingEnabled = true;
            this.cboFlowDirection.Items.AddRange(new object[] {
            "LeftToRight",
            "TopDown",
            "RightToLeft",
            "BottomUp"});
            this.cboFlowDirection.Location = new System.Drawing.Point(523, 52);
            this.cboFlowDirection.Name = "cboFlowDirection";
            this.cboFlowDirection.Size = new System.Drawing.Size(130, 21);
            this.cboFlowDirection.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FlowDirection";
            // 
            // chkWrapContents
            // 
            this.chkWrapContents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWrapContents.AutoSize = true;
            this.chkWrapContents.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkWrapContents.Location = new System.Drawing.Point(445, 81);
            this.chkWrapContents.Name = "chkWrapContents";
            this.chkWrapContents.Size = new System.Drawing.Size(94, 17);
            this.chkWrapContents.TabIndex = 4;
            this.chkWrapContents.Text = "WrapContents";
            this.chkWrapContents.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(449, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 175);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkWrapContents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFlowDirection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboFlowDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkWrapContents;
        private System.Windows.Forms.Panel panel1;
    }
}

