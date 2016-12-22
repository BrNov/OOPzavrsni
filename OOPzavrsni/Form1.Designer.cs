namespace OOPzavrsni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.linijaButton = new System.Windows.Forms.ToolStripButton();
            this.kruznicaButton = new System.Windows.Forms.ToolStripButton();
            this.pravokutnikButton = new System.Windows.Forms.ToolStripButton();
            this.trokutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ocistiPapir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bojaButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ispunaButton = new System.Windows.Forms.ToolStripButton();
            this.ispunaCollor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.debljinaTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.plusButton = new System.Windows.Forms.ToolStripButton();
            this.minusButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::OOPzavrsni.Properties.Resources.undo_button_318_76442;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linijaButton,
            this.kruznicaButton,
            this.pravokutnikButton,
            this.trokutButton,
            this.toolStripSeparator1,
            this.ocistiPapir,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.bojaButton,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.ispunaButton,
            this.ispunaCollor,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.debljinaTextBox,
            this.plusButton,
            this.minusButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(621, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // linijaButton
            // 
            this.linijaButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.linijaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linijaButton.Image = ((System.Drawing.Image)(resources.GetObject("linijaButton.Image")));
            this.linijaButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.linijaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linijaButton.Name = "linijaButton";
            this.linijaButton.Size = new System.Drawing.Size(34, 54);
            this.linijaButton.Text = "Linija";
            this.linijaButton.ToolTipText = "Linija";
            this.linijaButton.Click += new System.EventHandler(this.linijaButton_Click);
            // 
            // kruznicaButton
            // 
            this.kruznicaButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kruznicaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kruznicaButton.Image = ((System.Drawing.Image)(resources.GetObject("kruznicaButton.Image")));
            this.kruznicaButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kruznicaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kruznicaButton.Name = "kruznicaButton";
            this.kruznicaButton.Size = new System.Drawing.Size(34, 54);
            this.kruznicaButton.Text = "Kruznica";
            this.kruznicaButton.Click += new System.EventHandler(this.kruznicaButton_Click);
            // 
            // pravokutnikButton
            // 
            this.pravokutnikButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pravokutnikButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pravokutnikButton.Image = ((System.Drawing.Image)(resources.GetObject("pravokutnikButton.Image")));
            this.pravokutnikButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pravokutnikButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pravokutnikButton.Name = "pravokutnikButton";
            this.pravokutnikButton.Size = new System.Drawing.Size(34, 54);
            this.pravokutnikButton.Text = "Pravokutnik";
            this.pravokutnikButton.Click += new System.EventHandler(this.pravokutnikButton_Click);
            // 
            // trokutButton
            // 
            this.trokutButton.AutoSize = false;
            this.trokutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trokutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trokutButton.Image = global::OOPzavrsni.Properties.Resources.trokut;
            this.trokutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trokutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trokutButton.Name = "trokutButton";
            this.trokutButton.Size = new System.Drawing.Size(34, 54);
            this.trokutButton.Text = "Trokut";
            this.trokutButton.Click += new System.EventHandler(this.trokutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // ocistiPapir
            // 
            this.ocistiPapir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ocistiPapir.Image = ((System.Drawing.Image)(resources.GetObject("ocistiPapir.Image")));
            this.ocistiPapir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ocistiPapir.Name = "ocistiPapir";
            this.ocistiPapir.Size = new System.Drawing.Size(71, 54);
            this.ocistiPapir.Text = "Očisti papir";
            this.ocistiPapir.Click += new System.EventHandler(this.ocistiPapir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 54);
            this.toolStripLabel1.Text = "Boja:";
            // 
            // bojaButton
            // 
            this.bojaButton.AutoSize = false;
            this.bojaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bojaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bojaButton.Image = ((System.Drawing.Image)(resources.GetObject("bojaButton.Image")));
            this.bojaButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bojaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bojaButton.Name = "bojaButton";
            this.bojaButton.Size = new System.Drawing.Size(20, 20);
            this.bojaButton.Text = "Boja";
            this.bojaButton.Click += new System.EventHandler(this.bojaButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 54);
            this.toolStripLabel2.Text = "Ispuna:";
            // 
            // ispunaButton
            // 
            this.ispunaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ispunaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ispunaButton.Image = global::OOPzavrsni.Properties.Resources.o_b90d192cf4f4006b_0;
            this.ispunaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ispunaButton.Name = "ispunaButton";
            this.ispunaButton.Size = new System.Drawing.Size(23, 54);
            this.ispunaButton.Text = "Oznaci za ispunu";
            this.ispunaButton.Click += new System.EventHandler(this.ispunaButton_Click);
            // 
            // ispunaCollor
            // 
            this.ispunaCollor.AutoSize = false;
            this.ispunaCollor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ispunaCollor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ispunaCollor.Image = ((System.Drawing.Image)(resources.GetObject("ispunaCollor.Image")));
            this.ispunaCollor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ispunaCollor.Name = "ispunaCollor";
            this.ispunaCollor.Size = new System.Drawing.Size(20, 20);
            this.ispunaCollor.Text = "Ispuna";
            this.ispunaCollor.Click += new System.EventHandler(this.ispunaCollor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(81, 54);
            this.toolStripLabel3.Text = "Debljina linije:";
            // 
            // debljinaTextBox
            // 
            this.debljinaTextBox.AutoSize = false;
            this.debljinaTextBox.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.debljinaTextBox.Name = "debljinaTextBox";
            this.debljinaTextBox.ReadOnly = true;
            this.debljinaTextBox.Size = new System.Drawing.Size(70, 57);
            this.debljinaTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plusButton
            // 
            this.plusButton.AutoSize = false;
            this.plusButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.plusButton.Image = ((System.Drawing.Image)(resources.GetObject("plusButton.Image")));
            this.plusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plusButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(20, 20);
            this.plusButton.Text = "+";
            this.plusButton.ToolTipText = "+";
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.AutoSize = false;
            this.minusButton.BackColor = System.Drawing.SystemColors.Control;
            this.minusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minusButton.Image = ((System.Drawing.Image)(resources.GetObject("minusButton.Image")));
            this.minusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(20, 20);
            this.minusButton.Text = "-";
            this.minusButton.ToolTipText = "-";
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.drawPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 396);
            this.panel1.TabIndex = 2;
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.Control;
            this.drawPanel.Location = new System.Drawing.Point(12, 16);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(597, 366);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG Image|*.jpg|PNG Image|*.png|GIF Image|*.gif";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton linijaButton;
        private System.Windows.Forms.ToolStripButton kruznicaButton;
        private System.Windows.Forms.ToolStripButton pravokutnikButton;
        private System.Windows.Forms.ToolStripButton bojaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton ocistiPapir;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton trokutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ispunaButton;
        private System.Windows.Forms.ToolStripButton ispunaCollor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox debljinaTextBox;
        private System.Windows.Forms.ToolStripButton plusButton;
        private System.Windows.Forms.ToolStripButton minusButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

