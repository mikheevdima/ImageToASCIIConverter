namespace ImageToASCIIConverter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathtextBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Convertbutton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Savebutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(381, 9);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "button1";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathtextBox
            // 
            this.PathtextBox.Location = new System.Drawing.Point(12, 12);
            this.PathtextBox.Name = "PathtextBox";
            this.PathtextBox.Size = new System.Drawing.Size(363, 20);
            this.PathtextBox.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 90);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1098, 588);
            this.webBrowser1.TabIndex = 2;
            // 
            // Convertbutton
            // 
            this.Convertbutton.Location = new System.Drawing.Point(462, 9);
            this.Convertbutton.Name = "Convertbutton";
            this.Convertbutton.Size = new System.Drawing.Size(75, 23);
            this.Convertbutton.TabIndex = 3;
            this.Convertbutton.Text = "button1";
            this.Convertbutton.UseVisualStyleBackColor = true;
            this.Convertbutton.Click += new System.EventHandler(this.Convertbutton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 39);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(363, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 100;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(381, 39);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 5;
            this.Savebutton.Text = "button1";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 809);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Convertbutton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.PathtextBox);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PathtextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Convertbutton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

