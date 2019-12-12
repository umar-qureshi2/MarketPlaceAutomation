namespace AddApiToMarketplace
{
    partial class EntryForm
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
            this.AddApiToDatabaseButton = new System.Windows.Forms.Button();
            this.ApiName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddApiToDatabaseButton
            // 
            this.AddApiToDatabaseButton.Location = new System.Drawing.Point(647, 52);
            this.AddApiToDatabaseButton.Name = "AddApiToDatabaseButton";
            this.AddApiToDatabaseButton.Size = new System.Drawing.Size(116, 23);
            this.AddApiToDatabaseButton.TabIndex = 0;
            this.AddApiToDatabaseButton.Text = "Add to database";
            this.AddApiToDatabaseButton.UseVisualStyleBackColor = true;
            this.AddApiToDatabaseButton.Click += new System.EventHandler(this.AddToDatabaseButton_Click);
            // 
            // ApiName
            // 
            this.ApiName.Location = new System.Drawing.Point(60, 52);
            this.ApiName.Name = "ApiName";
            this.ApiName.Size = new System.Drawing.Size(168, 20);
            this.ApiName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Api Name";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(60, 112);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(168, 20);
            this.Description.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Api Description";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(332, 92);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApiName);
            this.Controls.Add(this.AddApiToDatabaseButton);
            this.Name = "Form1";
            this.Text = "A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddApiToDatabaseButton;
        private System.Windows.Forms.TextBox ApiName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
    }
}

