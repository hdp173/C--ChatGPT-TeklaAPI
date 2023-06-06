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
            this.TrainBtn = new System.Windows.Forms.Button();
            this.rememberConversation = new System.Windows.Forms.CheckBox();
            this.trainProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 647);
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
            this.UserInput.Size = new System.Drawing.Size(551, 57);
            this.UserInput.TabIndex = 1;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(631, 647);
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
            this.Conversation.Size = new System.Drawing.Size(893, 628);
            this.Conversation.TabIndex = 3;
            this.Conversation.Text = "";
            this.Conversation.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // TrainBtn
            // 
            this.TrainBtn.Location = new System.Drawing.Point(712, 647);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(75, 23);
            this.TrainBtn.TabIndex = 4;
            this.TrainBtn.Text = "Train";
            this.TrainBtn.UseVisualStyleBackColor = true;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // rememberConversation
            // 
            this.rememberConversation.AutoSize = true;
            this.rememberConversation.Location = new System.Drawing.Point(631, 675);
            this.rememberConversation.Name = "rememberConversation";
            this.rememberConversation.Size = new System.Drawing.Size(141, 19);
            this.rememberConversation.TabIndex = 5;
            this.rememberConversation.Text = "remeber conversation";
            this.rememberConversation.UseVisualStyleBackColor = true;
            // 
            // trainProjectBtn
            // 
            this.trainProjectBtn.Location = new System.Drawing.Point(797, 647);
            this.trainProjectBtn.Name = "trainProjectBtn";
            this.trainProjectBtn.Size = new System.Drawing.Size(103, 23);
            this.trainProjectBtn.TabIndex = 6;
            this.trainProjectBtn.Text = "Train Project";
            this.trainProjectBtn.UseVisualStyleBackColor = true;
            this.trainProjectBtn.Click += new System.EventHandler(this.trainProjectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 698);
            this.Controls.Add(this.trainProjectBtn);
            this.Controls.Add(this.rememberConversation);
            this.Controls.Add(this.TrainBtn);
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
        private Button TrainBtn;
        private CheckBox rememberConversation;
        private Button trainProjectBtn;
    }
}