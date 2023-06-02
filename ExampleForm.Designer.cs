namespace ChatGPT
{
    partial class ExampleForm
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
            this.InputEdit = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputEdit = new System.Windows.Forms.RichTextBox();
            this.TrainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputEdit
            // 
            this.InputEdit.Location = new System.Drawing.Point(77, 12);
            this.InputEdit.Multiline = true;
            this.InputEdit.Name = "InputEdit";
            this.InputEdit.Size = new System.Drawing.Size(672, 55);
            this.InputEdit.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Input.Location = new System.Drawing.Point(12, 23);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(62, 30);
            this.Input.TabIndex = 1;
            this.Input.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutputEdit
            // 
            this.OutputEdit.Location = new System.Drawing.Point(77, 73);
            this.OutputEdit.Name = "OutputEdit";
            this.OutputEdit.Size = new System.Drawing.Size(672, 486);
            this.OutputEdit.TabIndex = 3;
            this.OutputEdit.Text = "";
            // 
            // TrainBtn
            // 
            this.TrainBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrainBtn.Location = new System.Drawing.Point(347, 565);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(85, 36);
            this.TrainBtn.TabIndex = 4;
            this.TrainBtn.Text = "Train";
            this.TrainBtn.UseVisualStyleBackColor = true;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.TrainBtn);
            this.Controls.Add(this.OutputEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.InputEdit);
            this.Name = "ExampleForm";
            this.Text = "ExampleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputEdit;
        private Label Input;
        private Label label1;
        private RichTextBox OutputEdit;
        private Button TrainBtn;
    }
}