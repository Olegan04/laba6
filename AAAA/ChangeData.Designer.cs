namespace AAAA
{
    partial class ChangeData
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 262);
            button1.Name = "button1";
            button1.Size = new Size(156, 73);
            button1.TabIndex = 0;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 56);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "Укажите новую цену";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 31);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(198, 262);
            button2.Name = "button2";
            button2.Size = new Size(156, 73);
            button2.TabIndex = 3;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangeData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 418);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ChangeData";
            Text = "ChangeData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
    }
}