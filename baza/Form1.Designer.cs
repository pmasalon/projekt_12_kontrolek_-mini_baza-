
namespace baza
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pesel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybCiemnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybJasnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ankietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.index = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imie
            // 
            this.imie.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imie.Location = new System.Drawing.Point(284, 250);
            this.imie.MaxLength = 15;
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(175, 24);
            this.imie.TabIndex = 1;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(284, 280);
            this.nazwisko.MaxLength = 20;
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(175, 24);
            this.nazwisko.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(123, 256);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 18);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Podaj imię:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj nazwisko:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Podaj pesel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(122, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "WPROWADŹ DANE DO BAZY";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Wyślij do bazy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 24);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "IMIĘ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(821, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(157, 24);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "NAZWISKO";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(984, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(105, 24);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "PESEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Indeks:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(652, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(437, 24);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(652, 100);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(437, 24);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(652, 130);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(437, 24);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(652, 160);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(437, 24);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(652, 190);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(437, 24);
            this.textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(652, 220);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(437, 24);
            this.textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(652, 250);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(437, 24);
            this.textBox10.TabIndex = 22;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(652, 280);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(437, 24);
            this.textBox11.TabIndex = 23;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(652, 310);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(437, 24);
            this.textBox12.TabIndex = 24;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(653, 343);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(437, 24);
            this.textBox13.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(653, 40);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(28, 24);
            this.textBox14.TabIndex = 26;
            this.textBox14.Text = "ID";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(652, 405);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 23);
            this.progressBar1.TabIndex = 28;
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(284, 310);
            this.pesel.Mask = "00000000000";
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(175, 24);
            this.pesel.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Dodano do bazy.";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(126, 364);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(114, 38);
            this.Export.TabIndex = 33;
            this.Export.Text = "Export do txt";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1206, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "MENU";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AccessibleDescription = "MENU";
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.ankietaToolStripMenuItem,
            this.oAutorzeToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "MENU";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trybCiemnyToolStripMenuItem,
            this.trybJasnyToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // trybCiemnyToolStripMenuItem
            // 
            this.trybCiemnyToolStripMenuItem.Name = "trybCiemnyToolStripMenuItem";
            this.trybCiemnyToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.trybCiemnyToolStripMenuItem.Text = "Tryb ciemny";
            this.trybCiemnyToolStripMenuItem.Click += new System.EventHandler(this.trybCiemnyToolStripMenuItem_Click);
            // 
            // trybJasnyToolStripMenuItem
            // 
            this.trybJasnyToolStripMenuItem.Name = "trybJasnyToolStripMenuItem";
            this.trybJasnyToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.trybJasnyToolStripMenuItem.Text = "Tryb jasny";
            this.trybJasnyToolStripMenuItem.Click += new System.EventHandler(this.trybJasnyToolStripMenuItem_Click);
            // 
            // ankietaToolStripMenuItem
            // 
            this.ankietaToolStripMenuItem.Name = "ankietaToolStripMenuItem";
            this.ankietaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ankietaToolStripMenuItem.Text = "Ankieta";
            this.ankietaToolStripMenuItem.Click += new System.EventHandler(this.ankietaToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.oAutorzeToolStripMenuItem.Text = "O autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(284, 221);
            this.index.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Size = new System.Drawing.Size(47, 24);
            this.index.TabIndex = 35;
            this.index.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 469);
            this.Controls.Add(this.index);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BAZA DANYCH - PAWEŁ MASALON";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MaskedTextBox pesel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybCiemnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybJasnyToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown index;
        private System.Windows.Forms.ToolStripMenuItem ankietaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
    }
}

