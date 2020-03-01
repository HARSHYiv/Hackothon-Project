namespace Project
{
    partial class Display
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
            this.lblResults = new System.Windows.Forms.Label();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(261, 38);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(192, 58);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results";
            // 
            // lbxResults
            // 
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 16;
            this.lbxResults.Location = new System.Drawing.Point(33, 126);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(733, 276);
            this.lbxResults.TabIndex = 2;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.lblResults);
            this.Name = "Display";
            this.Text = "Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lbxResults;
    }
}