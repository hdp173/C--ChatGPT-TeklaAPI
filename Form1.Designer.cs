namespace ChatGPT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.Conversation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(74, 637);
            this.UserInput.Multiline = true;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(620, 39);
            this.UserInput.TabIndex = 1;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(713, 646);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conversation
            // 
            this.Conversation.Location = new System.Drawing.Point(12, 3);
            this.Conversation.Name = "Conversation";
            this.Conversation.ReadOnly = true;
            this.Conversation.Size = new System.Drawing.Size(776, 628);
            this.Conversation.TabIndex = 3;
            this.Conversation.Text = "";
            this.Conversation.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.Conversation);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button SendBtn;
        private RichTextBox richTextBox1;
        private TextBox UserInput;
        private RichTextBox Conversation;
    }
}