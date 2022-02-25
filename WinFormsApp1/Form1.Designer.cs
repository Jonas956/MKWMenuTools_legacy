
namespace WinFormsApp1
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
            this.ExtractMenuSingle = new System.Windows.Forms.Button();
            this.CTGPMenuSingle = new System.Windows.Forms.Button();
            this.DolphinMenuSingle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ExtractMenuSingle
            // 
            this.ExtractMenuSingle.Location = new System.Drawing.Point(608, 24);
            this.ExtractMenuSingle.Name = "ExtractMenuSingle";
            this.ExtractMenuSingle.Size = new System.Drawing.Size(156, 35);
            this.ExtractMenuSingle.TabIndex = 0;
            this.ExtractMenuSingle.Text = "Extract MenuSingle";
            this.ExtractMenuSingle.UseVisualStyleBackColor = true;
            this.ExtractMenuSingle.Click += new System.EventHandler(this.button1_Click);
            // 
            // CTGPMenuSingle
            // 
            this.CTGPMenuSingle.Location = new System.Drawing.Point(608, 65);
            this.CTGPMenuSingle.Name = "CTGPMenuSingle";
            this.CTGPMenuSingle.Size = new System.Drawing.Size(156, 35);
            this.CTGPMenuSingle.TabIndex = 1;
            this.CTGPMenuSingle.Text = "Patch MenuSingle CTGP";
            this.CTGPMenuSingle.UseVisualStyleBackColor = true;
            this.CTGPMenuSingle.Click += new System.EventHandler(this.CTGPMenuSingle_Click);
            // 
            // DolphinMenuSingle
            // 
            this.DolphinMenuSingle.Location = new System.Drawing.Point(608, 106);
            this.DolphinMenuSingle.Name = "DolphinMenuSingle";
            this.DolphinMenuSingle.Size = new System.Drawing.Size(156, 35);
            this.DolphinMenuSingle.TabIndex = 2;
            this.DolphinMenuSingle.Text = "Patch MenuSingle Dolphin";
            this.DolphinMenuSingle.UseVisualStyleBackColor = true;
            this.DolphinMenuSingle.Click += new System.EventHandler(this.DolphinMenuSingle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DolphinMenuSingle);
            this.Controls.Add(this.CTGPMenuSingle);
            this.Controls.Add(this.ExtractMenuSingle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExtractMenuSingle;
        private System.Windows.Forms.Button CTGPMenuSingle;
        private System.Windows.Forms.Button DolphinMenuSingle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

