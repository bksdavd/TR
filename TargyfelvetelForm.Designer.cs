namespace TanulmanyiRendszerUjra
{
    partial class TargyfelvetelForm
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
            this.btnLead = new System.Windows.Forms.Button();
            this.btnFelvetel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFelvettek = new System.Windows.Forms.ListBox();
            this.lbTargyak = new System.Windows.Forms.ListBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLead
            // 
            this.btnLead.Location = new System.Drawing.Point(311, 377);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(188, 45);
            this.btnLead.TabIndex = 15;
            this.btnLead.Text = "Tárgy leadása";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // btnFelvetel
            // 
            this.btnFelvetel.Location = new System.Drawing.Point(38, 377);
            this.btnFelvetel.Name = "btnFelvetel";
            this.btnFelvetel.Size = new System.Drawing.Size(188, 45);
            this.btnFelvetel.TabIndex = 14;
            this.btnFelvetel.Text = "Tárgy felvétele";
            this.btnFelvetel.UseVisualStyleBackColor = true;
            this.btnFelvetel.Click += new System.EventHandler(this.btnFelvetel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Felvett Tárgyak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tárgyak";
            // 
            // lbFelvettek
            // 
            this.lbFelvettek.FormattingEnabled = true;
            this.lbFelvettek.ItemHeight = 16;
            this.lbFelvettek.Location = new System.Drawing.Point(312, 150);
            this.lbFelvettek.Name = "lbFelvettek";
            this.lbFelvettek.Size = new System.Drawing.Size(187, 212);
            this.lbFelvettek.TabIndex = 11;
            // 
            // lbTargyak
            // 
            this.lbTargyak.FormattingEnabled = true;
            this.lbTargyak.ItemHeight = 16;
            this.lbTargyak.Location = new System.Drawing.Point(38, 150);
            this.lbTargyak.Name = "lbTargyak";
            this.lbTargyak.Size = new System.Drawing.Size(188, 212);
            this.lbTargyak.TabIndex = 10;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(15, 51);
            this.tbNev.Name = "tbNev";
            this.tbNev.ReadOnly = true;
            this.tbNev.Size = new System.Drawing.Size(211, 22);
            this.tbNev.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bejelentkező hallgató neve (kódja)";
            // 
            // TargyfelvetelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.btnFelvetel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFelvettek);
            this.Controls.Add(this.lbTargyak);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "TargyfelvetelForm";
            this.Text = "TargyfelvetelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TargyfelvetelForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.Button btnFelvetel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFelvettek;
        private System.Windows.Forms.ListBox lbTargyak;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label1;
    }
}