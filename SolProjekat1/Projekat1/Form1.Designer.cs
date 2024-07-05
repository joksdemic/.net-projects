namespace Projekat1
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
            this.components = new System.ComponentModel.Container();
            this.PopupMeni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtPronadji = new System.Windows.Forms.TextBox();
            this.txtZameni = new System.Windows.Forms.TextBox();
            this.lblPronadji = new System.Windows.Forms.Label();
            this.lblZameni = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.PopupMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopupMeni
            // 
            this.PopupMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBoldToolStripMenuItem,
            this.fontItalicToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectFontToolStripMenuItem});
            this.PopupMeni.Name = "PopupMeni";
            this.PopupMeni.Size = new System.Drawing.Size(131, 98);
            // 
            // fontBoldToolStripMenuItem
            // 
            this.fontBoldToolStripMenuItem.Name = "fontBoldToolStripMenuItem";
            this.fontBoldToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fontBoldToolStripMenuItem.Text = "Font bold";
            this.fontBoldToolStripMenuItem.Click += new System.EventHandler(this.fontBoldToolStripMenuItem_Click);
            // 
            // fontItalicToolStripMenuItem
            // 
            this.fontItalicToolStripMenuItem.Name = "fontItalicToolStripMenuItem";
            this.fontItalicToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fontItalicToolStripMenuItem.Text = "Font italic";
            this.fontItalicToolStripMenuItem.Click += new System.EventHandler(this.fontItalicToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fontColorToolStripMenuItem.Text = "Font color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.selectFontToolStripMenuItem.Text = "Select font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.PopupMeni;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(12, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPronadji
            // 
            this.txtPronadji.Location = new System.Drawing.Point(204, 19);
            this.txtPronadji.Name = "txtPronadji";
            this.txtPronadji.Size = new System.Drawing.Size(146, 20);
            this.txtPronadji.TabIndex = 6;
            this.txtPronadji.TextChanged += new System.EventHandler(this.txtPronadji_TextChanged);
            // 
            // txtZameni
            // 
            this.txtZameni.Location = new System.Drawing.Point(204, 67);
            this.txtZameni.Name = "txtZameni";
            this.txtZameni.Size = new System.Drawing.Size(146, 20);
            this.txtZameni.TabIndex = 7;
            this.txtZameni.TextChanged += new System.EventHandler(this.txZameni_TextChanged);
            // 
            // lblPronadji
            // 
            this.lblPronadji.AutoSize = true;
            this.lblPronadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPronadji.Location = new System.Drawing.Point(134, 19);
            this.lblPronadji.Name = "lblPronadji";
            this.lblPronadji.Size = new System.Drawing.Size(64, 17);
            this.lblPronadji.TabIndex = 8;
            this.lblPronadji.Text = "Pronadji:";
            this.lblPronadji.Click += new System.EventHandler(this.lblPronadji_Click);
            // 
            // lblZameni
            // 
            this.lblZameni.AutoSize = true;
            this.lblZameni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblZameni.Location = new System.Drawing.Point(133, 67);
            this.lblZameni.Name = "lblZameni";
            this.lblZameni.Size = new System.Drawing.Size(78, 17);
            this.lblZameni.TabIndex = 9;
            this.lblZameni.Text = "Zameni sa:";
            this.lblZameni.Click += new System.EventHandler(this.lblZameni_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Image = global::Projekat1.Properties.Resources.Save_37110;
            this.btnSacuvaj.Location = new System.Drawing.Point(481, 12);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(113, 97);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Snimi fajl (Save as)";
            this.btnSacuvaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZavrsi.Image = global::Projekat1.Properties.Resources.close_111152;
            this.btnZavrsi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZavrsi.Location = new System.Drawing.Point(721, 12);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(77, 87);
            this.btnZavrsi.TabIndex = 4;
            this.btnZavrsi.Text = "Zavrsi program";
            this.btnZavrsi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnPronadji
            // 
            this.btnPronadji.Image = global::Projekat1.Properties.Resources.actions_find_and_replace_15783__1_;
            this.btnPronadji.Location = new System.Drawing.Point(356, 12);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(110, 97);
            this.btnPronadji.TabIndex = 3;
            this.btnPronadji.Text = "Pronadji i zameni";
            this.btnPronadji.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOtvori.Image = global::Projekat1.Properties.Resources.open_file256_25211__3_;
            this.btnOtvori.Location = new System.Drawing.Point(12, 12);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(115, 97);
            this.btnOtvori.TabIndex = 2;
            this.btnOtvori.Text = "Otvori fajl";
            this.btnOtvori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZameni);
            this.Controls.Add(this.lblPronadji);
            this.Controls.Add(this.txtZameni);
            this.Controls.Add(this.txtPronadji);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Projekat 1. kolokvijumska nedelja Jovana Demic S9-20";
            this.PopupMeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip PopupMeni;
        private System.Windows.Forms.ToolStripMenuItem fontBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtPronadji;
        private System.Windows.Forms.TextBox txtZameni;
        private System.Windows.Forms.Label lblPronadji;
        private System.Windows.Forms.Label lblZameni;
    }
}

