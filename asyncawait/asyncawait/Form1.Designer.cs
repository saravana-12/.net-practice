namespace asyncawait
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
            this.btnprocess = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnprocess
            // 
            this.btnprocess.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnprocess.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnprocess.FlatAppearance.BorderSize = 6;
            this.btnprocess.Font = new System.Drawing.Font("Nasalization", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocess.Location = new System.Drawing.Point(59, 38);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(171, 55);
            this.btnprocess.TabIndex = 0;
            this.btnprocess.Text = "Process File";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(56, 153);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(0, 13);
            this.lblcount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btnprocess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.Label lblcount;
    }
}

