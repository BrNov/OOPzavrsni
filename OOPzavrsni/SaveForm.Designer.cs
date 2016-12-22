namespace OOPzavrsni
{
    partial class SaveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.daButton = new System.Windows.Forms.Button();
            this.neButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Želite li spremiti promjene?";
            // 
            // daButton
            // 
            this.daButton.Location = new System.Drawing.Point(106, 90);
            this.daButton.Name = "daButton";
            this.daButton.Size = new System.Drawing.Size(75, 23);
            this.daButton.TabIndex = 1;
            this.daButton.Text = "Da";
            this.daButton.UseVisualStyleBackColor = true;
            this.daButton.Click += new System.EventHandler(this.daButton_Click);
            // 
            // neButton
            // 
            this.neButton.Location = new System.Drawing.Point(195, 90);
            this.neButton.Name = "neButton";
            this.neButton.Size = new System.Drawing.Size(75, 23);
            this.neButton.TabIndex = 2;
            this.neButton.Text = "Ne";
            this.neButton.UseVisualStyleBackColor = true;
            this.neButton.Click += new System.EventHandler(this.neButton_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 169);
            this.Controls.Add(this.neButton);
            this.Controls.Add(this.daButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spremi..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button daButton;
        private System.Windows.Forms.Button neButton;
    }
}