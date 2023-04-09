namespace _0407lab
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
            this.text = new System.Windows.Forms.TextBox();
            this.textprogress = new System.Windows.Forms.ProgressBar();
            this.textbutton = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(34, 28);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(454, 392);
            this.text.TabIndex = 0;
            // 
            // textprogress
            // 
            this.textprogress.Location = new System.Drawing.Point(513, 368);
            this.textprogress.Name = "textprogress";
            this.textprogress.Size = new System.Drawing.Size(263, 52);
            this.textprogress.TabIndex = 1;
            // 
            // textbutton
            // 
            this.textbutton.Location = new System.Drawing.Point(607, 317);
            this.textbutton.Name = "textbutton";
            this.textbutton.Size = new System.Drawing.Size(75, 23);
            this.textbutton.TabIndex = 2;
            this.textbutton.Text = "Load Text";
            this.textbutton.UseVisualStyleBackColor = true;
            this.textbutton.Click += new System.EventHandler(this.textbutton_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(593, 268);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(100, 20);
            this.path.TabIndex = 3;
            this.path.Text = "text.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textbutton);
            this.Controls.Add(this.textprogress);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ProgressBar textprogress;
        private System.Windows.Forms.Button textbutton;
        private System.Windows.Forms.TextBox path;
    }
}

