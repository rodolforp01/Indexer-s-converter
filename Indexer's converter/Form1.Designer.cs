namespace Indexer_s_converter
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
            this.ConverterOutp = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.NormalString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConverterOutp
            // 
            this.ConverterOutp.Location = new System.Drawing.Point(12, 209);
            this.ConverterOutp.Multiline = true;
            this.ConverterOutp.Name = "ConverterOutp";
            this.ConverterOutp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConverterOutp.Size = new System.Drawing.Size(483, 116);
            this.ConverterOutp.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(206, 120);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(92, 55);
            this.btn.TabIndex = 3;
            this.btn.Text = "Convert";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // NormalString
            // 
            this.NormalString.Location = new System.Drawing.Point(75, 74);
            this.NormalString.Name = "NormalString";
            this.NormalString.Size = new System.Drawing.Size(352, 22);
            this.NormalString.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 353);
            this.Controls.Add(this.NormalString);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.ConverterOutp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConverterOutp;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox NormalString;
    }
}

