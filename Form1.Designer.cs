namespace TanulmanyiRendszerUjra
{
    partial class BejelentkezoForm
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
            this.rbH = new System.Windows.Forms.RadioButton();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(360, 77);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(79, 20);
            this.rbH.TabIndex = 0;
            this.rbH.TabStop = true;
            this.rbH.Text = "Hallgató";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(360, 103);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(67, 20);
            this.rbO.TabIndex = 1;
            this.rbO.TabStop = true;
            this.rbO.Text = "Oktató";
            this.rbO.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(360, 129);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(112, 20);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.Text = "Adminisztrátor";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(265, 209);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(206, 46);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Bejelentkezés";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbKod
            // 
            this.tbKod.Location = new System.Drawing.Point(81, 86);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(154, 22);
            this.tbKod.TabIndex = 6;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(81, 179);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(154, 22);
            this.tbJelszo.TabIndex = 7;
            // 
            // BejelentkezoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 304);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.rbO);
            this.Controls.Add(this.rbH);
            this.Name = "BejelentkezoForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.TextBox tbJelszo;
    }
}

