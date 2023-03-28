namespace TanulmanyiRendszerUjra
{
    partial class AdmForm
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
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHMent = new System.Windows.Forms.Button();
            this.chbF = new System.Windows.Forms.CheckBox();
            this.chbT = new System.Windows.Forms.CheckBox();
            this.cobSzerep = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.tbFKod = new System.Windows.Forms.TextBox();
            this.tbFNev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudKredit = new System.Windows.Forms.NumericUpDown();
            this.btnTMent = new System.Windows.Forms.Button();
            this.tbTKod = new System.Windows.Forms.TextBox();
            this.tbTNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFelhasznalo = new System.Windows.Forms.RadioButton();
            this.rbTargy = new System.Windows.Forms.RadioButton();
            this.tbBelepve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(200, 486);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(197, 55);
            this.btnKilep.TabIndex = 30;
            this.btnKilep.Text = "Kilépés mentés nélkül";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(200, 425);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(197, 55);
            this.btnMentes.TabIndex = 29;
            this.btnMentes.Text = "Mentés és kilépés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHMent);
            this.groupBox2.Controls.Add(this.chbF);
            this.groupBox2.Controls.Add(this.chbT);
            this.groupBox2.Controls.Add(this.cobSzerep);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbJelszo);
            this.groupBox2.Controls.Add(this.tbFKod);
            this.groupBox2.Controls.Add(this.tbFNev);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(312, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 274);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnHMent
            // 
            this.btnHMent.Location = new System.Drawing.Point(112, 208);
            this.btnHMent.Name = "btnHMent";
            this.btnHMent.Size = new System.Drawing.Size(197, 55);
            this.btnHMent.TabIndex = 13;
            this.btnHMent.Text = "Felhasználó mentése listába";
            this.btnHMent.UseVisualStyleBackColor = true;
            this.btnHMent.Click += new System.EventHandler(this.btnHMent_Click);
            // 
            // chbF
            // 
            this.chbF.AutoSize = true;
            this.chbF.Location = new System.Drawing.Point(230, 114);
            this.chbF.Name = "chbF";
            this.chbF.Size = new System.Drawing.Size(124, 20);
            this.chbF.TabIndex = 20;
            this.chbF.Text = "Felhasználó jog";
            this.chbF.UseVisualStyleBackColor = true;
            // 
            // chbT
            // 
            this.chbT.AutoSize = true;
            this.chbT.Location = new System.Drawing.Point(230, 78);
            this.chbT.Name = "chbT";
            this.chbT.Size = new System.Drawing.Size(93, 20);
            this.chbT.TabIndex = 19;
            this.chbT.Text = "Tanuló jog";
            this.chbT.UseVisualStyleBackColor = true;
            // 
            // cobSzerep
            // 
            this.cobSzerep.FormattingEnabled = true;
            this.cobSzerep.Items.AddRange(new object[] {
            "Hallgató",
            "Oktató",
            "Adminisztrátor"});
            this.cobSzerep.Location = new System.Drawing.Point(203, 37);
            this.cobSzerep.Name = "cobSzerep";
            this.cobSzerep.Size = new System.Drawing.Size(121, 24);
            this.cobSzerep.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Felhasználó szerepe:";
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(9, 177);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(106, 22);
            this.tbJelszo.TabIndex = 16;
            // 
            // tbFKod
            // 
            this.tbFKod.Location = new System.Drawing.Point(9, 114);
            this.tbFKod.Name = "tbFKod";
            this.tbFKod.Size = new System.Drawing.Size(106, 22);
            this.tbFKod.TabIndex = 15;
            // 
            // tbFNev
            // 
            this.tbFNev.Location = new System.Drawing.Point(9, 37);
            this.tbFNev.Name = "tbFNev";
            this.tbFNev.Size = new System.Drawing.Size(106, 22);
            this.tbFNev.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Jelszó:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Felhasználó kódja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Felhasználó neve:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudKredit);
            this.groupBox1.Controls.Add(this.btnTMent);
            this.groupBox1.Controls.Add(this.tbTKod);
            this.groupBox1.Controls.Add(this.tbTNev);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 274);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nudKredit
            // 
            this.nudKredit.Location = new System.Drawing.Point(9, 177);
            this.nudKredit.Name = "nudKredit";
            this.nudKredit.Size = new System.Drawing.Size(120, 22);
            this.nudKredit.TabIndex = 12;
            // 
            // btnTMent
            // 
            this.btnTMent.Location = new System.Drawing.Point(42, 208);
            this.btnTMent.Name = "btnTMent";
            this.btnTMent.Size = new System.Drawing.Size(152, 55);
            this.btnTMent.TabIndex = 11;
            this.btnTMent.Text = "Tárgy mentése listába";
            this.btnTMent.UseVisualStyleBackColor = true;
            this.btnTMent.Click += new System.EventHandler(this.btnTMent_Click);
            // 
            // tbTKod
            // 
            this.tbTKod.Location = new System.Drawing.Point(9, 105);
            this.tbTKod.Name = "tbTKod";
            this.tbTKod.Size = new System.Drawing.Size(100, 22);
            this.tbTKod.TabIndex = 10;
            // 
            // tbTNev
            // 
            this.tbTNev.Location = new System.Drawing.Point(9, 37);
            this.tbTNev.Name = "tbTNev";
            this.tbTNev.Size = new System.Drawing.Size(100, 22);
            this.tbTNev.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tárgy kódja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kredit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tárgy neve:";
            // 
            // rbFelhasznalo
            // 
            this.rbFelhasznalo.AutoSize = true;
            this.rbFelhasznalo.Location = new System.Drawing.Point(312, 75);
            this.rbFelhasznalo.Name = "rbFelhasznalo";
            this.rbFelhasznalo.Size = new System.Drawing.Size(178, 20);
            this.rbFelhasznalo.TabIndex = 26;
            this.rbFelhasznalo.Text = "Felhasználó hozzáadása";
            this.rbFelhasznalo.UseVisualStyleBackColor = true;
            // 
            // rbTargy
            // 
            this.rbTargy.AutoSize = true;
            this.rbTargy.Checked = true;
            this.rbTargy.Location = new System.Drawing.Point(31, 75);
            this.rbTargy.Name = "rbTargy";
            this.rbTargy.Size = new System.Drawing.Size(141, 20);
            this.rbTargy.TabIndex = 25;
            this.rbTargy.TabStop = true;
            this.rbTargy.Text = "Tárgy hozzáadása";
            this.rbTargy.UseVisualStyleBackColor = true;
            this.rbTargy.CheckedChanged += new System.EventHandler(this.rbTargy_CheckedChanged);
            // 
            // tbBelepve
            // 
            this.tbBelepve.Location = new System.Drawing.Point(73, 12);
            this.tbBelepve.Name = "tbBelepve";
            this.tbBelepve.ReadOnly = true;
            this.tbBelepve.Size = new System.Drawing.Size(100, 22);
            this.tbBelepve.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Belépve :";
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 556);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbFelhasznalo);
            this.Controls.Add(this.rbTargy);
            this.Controls.Add(this.tbBelepve);
            this.Controls.Add(this.label1);
            this.Name = "AdmForm";
            this.Text = "AdmForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmForm_FormClosing);
            this.Load += new System.EventHandler(this.AdmForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHMent;
        private System.Windows.Forms.CheckBox chbF;
        private System.Windows.Forms.CheckBox chbT;
        private System.Windows.Forms.ComboBox cobSzerep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.TextBox tbFKod;
        private System.Windows.Forms.TextBox tbFNev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudKredit;
        private System.Windows.Forms.Button btnTMent;
        private System.Windows.Forms.TextBox tbTKod;
        private System.Windows.Forms.TextBox tbTNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFelhasznalo;
        private System.Windows.Forms.RadioButton rbTargy;
        private System.Windows.Forms.TextBox tbBelepve;
        private System.Windows.Forms.Label label1;
    }
}