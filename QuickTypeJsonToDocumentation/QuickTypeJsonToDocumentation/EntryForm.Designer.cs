namespace QuickTypeJsonToDocumentation
{
    partial class JsonToDocumentation
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
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateDocBtn = new System.Windows.Forms.Button();
            this.GenerateOutputDocBtn = new System.Windows.Forms.Button();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.UIGroup = new System.Windows.Forms.GroupBox();
            this.ErrorMessagesInputBox = new System.Windows.Forms.RichTextBox();
            this.ErrorMessagesOutputBox = new System.Windows.Forms.RichTextBox();
            this.GetErrorMessages = new System.Windows.Forms.Button();
            this.UIGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Location = new System.Drawing.Point(37, 13);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.Size = new System.Drawing.Size(462, 207);
            this.InputRichTextBox.TabIndex = 0;
            this.InputRichTextBox.Text = "";
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Location = new System.Drawing.Point(37, 222);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(462, 207);
            this.OutputRichTextBox.TabIndex = 1;
            this.OutputRichTextBox.Text = "";
            // 
            // GenerateDocBtn
            // 
            this.GenerateDocBtn.Location = new System.Drawing.Point(515, 19);
            this.GenerateDocBtn.Name = "GenerateDocBtn";
            this.GenerateDocBtn.Size = new System.Drawing.Size(142, 23);
            this.GenerateDocBtn.TabIndex = 2;
            this.GenerateDocBtn.Text = "Generate Input Doc";
            this.GenerateDocBtn.UseVisualStyleBackColor = true;
            this.GenerateDocBtn.Click += new System.EventHandler(this.GenerateDocBtn_Click);
            // 
            // GenerateOutputDocBtn
            // 
            this.GenerateOutputDocBtn.Location = new System.Drawing.Point(515, 48);
            this.GenerateOutputDocBtn.Name = "GenerateOutputDocBtn";
            this.GenerateOutputDocBtn.Size = new System.Drawing.Size(142, 23);
            this.GenerateOutputDocBtn.TabIndex = 3;
            this.GenerateOutputDocBtn.Text = "Generate Output Doc";
            this.GenerateOutputDocBtn.UseVisualStyleBackColor = true;
            this.GenerateOutputDocBtn.Click += new System.EventHandler(this.GenerateOutputDocBtn_Click);
            // 
            // EntityName
            // 
            this.EntityName.Location = new System.Drawing.Point(515, 90);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(142, 20);
            this.EntityName.TabIndex = 4;
            // 
            // UIGroup
            // 
            this.UIGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UIGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UIGroup.Controls.Add(this.GetErrorMessages);
            this.UIGroup.Controls.Add(this.ErrorMessagesOutputBox);
            this.UIGroup.Controls.Add(this.ErrorMessagesInputBox);
            this.UIGroup.Controls.Add(this.OutputRichTextBox);
            this.UIGroup.Controls.Add(this.EntityName);
            this.UIGroup.Controls.Add(this.InputRichTextBox);
            this.UIGroup.Controls.Add(this.GenerateOutputDocBtn);
            this.UIGroup.Controls.Add(this.GenerateDocBtn);
            this.UIGroup.Location = new System.Drawing.Point(8, 5);
            this.UIGroup.Name = "UIGroup";
            this.UIGroup.Size = new System.Drawing.Size(971, 441);
            this.UIGroup.TabIndex = 5;
            this.UIGroup.TabStop = false;
            this.UIGroup.Text = "groupBox1";
            // 
            // ErrorMessagesInputBox
            // 
            this.ErrorMessagesInputBox.Location = new System.Drawing.Point(515, 116);
            this.ErrorMessagesInputBox.Name = "ErrorMessagesInputBox";
            this.ErrorMessagesInputBox.Size = new System.Drawing.Size(450, 152);
            this.ErrorMessagesInputBox.TabIndex = 5;
            this.ErrorMessagesInputBox.Text = "";
            // 
            // ErrorMessagesOutputBox
            // 
            this.ErrorMessagesOutputBox.Location = new System.Drawing.Point(515, 274);
            this.ErrorMessagesOutputBox.Name = "ErrorMessagesOutputBox";
            this.ErrorMessagesOutputBox.Size = new System.Drawing.Size(450, 155);
            this.ErrorMessagesOutputBox.TabIndex = 6;
            this.ErrorMessagesOutputBox.Text = "";
            // 
            // GetErrorMessages
            // 
            this.GetErrorMessages.Location = new System.Drawing.Point(663, 19);
            this.GetErrorMessages.Name = "GetErrorMessages";
            this.GetErrorMessages.Size = new System.Drawing.Size(111, 23);
            this.GetErrorMessages.TabIndex = 7;
            this.GetErrorMessages.Text = "GetErrorMessages";
            this.GetErrorMessages.UseVisualStyleBackColor = true;
            this.GetErrorMessages.Click += new System.EventHandler(this.GetErrorMessages_Click);
            // 
            // JsonToDocumentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.UIGroup);
            this.Name = "JsonToDocumentation";
            this.Text = "JsonToDocumentation";
            this.UIGroup.ResumeLayout(false);
            this.UIGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputRichTextBox;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Button GenerateDocBtn;
        private System.Windows.Forms.Button GenerateOutputDocBtn;
        private System.Windows.Forms.TextBox EntityName;
        private System.Windows.Forms.GroupBox UIGroup;
        private System.Windows.Forms.Button GetErrorMessages;
        private System.Windows.Forms.RichTextBox ErrorMessagesOutputBox;
        private System.Windows.Forms.RichTextBox ErrorMessagesInputBox;
    }
}

