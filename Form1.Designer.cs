namespace WinForm
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
            this.numeric_azonosito = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_szuletett = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.combobox_holszuletett = new System.Windows.Forms.ComboBox();
            this.button_elkuld = new System.Windows.Forms.Button();
            this.radio_angol = new System.Windows.Forms.RadioButton();
            this.radio_nemet = new System.Windows.Forms.RadioButton();
            this.radio_francia = new System.Windows.Forms.RadioButton();
            this.radio_olasz = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_azonosito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeric_azonosito
            // 
            this.numeric_azonosito.Location = new System.Drawing.Point(133, 30);
            this.numeric_azonosito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_azonosito.Name = "numeric_azonosito";
            this.numeric_azonosito.Size = new System.Drawing.Size(162, 26);
            this.numeric_azonosito.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonositó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(302, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textbox_nev
            // 
            this.textbox_nev.Location = new System.Drawing.Point(358, 32);
            this.textbox_nev.Name = "textbox_nev";
            this.textbox_nev.Size = new System.Drawing.Size(162, 26);
            this.textbox_nev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Milyen nyelven szeretne beszélni?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mikor született?";
            // 
            // date_szuletett
            // 
            this.date_szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_szuletett.Location = new System.Drawing.Point(23, 256);
            this.date_szuletett.Name = "date_szuletett";
            this.date_szuletett.Size = new System.Drawing.Size(116, 26);
            this.date_szuletett.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 304);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hol született?";
            // 
            // combobox_holszuletett
            // 
            this.combobox_holszuletett.FormattingEnabled = true;
            this.combobox_holszuletett.Items.AddRange(new object[] {
            "Budapest",
            "Debrecen",
            "Szeged",
            "Pécs",
            "Miskolc",
            "Nyiregyháza"});
            this.combobox_holszuletett.Location = new System.Drawing.Point(23, 332);
            this.combobox_holszuletett.Name = "combobox_holszuletett";
            this.combobox_holszuletett.Size = new System.Drawing.Size(121, 28);
            this.combobox_holszuletett.TabIndex = 9;
            // 
            // button_elkuld
            // 
            this.button_elkuld.Location = new System.Drawing.Point(412, 417);
            this.button_elkuld.Name = "button_elkuld";
            this.button_elkuld.Size = new System.Drawing.Size(130, 49);
            this.button_elkuld.TabIndex = 10;
            this.button_elkuld.Text = "Beküldés";
            this.button_elkuld.UseVisualStyleBackColor = true;
            this.button_elkuld.Click += new System.EventHandler(this.button_elkuld_Click);
            // 
            // radio_angol
            // 
            this.radio_angol.AutoSize = true;
            this.radio_angol.Location = new System.Drawing.Point(18, 31);
            this.radio_angol.Name = "radio_angol";
            this.radio_angol.Size = new System.Drawing.Size(68, 24);
            this.radio_angol.TabIndex = 11;
            this.radio_angol.TabStop = true;
            this.radio_angol.Text = "Angol";
            this.radio_angol.UseVisualStyleBackColor = true;
            // 
            // radio_nemet
            // 
            this.radio_nemet.AutoSize = true;
            this.radio_nemet.Location = new System.Drawing.Point(18, 61);
            this.radio_nemet.Name = "radio_nemet";
            this.radio_nemet.Size = new System.Drawing.Size(74, 24);
            this.radio_nemet.TabIndex = 12;
            this.radio_nemet.TabStop = true;
            this.radio_nemet.Text = "Német";
            this.radio_nemet.UseVisualStyleBackColor = true;
            // 
            // radio_francia
            // 
            this.radio_francia.AutoSize = true;
            this.radio_francia.Location = new System.Drawing.Point(143, 31);
            this.radio_francia.Name = "radio_francia";
            this.radio_francia.Size = new System.Drawing.Size(80, 24);
            this.radio_francia.TabIndex = 13;
            this.radio_francia.TabStop = true;
            this.radio_francia.Text = "Francia";
            this.radio_francia.UseVisualStyleBackColor = true;
            // 
            // radio_olasz
            // 
            this.radio_olasz.AutoSize = true;
            this.radio_olasz.Location = new System.Drawing.Point(143, 61);
            this.radio_olasz.Name = "radio_olasz";
            this.radio_olasz.Size = new System.Drawing.Size(67, 24);
            this.radio_olasz.TabIndex = 14;
            this.radio_olasz.TabStop = true;
            this.radio_olasz.Text = "Olasz";
            this.radio_olasz.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_angol);
            this.groupBox1.Controls.Add(this.radio_olasz);
            this.groupBox1.Controls.Add(this.radio_nemet);
            this.groupBox1.Controls.Add(this.radio_francia);
            this.groupBox1.Location = new System.Drawing.Point(23, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(569, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_elkuld);
            this.Controls.Add(this.combobox_holszuletett);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_szuletett);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_azonosito);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_azonosito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_azonosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_szuletett;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobox_holszuletett;
        private System.Windows.Forms.Button button_elkuld;
        private System.Windows.Forms.RadioButton radio_angol;
        private System.Windows.Forms.RadioButton radio_nemet;
        private System.Windows.Forms.RadioButton radio_francia;
        private System.Windows.Forms.RadioButton radio_olasz;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

