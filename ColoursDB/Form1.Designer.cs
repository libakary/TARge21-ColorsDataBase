namespace ColoursDB
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
            this.labelPrimary = new System.Windows.Forms.Label();
            this.listPrimary = new System.Windows.Forms.ListBox();
            this.labelShade = new System.Windows.Forms.Label();
            this.listShade = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelPrimary
            // 
            this.labelPrimary.AutoSize = true;
            this.labelPrimary.Location = new System.Drawing.Point(53, 41);
            this.labelPrimary.Name = "labelPrimary";
            this.labelPrimary.Size = new System.Drawing.Size(86, 16);
            this.labelPrimary.TabIndex = 0;
            this.labelPrimary.Text = "Primary color";
            // 
            // listPrimary
            // 
            this.listPrimary.FormattingEnabled = true;
            this.listPrimary.ItemHeight = 16;
            this.listPrimary.Location = new System.Drawing.Point(56, 100);
            this.listPrimary.Name = "listPrimary";
            this.listPrimary.Size = new System.Drawing.Size(120, 84);
            this.listPrimary.TabIndex = 1;
            this.listPrimary.SelectedIndexChanged += new System.EventHandler(this.listPrimary_SelectedIndexChanged);
            // 
            // labelShade
            // 
            this.labelShade.AutoSize = true;
            this.labelShade.Location = new System.Drawing.Point(345, 40);
            this.labelShade.Name = "labelShade";
            this.labelShade.Size = new System.Drawing.Size(80, 16);
            this.labelShade.TabIndex = 2;
            this.labelShade.Text = "Shade color";
            // 
            // listShade
            // 
            this.listShade.FormattingEnabled = true;
            this.listShade.ItemHeight = 16;
            this.listShade.Location = new System.Drawing.Point(348, 100);
            this.listShade.Name = "listShade";
            this.listShade.Size = new System.Drawing.Size(120, 84);
            this.listShade.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShade);
            this.Controls.Add(this.labelShade);
            this.Controls.Add(this.listPrimary);
            this.Controls.Add(this.labelPrimary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrimary;
        private System.Windows.Forms.ListBox listPrimary;
        private System.Windows.Forms.Label labelShade;
        private System.Windows.Forms.ListBox listShade;
    }
}

