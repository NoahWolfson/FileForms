namespace FileForms
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
            Write = new Button();
            Read = new Button();
            label1 = new Label();
            FilePath = new TextBox();
            FileContentWrite = new TextBox();
            FileContent = new Label();
            SuspendLayout();
            // 
            // Write
            // 
            Write.Location = new Point(122, 214);
            Write.Name = "Write";
            Write.Size = new Size(75, 23);
            Write.TabIndex = 0;
            Write.Text = "Write";
            Write.UseVisualStyleBackColor = true;
            Write.Click += Write_Click;
            // 
            // Read
            // 
            Read.Location = new Point(574, 214);
            Read.Name = "Read";
            Read.Size = new Size(75, 23);
            Read.TabIndex = 1;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 145);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "File Path";
            // 
            // FilePath
            // 
            FilePath.Location = new Point(341, 163);
            FilePath.Name = "FilePath";
            FilePath.Size = new Size(100, 23);
            FilePath.TabIndex = 3;
            // 
            // FileContentWrite
            // 
            FileContentWrite.Location = new Point(40, 256);
            FileContentWrite.Name = "FileContentWrite";
            FileContentWrite.Size = new Size(234, 23);
            FileContentWrite.TabIndex = 4;
            // 
            // FileContent
            // 
            FileContent.AutoSize = true;
            FileContent.Location = new Point(595, 259);
            FileContent.Name = "FileContent";
            FileContent.Size = new Size(38, 15);
            FileContent.TabIndex = 5;
            FileContent.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FileContent);
            Controls.Add(FileContentWrite);
            Controls.Add(FilePath);
            Controls.Add(label1);
            Controls.Add(Read);
            Controls.Add(Write);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Write;
        private Button Read;
        private Label label1;
        private TextBox FilePath;
        private TextBox FileContentWrite;
        private Label FileContent;
    }
}
