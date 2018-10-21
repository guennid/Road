namespace Oldtimer
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonSaveFahrzeug = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxkmmiles = new System.Windows.Forms.ComboBox();
            this.textBoxLeistung = new System.Windows.Forms.TextBox();
            this.labelLeistung = new System.Windows.Forms.Label();
            this.textBoxHoechstgeschwindigkeit = new System.Windows.Forms.TextBox();
            this.labelHoechstgeschwindigkeit = new System.Windows.Forms.Label();
            this.textBoxAntriebsart = new System.Windows.Forms.TextBox();
            this.labelAntriebsart = new System.Windows.Forms.Label();
            this.textBoxIdentifikation = new System.Windows.Forms.TextBox();
            this.labelIdentifikation = new System.Windows.Forms.Label();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.textBoxHersteller = new System.Windows.Forms.TextBox();
            this.labelmodell = new System.Windows.Forms.Label();
            this.labelHersteller = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonNeuesFahrzeug = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttondelFahrzeug = new System.Windows.Forms.Button();
            this.wSollDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIstDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIstkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wthemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fahrzeugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wartungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveFahrzeug
            // 
            this.buttonSaveFahrzeug.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSaveFahrzeug.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFahrzeug.Image")));
            this.buttonSaveFahrzeug.Location = new System.Drawing.Point(53, 0);
            this.buttonSaveFahrzeug.Name = "buttonSaveFahrzeug";
            this.buttonSaveFahrzeug.Size = new System.Drawing.Size(34, 23);
            this.buttonSaveFahrzeug.TabIndex = 0;
            this.buttonSaveFahrzeug.UseVisualStyleBackColor = false;
            this.buttonSaveFahrzeug.Click += new System.EventHandler(this.buttonSaveFahrzeug_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 579);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxkmmiles);
            this.tabPage1.Controls.Add(this.textBoxLeistung);
            this.tabPage1.Controls.Add(this.labelLeistung);
            this.tabPage1.Controls.Add(this.textBoxHoechstgeschwindigkeit);
            this.tabPage1.Controls.Add(this.labelHoechstgeschwindigkeit);
            this.tabPage1.Controls.Add(this.textBoxAntriebsart);
            this.tabPage1.Controls.Add(this.labelAntriebsart);
            this.tabPage1.Controls.Add(this.textBoxIdentifikation);
            this.tabPage1.Controls.Add(this.labelIdentifikation);
            this.tabPage1.Controls.Add(this.textBoxModell);
            this.tabPage1.Controls.Add(this.textBoxHersteller);
            this.tabPage1.Controls.Add(this.labelmodell);
            this.tabPage1.Controls.Add(this.labelHersteller);
            this.tabPage1.Controls.Add(this.labelKennzeichen);
            this.tabPage1.Controls.Add(this.textBoxKennzeichen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fahrzeugdaten";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBoxkmmiles
            // 
            this.comboBoxkmmiles.FormattingEnabled = true;
            this.comboBoxkmmiles.Items.AddRange(new object[] {
            "km",
            "miles"});
            this.comboBoxkmmiles.Location = new System.Drawing.Point(848, 39);
            this.comboBoxkmmiles.Name = "comboBoxkmmiles";
            this.comboBoxkmmiles.Size = new System.Drawing.Size(121, 21);
            this.comboBoxkmmiles.TabIndex = 14;
            // 
            // textBoxLeistung
            // 
            this.textBoxLeistung.Location = new System.Drawing.Point(200, 193);
            this.textBoxLeistung.Name = "textBoxLeistung";
            this.textBoxLeistung.Size = new System.Drawing.Size(179, 20);
            this.textBoxLeistung.TabIndex = 13;
            // 
            // labelLeistung
            // 
            this.labelLeistung.AutoSize = true;
            this.labelLeistung.Location = new System.Drawing.Point(25, 196);
            this.labelLeistung.Name = "labelLeistung";
            this.labelLeistung.Size = new System.Drawing.Size(126, 13);
            this.labelLeistung.TabIndex = 12;
            this.labelLeistung.Text = "Leistung in kW bei min -1";
            this.labelLeistung.Click += new System.EventHandler(this.labelLeistung_Click);
            // 
            // textBoxHoechstgeschwindigkeit
            // 
            this.textBoxHoechstgeschwindigkeit.Location = new System.Drawing.Point(200, 166);
            this.textBoxHoechstgeschwindigkeit.Name = "textBoxHoechstgeschwindigkeit";
            this.textBoxHoechstgeschwindigkeit.Size = new System.Drawing.Size(179, 20);
            this.textBoxHoechstgeschwindigkeit.TabIndex = 11;
            // 
            // labelHoechstgeschwindigkeit
            // 
            this.labelHoechstgeschwindigkeit.AutoSize = true;
            this.labelHoechstgeschwindigkeit.Location = new System.Drawing.Point(25, 169);
            this.labelHoechstgeschwindigkeit.Name = "labelHoechstgeschwindigkeit";
            this.labelHoechstgeschwindigkeit.Size = new System.Drawing.Size(117, 13);
            this.labelHoechstgeschwindigkeit.TabIndex = 10;
            this.labelHoechstgeschwindigkeit.Text = "Höchstgeschwindigkeit";
            // 
            // textBoxAntriebsart
            // 
            this.textBoxAntriebsart.Location = new System.Drawing.Point(200, 138);
            this.textBoxAntriebsart.Name = "textBoxAntriebsart";
            this.textBoxAntriebsart.Size = new System.Drawing.Size(179, 20);
            this.textBoxAntriebsart.TabIndex = 9;
            // 
            // labelAntriebsart
            // 
            this.labelAntriebsart.AutoSize = true;
            this.labelAntriebsart.Location = new System.Drawing.Point(25, 141);
            this.labelAntriebsart.Name = "labelAntriebsart";
            this.labelAntriebsart.Size = new System.Drawing.Size(57, 13);
            this.labelAntriebsart.TabIndex = 8;
            this.labelAntriebsart.Text = "Antriebsart";
            // 
            // textBoxIdentifikation
            // 
            this.textBoxIdentifikation.Location = new System.Drawing.Point(200, 112);
            this.textBoxIdentifikation.Name = "textBoxIdentifikation";
            this.textBoxIdentifikation.Size = new System.Drawing.Size(179, 20);
            this.textBoxIdentifikation.TabIndex = 7;
            // 
            // labelIdentifikation
            // 
            this.labelIdentifikation.AutoSize = true;
            this.labelIdentifikation.Location = new System.Drawing.Point(25, 115);
            this.labelIdentifikation.Name = "labelIdentifikation";
            this.labelIdentifikation.Size = new System.Drawing.Size(156, 13);
            this.labelIdentifikation.TabIndex = 6;
            this.labelIdentifikation.Text = "Fahrzeug-Identifikationsnummer";
            // 
            // textBoxModell
            // 
            this.textBoxModell.Location = new System.Drawing.Point(200, 86);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(179, 20);
            this.textBoxModell.TabIndex = 5;
            // 
            // textBoxHersteller
            // 
            this.textBoxHersteller.Location = new System.Drawing.Point(200, 60);
            this.textBoxHersteller.Name = "textBoxHersteller";
            this.textBoxHersteller.Size = new System.Drawing.Size(179, 20);
            this.textBoxHersteller.TabIndex = 4;
            // 
            // labelmodell
            // 
            this.labelmodell.AutoSize = true;
            this.labelmodell.Location = new System.Drawing.Point(25, 89);
            this.labelmodell.Name = "labelmodell";
            this.labelmodell.Size = new System.Drawing.Size(25, 13);
            this.labelmodell.TabIndex = 3;
            this.labelmodell.Text = "Typ";
            // 
            // labelHersteller
            // 
            this.labelHersteller.AutoSize = true;
            this.labelHersteller.Location = new System.Drawing.Point(25, 63);
            this.labelHersteller.Name = "labelHersteller";
            this.labelHersteller.Size = new System.Drawing.Size(93, 13);
            this.labelHersteller.TabIndex = 2;
            this.labelHersteller.Text = "Fahrzeughersteller";
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Location = new System.Drawing.Point(25, 39);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(69, 13);
            this.labelKennzeichen.TabIndex = 1;
            this.labelKennzeichen.Text = "Kennzeichen";
            this.labelKennzeichen.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Location = new System.Drawing.Point(200, 36);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.Size = new System.Drawing.Size(179, 20);
            this.textBoxKennzeichen.TabIndex = 0;
            this.textBoxKennzeichen.TextChanged += new System.EventHandler(this.textBoxKennzeichen_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zu tun";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1113, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wartung";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wSollDatumDataGridViewTextBoxColumn,
            this.wkmDataGridViewTextBoxColumn,
            this.wIstDatumDataGridViewTextBoxColumn,
            this.wIstkmDataGridViewTextBoxColumn,
            this.wthemaDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.DataSource = this.wartungBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 502);
            this.dataGridView1.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Edit.HeaderText = "Bearbeiten";
            this.Edit.Name = "Edit";
            this.Edit.Width = 64;
            // 
            // buttonNeuesFahrzeug
            // 
            this.buttonNeuesFahrzeug.BackColor = System.Drawing.SystemColors.Window;
            this.buttonNeuesFahrzeug.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNeuesFahrzeug.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeuesFahrzeug.Image")));
            this.buttonNeuesFahrzeug.Location = new System.Drawing.Point(0, 0);
            this.buttonNeuesFahrzeug.Name = "buttonNeuesFahrzeug";
            this.buttonNeuesFahrzeug.Size = new System.Drawing.Size(28, 23);
            this.buttonNeuesFahrzeug.TabIndex = 6;
            this.buttonNeuesFahrzeug.UseVisualStyleBackColor = false;
            this.buttonNeuesFahrzeug.Click += new System.EventHandler(this.ButtonNeuesFahrzeug_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.buttondelFahrzeug);
            this.panel1.Controls.Add(this.buttonNeuesFahrzeug);
            this.panel1.Controls.Add(this.buttonSaveFahrzeug);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 23);
            this.panel1.TabIndex = 7;
            // 
            // buttondelFahrzeug
            // 
            this.buttondelFahrzeug.BackColor = System.Drawing.SystemColors.Window;
            this.buttondelFahrzeug.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttondelFahrzeug.Image = ((System.Drawing.Image)(resources.GetObject("buttondelFahrzeug.Image")));
            this.buttondelFahrzeug.Location = new System.Drawing.Point(28, 0);
            this.buttondelFahrzeug.Name = "buttondelFahrzeug";
            this.buttondelFahrzeug.Size = new System.Drawing.Size(29, 23);
            this.buttondelFahrzeug.TabIndex = 7;
            this.buttondelFahrzeug.UseVisualStyleBackColor = false;
            this.buttondelFahrzeug.Click += new System.EventHandler(this.buttondelFahrzeug_Click);
            // 
            // wSollDatumDataGridViewTextBoxColumn
            // 
            this.wSollDatumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.wSollDatumDataGridViewTextBoxColumn.DataPropertyName = "WSollDatum";
            this.wSollDatumDataGridViewTextBoxColumn.HeaderText = "Durchzuführen bis (Datum)";
            this.wSollDatumDataGridViewTextBoxColumn.Name = "wSollDatumDataGridViewTextBoxColumn";
            this.wSollDatumDataGridViewTextBoxColumn.Width = 111;
            // 
            // wkmDataGridViewTextBoxColumn
            // 
            this.wkmDataGridViewTextBoxColumn.DataPropertyName = "Wkm";
            this.wkmDataGridViewTextBoxColumn.HeaderText = "Durchzuführen bis (km-Stand)";
            this.wkmDataGridViewTextBoxColumn.Name = "wkmDataGridViewTextBoxColumn";
            // 
            // wIstDatumDataGridViewTextBoxColumn
            // 
            this.wIstDatumDataGridViewTextBoxColumn.DataPropertyName = "WIstDatum";
            this.wIstDatumDataGridViewTextBoxColumn.HeaderText = "Durchgeführt am (Datum)";
            this.wIstDatumDataGridViewTextBoxColumn.Name = "wIstDatumDataGridViewTextBoxColumn";
            // 
            // wIstkmDataGridViewTextBoxColumn
            // 
            this.wIstkmDataGridViewTextBoxColumn.DataPropertyName = "WIstkm";
            this.wIstkmDataGridViewTextBoxColumn.HeaderText = "Durchgeführt bei (km)";
            this.wIstkmDataGridViewTextBoxColumn.Name = "wIstkmDataGridViewTextBoxColumn";
            // 
            // wthemaDataGridViewTextBoxColumn
            // 
            this.wthemaDataGridViewTextBoxColumn.DataPropertyName = "wthema";
            this.wthemaDataGridViewTextBoxColumn.HeaderText = "Wartung";
            this.wthemaDataGridViewTextBoxColumn.Name = "wthemaDataGridViewTextBoxColumn";
            // 
            // wartungBindingSource
            // 
            this.wartungBindingSource.DataSource = typeof(Oldtimer.Wartung);
            // 
            // fahrzeugBindingSource
            // 
            this.fahrzeugBindingSource.DataSource = typeof(Oldtimer.Fahrzeug);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Roadbook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wartungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveFahrzeug;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.Button buttonNeuesFahrzeug;
        private System.Windows.Forms.Label labelmodell;
        private System.Windows.Forms.Label labelHersteller;
        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.TextBox textBoxHersteller;
        private System.Windows.Forms.TextBox textBoxLeistung;
        private System.Windows.Forms.Label labelLeistung;
        private System.Windows.Forms.TextBox textBoxHoechstgeschwindigkeit;
        private System.Windows.Forms.Label labelHoechstgeschwindigkeit;
        private System.Windows.Forms.TextBox textBoxAntriebsart;
        private System.Windows.Forms.Label labelAntriebsart;
        private System.Windows.Forms.TextBox textBoxIdentifikation;
        private System.Windows.Forms.Label labelIdentifikation;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fahrzeugBindingSource;
        private System.Windows.Forms.BindingSource wartungBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn wSollDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wkmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIstDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIstkmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wthemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxkmmiles;
        private System.Windows.Forms.Button buttondelFahrzeug;
    }
}

