namespace MissingSQLEvents
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
            this.label1 = new System.Windows.Forms.Label();
            this.sqlVersion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlInstance = new System.Windows.Forms.TextBox();
            this.addregKey = new System.Windows.Forms.Button();
            this.removeregKey = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.testforSQL = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Version";
            // 
            // sqlVersion
            // 
            this.sqlVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sqlVersion.FormattingEnabled = true;
            this.sqlVersion.Items.AddRange(new object[] {
            "2005",
            "2008",
            "2008R2",
            "2012"});
            this.sqlVersion.Location = new System.Drawing.Point(119, 30);
            this.sqlVersion.Name = "sqlVersion";
            this.sqlVersion.Size = new System.Drawing.Size(195, 21);
            this.sqlVersion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instance Name:";
            // 
            // sqlInstance
            // 
            this.sqlInstance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlInstance.Location = new System.Drawing.Point(119, 71);
            this.sqlInstance.Name = "sqlInstance";
            this.sqlInstance.Size = new System.Drawing.Size(195, 20);
            this.sqlInstance.TabIndex = 3;
            // 
            // addregKey
            // 
            this.addregKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addregKey.Location = new System.Drawing.Point(140, 159);
            this.addregKey.Name = "addregKey";
            this.addregKey.Size = new System.Drawing.Size(76, 23);
            this.addregKey.TabIndex = 4;
            this.addregKey.Text = "Add";
            this.addregKey.UseVisualStyleBackColor = true;
            this.addregKey.Click += new System.EventHandler(this.addregKey_Click);
            // 
            // removeregKey
            // 
            this.removeregKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeregKey.Location = new System.Drawing.Point(238, 159);
            this.removeregKey.Name = "removeregKey";
            this.removeregKey.Size = new System.Drawing.Size(76, 23);
            this.removeregKey.TabIndex = 5;
            this.removeregKey.Text = "Remove";
            this.removeregKey.UseVisualStyleBackColor = true;
            this.removeregKey.Click += new System.EventHandler(this.removeregKey_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 6;
            // 
            // testforSQL
            // 
            this.testforSQL.Location = new System.Drawing.Point(25, 158);
            this.testforSQL.Name = "testforSQL";
            this.testforSQL.Size = new System.Drawing.Size(75, 23);
            this.testforSQL.TabIndex = 7;
            this.testforSQL.Text = "test";
            this.testforSQL.UseVisualStyleBackColor = true;
            this.testforSQL.Click += new System.EventHandler(this.testforSQL_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(331, 159);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 213);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.testforSQL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.removeregKey);
            this.Controls.Add(this.addregKey);
            this.Controls.Add(this.sqlInstance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sqlVersion);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(429, 252);
            this.Name = "Form1";
            this.Text = "Missing SQL Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sqlVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sqlInstance;
        private System.Windows.Forms.Button addregKey;
        private System.Windows.Forms.Button removeregKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button testforSQL;
        private System.Windows.Forms.Button closeButton;
    }
}

