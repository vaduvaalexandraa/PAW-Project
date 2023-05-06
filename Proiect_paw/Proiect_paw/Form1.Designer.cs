namespace Proiect_paw
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
            this.tbIDIm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipIm = new System.Windows.Forms.ComboBox();
            this.tbAdresaIm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSuprafata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNrCamIm = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPretIm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescriereIm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btImob = new System.Windows.Forms.Button();
            this.btVizIm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericNrCamIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDIm
            // 
            this.tbIDIm.Location = new System.Drawing.Point(428, 27);
            this.tbIDIm.Name = "tbIDIm";
            this.tbIDIm.Size = new System.Drawing.Size(125, 26);
            this.tbIDIm.TabIndex = 0;
            this.tbIDIm.Validating += new System.ComponentModel.CancelEventHandler(this.tbIDIm_Validating);
            this.tbIDIm.Validated += new System.EventHandler(this.tbIDIm_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Imobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip Imobil";
            // 
            // cbTipIm
            // 
            this.cbTipIm.FormattingEnabled = true;
            this.cbTipIm.Items.AddRange(new object[] {
            "Apartament",
            "Casa",
            "Duplex",
            "Vila",
            "Garsoniera",
            "Penthouse"});
            this.cbTipIm.Location = new System.Drawing.Point(428, 78);
            this.cbTipIm.Name = "cbTipIm";
            this.cbTipIm.Size = new System.Drawing.Size(165, 28);
            this.cbTipIm.TabIndex = 4;
            // 
            // tbAdresaIm
            // 
            this.tbAdresaIm.Location = new System.Drawing.Point(428, 131);
            this.tbAdresaIm.Name = "tbAdresaIm";
            this.tbAdresaIm.Size = new System.Drawing.Size(348, 26);
            this.tbAdresaIm.TabIndex = 5;
            this.tbAdresaIm.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresaIm_Validating);
            this.tbAdresaIm.Validated += new System.EventHandler(this.tbAdresaIm_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbSuprafata
            // 
            this.tbSuprafata.Location = new System.Drawing.Point(428, 183);
            this.tbSuprafata.Name = "tbSuprafata";
            this.tbSuprafata.Size = new System.Drawing.Size(121, 26);
            this.tbSuprafata.TabIndex = 7;
            this.tbSuprafata.Validating += new System.ComponentModel.CancelEventHandler(this.tbSuprafata_Validating);
            this.tbSuprafata.Validated += new System.EventHandler(this.tbSuprafata_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Suprafata utila";
            // 
            // numericNrCamIm
            // 
            this.numericNrCamIm.Location = new System.Drawing.Point(429, 240);
            this.numericNrCamIm.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNrCamIm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNrCamIm.Name = "numericNrCamIm";
            this.numericNrCamIm.Size = new System.Drawing.Size(120, 26);
            this.numericNrCamIm.TabIndex = 9;
            this.numericNrCamIm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNrCamIm.Validating += new System.ComponentModel.CancelEventHandler(this.numericNrCamIm_Validating);
            this.numericNrCamIm.Validated += new System.EventHandler(this.numericNrCamIm_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nr camere";
            // 
            // tbPretIm
            // 
            this.tbPretIm.Location = new System.Drawing.Point(428, 298);
            this.tbPretIm.Name = "tbPretIm";
            this.tbPretIm.Size = new System.Drawing.Size(121, 26);
            this.tbPretIm.TabIndex = 11;
            this.tbPretIm.Validating += new System.ComponentModel.CancelEventHandler(this.tbPretIm_Validating);
            this.tbPretIm.Validated += new System.EventHandler(this.tbPretIm_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pret";
            // 
            // tbDescriereIm
            // 
            this.tbDescriereIm.Location = new System.Drawing.Point(429, 349);
            this.tbDescriereIm.Name = "tbDescriereIm";
            this.tbDescriereIm.Size = new System.Drawing.Size(347, 26);
            this.tbDescriereIm.TabIndex = 13;
            this.tbDescriereIm.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescriereIm_Validating);
            this.tbDescriereIm.Validated += new System.EventHandler(this.tbDescriereIm_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descriere imobil";
            // 
            // btImob
            // 
            this.btImob.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btImob.Location = new System.Drawing.Point(350, 423);
            this.btImob.Name = "btImob";
            this.btImob.Size = new System.Drawing.Size(146, 56);
            this.btImob.TabIndex = 15;
            this.btImob.Text = "&Adauga Imobil";
            this.btImob.UseVisualStyleBackColor = true;
            this.btImob.Click += new System.EventHandler(this.btImob_Click);
            // 
            // btVizIm
            // 
            this.btVizIm.Location = new System.Drawing.Point(665, 423);
            this.btVizIm.Name = "btVizIm";
            this.btVizIm.Size = new System.Drawing.Size(161, 56);
            this.btVizIm.TabIndex = 16;
            this.btVizIm.Text = "&Vizualizare Imobile";
            this.btVizIm.UseVisualStyleBackColor = true;
            this.btVizIm.Click += new System.EventHandler(this.btVizIm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 670);
            this.Controls.Add(this.btVizIm);
            this.Controls.Add(this.btImob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescriereIm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPretIm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericNrCamIm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSuprafata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAdresaIm);
            this.Controls.Add(this.cbTipIm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDIm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNrCamIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDIm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipIm;
        private System.Windows.Forms.TextBox tbAdresaIm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSuprafata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNrCamIm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPretIm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescriereIm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImob;
        private System.Windows.Forms.Button btVizIm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

