namespace StokKontrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firma_adiLabel;
            System.Windows.Forms.Label firma_telefonLabel;
            System.Windows.Forms.Label firma_kisiLabel;
            System.Windows.Forms.Label firma_adresLabel;
            System.Windows.Forms.Label firma_idLabel;
            this.firmalarDataGridView = new System.Windows.Forms.DataGridView();
            this.firma_adiTextBox = new System.Windows.Forms.TextBox();
            this.firma_telefonTextBox = new System.Windows.Forms.TextBox();
            this.firma_kisiTextBox = new System.Windows.Forms.TextBox();
            this.firma_adresTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.firma_idTextBox = new System.Windows.Forms.TextBox();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.fAdi = new System.Windows.Forms.TextBox();
            this.fkisi = new System.Windows.Forms.TextBox();
            this.fAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fTelefon = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmalar = new StokKontrol.firmalar();
            this.firmalarTableAdapter = new StokKontrol.firmalarTableAdapters.firmalarTableAdapter();
            this.tableAdapterManager = new StokKontrol.firmalarTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firma_adiLabel = new System.Windows.Forms.Label();
            firma_telefonLabel = new System.Windows.Forms.Label();
            firma_kisiLabel = new System.Windows.Forms.Label();
            firma_adresLabel = new System.Windows.Forms.Label();
            firma_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarDataGridView)).BeginInit();
            this.insertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // firmalarDataGridView
            // 
            this.firmalarDataGridView.AllowUserToAddRows = false;
            this.firmalarDataGridView.AllowUserToDeleteRows = false;
            this.firmalarDataGridView.AutoGenerateColumns = false;
            this.firmalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmalarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.firma_adres});
            this.firmalarDataGridView.DataSource = this.firmalarBindingSource;
            this.firmalarDataGridView.Location = new System.Drawing.Point(14, 12);
            this.firmalarDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firmalarDataGridView.Name = "firmalarDataGridView";
            this.firmalarDataGridView.ReadOnly = true;
            this.firmalarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmalarDataGridView.Size = new System.Drawing.Size(563, 426);
            this.firmalarDataGridView.TabIndex = 1;
            // 
            // firma_adiLabel
            // 
            firma_adiLabel.AutoSize = true;
            firma_adiLabel.Location = new System.Drawing.Point(581, 21);
            firma_adiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firma_adiLabel.Name = "firma_adiLabel";
            firma_adiLabel.Size = new System.Drawing.Size(70, 13);
            firma_adiLabel.TabIndex = 1;
            firma_adiLabel.Text = "Firma Adı :";
            // 
            // firma_adiTextBox
            // 
            this.firma_adiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "firma_adi", true));
            this.firma_adiTextBox.Location = new System.Drawing.Point(664, 21);
            this.firma_adiTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firma_adiTextBox.Name = "firma_adiTextBox";
            this.firma_adiTextBox.Size = new System.Drawing.Size(116, 21);
            this.firma_adiTextBox.TabIndex = 2;
            // 
            // firma_telefonLabel
            // 
            firma_telefonLabel.AutoSize = true;
            firma_telefonLabel.Location = new System.Drawing.Point(581, 61);
            firma_telefonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firma_telefonLabel.Name = "firma_telefonLabel";
            firma_telefonLabel.Size = new System.Drawing.Size(57, 13);
            firma_telefonLabel.TabIndex = 3;
            firma_telefonLabel.Text = "Telefon :";
            // 
            // firma_telefonTextBox
            // 
            this.firma_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "firma_telefon", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.firma_telefonTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.firma_telefonTextBox.Location = new System.Drawing.Point(664, 59);
            this.firma_telefonTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firma_telefonTextBox.Name = "firma_telefonTextBox";
            this.firma_telefonTextBox.Size = new System.Drawing.Size(116, 21);
            this.firma_telefonTextBox.TabIndex = 4;
            // 
            // firma_kisiLabel
            // 
            firma_kisiLabel.AutoSize = true;
            firma_kisiLabel.Location = new System.Drawing.Point(581, 98);
            firma_kisiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firma_kisiLabel.Name = "firma_kisiLabel";
            firma_kisiLabel.Size = new System.Drawing.Size(49, 13);
            firma_kisiLabel.TabIndex = 5;
            firma_kisiLabel.Text = "Yetkili :";
            // 
            // firma_kisiTextBox
            // 
            this.firma_kisiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "firma_kisi", true));
            this.firma_kisiTextBox.Location = new System.Drawing.Point(664, 95);
            this.firma_kisiTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firma_kisiTextBox.Name = "firma_kisiTextBox";
            this.firma_kisiTextBox.Size = new System.Drawing.Size(116, 21);
            this.firma_kisiTextBox.TabIndex = 6;
            // 
            // firma_adresLabel
            // 
            firma_adresLabel.AutoSize = true;
            firma_adresLabel.Location = new System.Drawing.Point(581, 141);
            firma_adresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firma_adresLabel.Name = "firma_adresLabel";
            firma_adresLabel.Size = new System.Drawing.Size(49, 13);
            firma_adresLabel.TabIndex = 7;
            firma_adresLabel.Text = "Adres :";
            // 
            // firma_adresTextBox
            // 
            this.firma_adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "firma_adres", true));
            this.firma_adresTextBox.Location = new System.Drawing.Point(664, 135);
            this.firma_adresTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firma_adresTextBox.Multiline = true;
            this.firma_adresTextBox.Name = "firma_adresTextBox";
            this.firma_adresTextBox.Size = new System.Drawing.Size(202, 109);
            this.firma_adresTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(803, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firma_idLabel
            // 
            firma_idLabel.AutoSize = true;
            firma_idLabel.Location = new System.Drawing.Point(952, 316);
            firma_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firma_idLabel.Name = "firma_idLabel";
            firma_idLabel.Size = new System.Drawing.Size(56, 13);
            firma_idLabel.TabIndex = 11;
            firma_idLabel.Text = "firma id:";
            // 
            // firma_idTextBox
            // 
            this.firma_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "firma_id", true));
            this.firma_idTextBox.Location = new System.Drawing.Point(1010, 313);
            this.firma_idTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firma_idTextBox.Name = "firma_idTextBox";
            this.firma_idTextBox.Size = new System.Drawing.Size(116, 21);
            this.firma_idTextBox.TabIndex = 12;
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.button1);
            this.insertPanel.Controls.Add(this.fTelefon);
            this.insertPanel.Controls.Add(this.label4);
            this.insertPanel.Controls.Add(this.label3);
            this.insertPanel.Controls.Add(this.label2);
            this.insertPanel.Controls.Add(this.label1);
            this.insertPanel.Controls.Add(this.fAdres);
            this.insertPanel.Controls.Add(this.fkisi);
            this.insertPanel.Controls.Add(this.fAdi);
            this.insertPanel.Location = new System.Drawing.Point(582, 12);
            this.insertPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(332, 426);
            this.insertPanel.TabIndex = 14;
            this.insertPanel.Visible = false;
            // 
            // fAdi
            // 
            this.fAdi.Location = new System.Drawing.Point(125, 19);
            this.fAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fAdi.Name = "fAdi";
            this.fAdi.Size = new System.Drawing.Size(116, 21);
            this.fAdi.TabIndex = 0;
            // 
            // fkisi
            // 
            this.fkisi.Location = new System.Drawing.Point(125, 81);
            this.fkisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fkisi.Name = "fkisi";
            this.fkisi.Size = new System.Drawing.Size(116, 21);
            this.fkisi.TabIndex = 2;
            // 
            // fAdres
            // 
            this.fAdres.Location = new System.Drawing.Point(125, 112);
            this.fAdres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fAdres.Multiline = true;
            this.fAdres.Name = "fAdres";
            this.fAdres.Size = new System.Drawing.Size(188, 155);
            this.fAdres.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firma Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yetkili Kişi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres :";
            // 
            // fTelefon
            // 
            this.fTelefon.Location = new System.Drawing.Point(125, 50);
            this.fTelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fTelefon.Mask = "(9999) 000-00-00";
            this.fTelefon.Name = "fTelefon";
            this.fTelefon.Size = new System.Drawing.Size(116, 21);
            this.fTelefon.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(664, 262);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSalmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(725, 262);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // firmalarBindingSource
            // 
            this.firmalarBindingSource.DataMember = "firmalar";
            this.firmalarBindingSource.DataSource = this.firmalar;
            // 
            // firmalar
            // 
            this.firmalar.DataSetName = "firmalar";
            this.firmalar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmalarTableAdapter
            // 
            this.firmalarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.firmalarTableAdapter = this.firmalarTableAdapter;
            this.tableAdapterManager.UpdateOrder = StokKontrol.firmalarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "firma_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "firma_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firma_adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "firma_telefon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "firma_kisi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Firma Yetkilisi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // firma_adres
            // 
            this.firma_adres.DataPropertyName = "firma_adres";
            this.firma_adres.HeaderText = "Adres";
            this.firma_adres.Name = "firma_adres";
            this.firma_adres.ReadOnly = true;
            this.firma_adres.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 458);
            this.Controls.Add(this.insertPanel);
            this.Controls.Add(firma_idLabel);
            this.Controls.Add(this.firma_idTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(firma_adresLabel);
            this.Controls.Add(this.firma_adresTextBox);
            this.Controls.Add(firma_kisiLabel);
            this.Controls.Add(this.firma_kisiTextBox);
            this.Controls.Add(firma_telefonLabel);
            this.Controls.Add(this.firma_telefonTextBox);
            this.Controls.Add(firma_adiLabel);
            this.Controls.Add(this.firma_adiTextBox);
            this.Controls.Add(this.firmalarDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmalarDataGridView)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private firmalar firmalar;
        private System.Windows.Forms.BindingSource firmalarBindingSource;
        private firmalarTableAdapters.firmalarTableAdapter firmalarTableAdapter;
        private firmalarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView firmalarDataGridView;
        private System.Windows.Forms.TextBox firma_adiTextBox;
        private System.Windows.Forms.TextBox firma_telefonTextBox;
        private System.Windows.Forms.TextBox firma_kisiTextBox;
        private System.Windows.Forms.TextBox firma_adresTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox firma_idTextBox;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fAdres;
        private System.Windows.Forms.TextBox fkisi;
        private System.Windows.Forms.TextBox fAdi;
        private System.Windows.Forms.MaskedTextBox fTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma_adres;
    }
}

