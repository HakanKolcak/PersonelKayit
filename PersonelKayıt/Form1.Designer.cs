namespace PersonelKayıt
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
            this.gbxGiriş = new System.Windows.Forms.GroupBox();
            this.txtSehirDiger = new System.Windows.Forms.TextBox();
            this.mtbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbCınsıyet = new System.Windows.Forms.ComboBox();
            this.mtbMaas = new System.Windows.Forms.MaskedTextBox();
            this.cmbSehır = new System.Windows.Forms.ComboBox();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVTDataSet = new PersonelKayıt.PersonelVTDataSet();
            this.tbxMeslek = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblSehır = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblCınsıyet = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgwWorkers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbxGüncelleme = new System.Windows.Forms.GroupBox();
            this.txtSehirDigerGüncelleme = new System.Windows.Forms.TextBox();
            this.mtbTelNoGüncelleme = new System.Windows.Forms.MaskedTextBox();
            this.cmbDurumGüncelleme = new System.Windows.Forms.ComboBox();
            this.cmbCınsıyetGüncelleme = new System.Windows.Forms.ComboBox();
            this.mtbMaasGüncelleme = new System.Windows.Forms.MaskedTextBox();
            this.cmbSehırGüncelleme = new System.Windows.Forms.ComboBox();
            this.tbxMeslekGüncelleme = new System.Windows.Forms.TextBox();
            this.lblMeslekGüncelleme = new System.Windows.Forms.Label();
            this.lblTelNoGüncelleme = new System.Windows.Forms.Label();
            this.lblMaasGüncelleme = new System.Windows.Forms.Label();
            this.lblSehırGüncelleme = new System.Windows.Forms.Label();
            this.lblDurumGüncelleme = new System.Windows.Forms.Label();
            this.lblCınsıyetGüncelleme = new System.Windows.Forms.Label();
            this.tbxSoyadGüncelleme = new System.Windows.Forms.TextBox();
            this.lblSoyadGüncelleme = new System.Windows.Forms.Label();
            this.tbxAdGüncelleme = new System.Windows.Forms.TextBox();
            this.lblAdGüncelleme = new System.Windows.Forms.Label();
            this.sehirlerTableAdapter = new PersonelKayıt.PersonelVTDataSetTableAdapters.SehirlerTableAdapter();
            this.gbxGiriş.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVTDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbxGüncelleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGiriş
            // 
            this.gbxGiriş.Controls.Add(this.txtSehirDiger);
            this.gbxGiriş.Controls.Add(this.mtbTelNo);
            this.gbxGiriş.Controls.Add(this.cmbDurum);
            this.gbxGiriş.Controls.Add(this.cmbCınsıyet);
            this.gbxGiriş.Controls.Add(this.mtbMaas);
            this.gbxGiriş.Controls.Add(this.cmbSehır);
            this.gbxGiriş.Controls.Add(this.tbxMeslek);
            this.gbxGiriş.Controls.Add(this.lblMeslek);
            this.gbxGiriş.Controls.Add(this.lblTelNo);
            this.gbxGiriş.Controls.Add(this.lblMaas);
            this.gbxGiriş.Controls.Add(this.lblSehır);
            this.gbxGiriş.Controls.Add(this.lblDurum);
            this.gbxGiriş.Controls.Add(this.lblCınsıyet);
            this.gbxGiriş.Controls.Add(this.tbxSoyad);
            this.gbxGiriş.Controls.Add(this.lblSoyad);
            this.gbxGiriş.Controls.Add(this.tbxAd);
            this.gbxGiriş.Controls.Add(this.lblAd);
            this.gbxGiriş.Location = new System.Drawing.Point(14, 16);
            this.gbxGiriş.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGiriş.Name = "gbxGiriş";
            this.gbxGiriş.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGiriş.Size = new System.Drawing.Size(280, 411);
            this.gbxGiriş.TabIndex = 0;
            this.gbxGiriş.TabStop = false;
            this.gbxGiriş.Text = "Personel Girişi";
            // 
            // txtSehirDiger
            // 
            this.txtSehirDiger.Location = new System.Drawing.Point(78, 249);
            this.txtSehirDiger.Name = "txtSehirDiger";
            this.txtSehirDiger.Size = new System.Drawing.Size(100, 23);
            this.txtSehirDiger.TabIndex = 19;
            this.txtSehirDiger.Visible = false;
            // 
            // mtbTelNo
            // 
            this.mtbTelNo.Location = new System.Drawing.Point(78, 321);
            this.mtbTelNo.Mask = "0999 999 99 99";
            this.mtbTelNo.Name = "mtbTelNo";
            this.mtbTelNo.Size = new System.Drawing.Size(168, 23);
            this.mtbTelNo.TabIndex = 7;
            this.mtbTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbTelNo_KeyPress);
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbDurum.Location = new System.Drawing.Point(78, 171);
            this.cmbDurum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(168, 25);
            this.cmbDurum.TabIndex = 4;
            // 
            // cmbCınsıyet
            // 
            this.cmbCınsıyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCınsıyet.FormattingEnabled = true;
            this.cmbCınsıyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCınsıyet.Location = new System.Drawing.Point(78, 125);
            this.cmbCınsıyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCınsıyet.Name = "cmbCınsıyet";
            this.cmbCınsıyet.Size = new System.Drawing.Size(168, 25);
            this.cmbCınsıyet.TabIndex = 3;
            // 
            // mtbMaas
            // 
            this.mtbMaas.Location = new System.Drawing.Point(78, 279);
            this.mtbMaas.Margin = new System.Windows.Forms.Padding(4);
            this.mtbMaas.Mask = "99999.99";
            this.mtbMaas.Name = "mtbMaas";
            this.mtbMaas.Size = new System.Drawing.Size(168, 23);
            this.mtbMaas.TabIndex = 6;
            this.mtbMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbMaas_KeyPress);
            // 
            // cmbSehır
            // 
            this.cmbSehır.DataSource = this.sehirlerBindingSource;
            this.cmbSehır.DisplayMember = "SehirAdi";
            this.cmbSehır.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehır.FormattingEnabled = true;
            this.cmbSehır.Location = new System.Drawing.Point(78, 217);
            this.cmbSehır.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSehır.Name = "cmbSehır";
            this.cmbSehır.Size = new System.Drawing.Size(168, 25);
            this.cmbSehır.TabIndex = 5;
            this.cmbSehır.ValueMember = "PlakaNo";
            this.cmbSehır.SelectedIndexChanged += new System.EventHandler(this.cmbSehır_SelectedIndexChanged);
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.personelVTDataSet;
            // 
            // personelVTDataSet
            // 
            this.personelVTDataSet.DataSetName = "PersonelVTDataSet";
            this.personelVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxMeslek
            // 
            this.tbxMeslek.Location = new System.Drawing.Point(78, 370);
            this.tbxMeslek.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMeslek.Name = "tbxMeslek";
            this.tbxMeslek.Size = new System.Drawing.Size(168, 23);
            this.tbxMeslek.TabIndex = 8;
            this.tbxMeslek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMeslek_KeyPress);
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(7, 373);
            this.lblMeslek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(57, 17);
            this.lblMeslek.TabIndex = 18;
            this.lblMeslek.Text = "Meslek :";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(14, 327);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(50, 17);
            this.lblTelNo.TabIndex = 16;
            this.lblTelNo.Text = "TelNo :";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(17, 282);
            this.lblMaas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(47, 17);
            this.lblMaas.TabIndex = 14;
            this.lblMaas.Text = "Maas :";
            // 
            // lblSehır
            // 
            this.lblSehır.AutoSize = true;
            this.lblSehır.Location = new System.Drawing.Point(20, 220);
            this.lblSehır.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSehır.Name = "lblSehır";
            this.lblSehır.Size = new System.Drawing.Size(44, 17);
            this.lblSehır.TabIndex = 12;
            this.lblSehır.Text = "Sehır :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(10, 174);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(54, 17);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durum :";
            // 
            // lblCınsıyet
            // 
            this.lblCınsıyet.AutoSize = true;
            this.lblCınsıyet.Location = new System.Drawing.Point(5, 128);
            this.lblCınsıyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCınsıyet.Name = "lblCınsıyet";
            this.lblCınsıyet.Size = new System.Drawing.Size(59, 17);
            this.lblCınsıyet.TabIndex = 8;
            this.lblCınsıyet.Text = "Cınsıyet :";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(78, 80);
            this.tbxSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(168, 23);
            this.tbxSoyad.TabIndex = 2;
            this.tbxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSoyad_KeyPress);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(13, 82);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(51, 17);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad :";
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(78, 34);
            this.tbxAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(168, 23);
            this.tbxAd.TabIndex = 1;
            this.tbxAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAd_KeyPress);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(33, 37);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 17);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(311, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(258, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGüncelle.Location = new System.Drawing.Point(39, 260);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(192, 37);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSil.Location = new System.Drawing.Point(39, 193);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(192, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKaydet.Location = new System.Drawing.Point(39, 128);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(192, 37);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // dgwWorkers
            // 
            this.dgwWorkers.AllowUserToAddRows = false;
            this.dgwWorkers.AllowUserToDeleteRows = false;
            this.dgwWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwWorkers.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgwWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwWorkers.GridColor = System.Drawing.Color.Black;
            this.dgwWorkers.Location = new System.Drawing.Point(4, 20);
            this.dgwWorkers.Margin = new System.Windows.Forms.Padding(4);
            this.dgwWorkers.Name = "dgwWorkers";
            this.dgwWorkers.ReadOnly = true;
            this.dgwWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwWorkers.Size = new System.Drawing.Size(1096, 265);
            this.dgwWorkers.TabIndex = 2;
            this.dgwWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwWorkers_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwWorkers);
            this.groupBox3.Location = new System.Drawing.Point(14, 435);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1104, 289);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // gbxGüncelleme
            // 
            this.gbxGüncelleme.Controls.Add(this.txtSehirDigerGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.mtbTelNoGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.cmbDurumGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.cmbCınsıyetGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.mtbMaasGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.cmbSehırGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.tbxMeslekGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblMeslekGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblTelNoGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblMaasGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblSehırGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblDurumGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblCınsıyetGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.tbxSoyadGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblSoyadGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.tbxAdGüncelleme);
            this.gbxGüncelleme.Controls.Add(this.lblAdGüncelleme);
            this.gbxGüncelleme.Location = new System.Drawing.Point(588, 16);
            this.gbxGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGüncelleme.Name = "gbxGüncelleme";
            this.gbxGüncelleme.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGüncelleme.Size = new System.Drawing.Size(280, 411);
            this.gbxGüncelleme.TabIndex = 4;
            this.gbxGüncelleme.TabStop = false;
            this.gbxGüncelleme.Text = "Personel Güncelleme";
            // 
            // txtSehirDigerGüncelleme
            // 
            this.txtSehirDigerGüncelleme.Location = new System.Drawing.Point(78, 249);
            this.txtSehirDigerGüncelleme.Name = "txtSehirDigerGüncelleme";
            this.txtSehirDigerGüncelleme.Size = new System.Drawing.Size(100, 23);
            this.txtSehirDigerGüncelleme.TabIndex = 19;
            this.txtSehirDigerGüncelleme.Visible = false;
            // 
            // mtbTelNoGüncelleme
            // 
            this.mtbTelNoGüncelleme.Location = new System.Drawing.Point(78, 321);
            this.mtbTelNoGüncelleme.Mask = "0999 999 99 99";
            this.mtbTelNoGüncelleme.Name = "mtbTelNoGüncelleme";
            this.mtbTelNoGüncelleme.Size = new System.Drawing.Size(168, 23);
            this.mtbTelNoGüncelleme.TabIndex = 7;
            this.mtbTelNoGüncelleme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbTelNoGüncelleme_KeyPress);
            // 
            // cmbDurumGüncelleme
            // 
            this.cmbDurumGüncelleme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumGüncelleme.FormattingEnabled = true;
            this.cmbDurumGüncelleme.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbDurumGüncelleme.Location = new System.Drawing.Point(78, 171);
            this.cmbDurumGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDurumGüncelleme.Name = "cmbDurumGüncelleme";
            this.cmbDurumGüncelleme.Size = new System.Drawing.Size(168, 25);
            this.cmbDurumGüncelleme.TabIndex = 4;
            // 
            // cmbCınsıyetGüncelleme
            // 
            this.cmbCınsıyetGüncelleme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCınsıyetGüncelleme.FormattingEnabled = true;
            this.cmbCınsıyetGüncelleme.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCınsıyetGüncelleme.Location = new System.Drawing.Point(78, 125);
            this.cmbCınsıyetGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCınsıyetGüncelleme.Name = "cmbCınsıyetGüncelleme";
            this.cmbCınsıyetGüncelleme.Size = new System.Drawing.Size(168, 25);
            this.cmbCınsıyetGüncelleme.TabIndex = 3;
            // 
            // mtbMaasGüncelleme
            // 
            this.mtbMaasGüncelleme.Location = new System.Drawing.Point(78, 279);
            this.mtbMaasGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.mtbMaasGüncelleme.Mask = "99999.99";
            this.mtbMaasGüncelleme.Name = "mtbMaasGüncelleme";
            this.mtbMaasGüncelleme.Size = new System.Drawing.Size(168, 23);
            this.mtbMaasGüncelleme.TabIndex = 6;
            this.mtbMaasGüncelleme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbMaasGüncelleme_KeyPress);
            // 
            // cmbSehırGüncelleme
            // 
            this.cmbSehırGüncelleme.DataSource = this.sehirlerBindingSource;
            this.cmbSehırGüncelleme.DisplayMember = "SehirAdi";
            this.cmbSehırGüncelleme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehırGüncelleme.FormattingEnabled = true;
            this.cmbSehırGüncelleme.Location = new System.Drawing.Point(78, 217);
            this.cmbSehırGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSehırGüncelleme.Name = "cmbSehırGüncelleme";
            this.cmbSehırGüncelleme.Size = new System.Drawing.Size(168, 25);
            this.cmbSehırGüncelleme.TabIndex = 5;
            this.cmbSehırGüncelleme.ValueMember = "PlakaNo";
            this.cmbSehırGüncelleme.SelectedIndexChanged += new System.EventHandler(this.cmbSehırGüncelleme_SelectedIndexChanged);
            // 
            // tbxMeslekGüncelleme
            // 
            this.tbxMeslekGüncelleme.Location = new System.Drawing.Point(78, 370);
            this.tbxMeslekGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMeslekGüncelleme.Name = "tbxMeslekGüncelleme";
            this.tbxMeslekGüncelleme.Size = new System.Drawing.Size(168, 23);
            this.tbxMeslekGüncelleme.TabIndex = 8;
            this.tbxMeslekGüncelleme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMeslekGüncelleme_KeyPress);
            // 
            // lblMeslekGüncelleme
            // 
            this.lblMeslekGüncelleme.AutoSize = true;
            this.lblMeslekGüncelleme.Location = new System.Drawing.Point(7, 373);
            this.lblMeslekGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeslekGüncelleme.Name = "lblMeslekGüncelleme";
            this.lblMeslekGüncelleme.Size = new System.Drawing.Size(57, 17);
            this.lblMeslekGüncelleme.TabIndex = 18;
            this.lblMeslekGüncelleme.Text = "Meslek :";
            // 
            // lblTelNoGüncelleme
            // 
            this.lblTelNoGüncelleme.AutoSize = true;
            this.lblTelNoGüncelleme.Location = new System.Drawing.Point(14, 327);
            this.lblTelNoGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNoGüncelleme.Name = "lblTelNoGüncelleme";
            this.lblTelNoGüncelleme.Size = new System.Drawing.Size(50, 17);
            this.lblTelNoGüncelleme.TabIndex = 16;
            this.lblTelNoGüncelleme.Text = "TelNo :";
            // 
            // lblMaasGüncelleme
            // 
            this.lblMaasGüncelleme.AutoSize = true;
            this.lblMaasGüncelleme.Location = new System.Drawing.Point(17, 282);
            this.lblMaasGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaasGüncelleme.Name = "lblMaasGüncelleme";
            this.lblMaasGüncelleme.Size = new System.Drawing.Size(40, 17);
            this.lblMaasGüncelleme.TabIndex = 14;
            this.lblMaasGüncelleme.Text = "Maas";
            // 
            // lblSehırGüncelleme
            // 
            this.lblSehırGüncelleme.AutoSize = true;
            this.lblSehırGüncelleme.Location = new System.Drawing.Point(20, 220);
            this.lblSehırGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSehırGüncelleme.Name = "lblSehırGüncelleme";
            this.lblSehırGüncelleme.Size = new System.Drawing.Size(44, 17);
            this.lblSehırGüncelleme.TabIndex = 12;
            this.lblSehırGüncelleme.Text = "Sehır :";
            // 
            // lblDurumGüncelleme
            // 
            this.lblDurumGüncelleme.AutoSize = true;
            this.lblDurumGüncelleme.Location = new System.Drawing.Point(10, 174);
            this.lblDurumGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurumGüncelleme.Name = "lblDurumGüncelleme";
            this.lblDurumGüncelleme.Size = new System.Drawing.Size(54, 17);
            this.lblDurumGüncelleme.TabIndex = 10;
            this.lblDurumGüncelleme.Text = "Durum :";
            // 
            // lblCınsıyetGüncelleme
            // 
            this.lblCınsıyetGüncelleme.AutoSize = true;
            this.lblCınsıyetGüncelleme.Location = new System.Drawing.Point(5, 128);
            this.lblCınsıyetGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCınsıyetGüncelleme.Name = "lblCınsıyetGüncelleme";
            this.lblCınsıyetGüncelleme.Size = new System.Drawing.Size(59, 17);
            this.lblCınsıyetGüncelleme.TabIndex = 8;
            this.lblCınsıyetGüncelleme.Text = "Cınsıyet :";
            // 
            // tbxSoyadGüncelleme
            // 
            this.tbxSoyadGüncelleme.Location = new System.Drawing.Point(78, 80);
            this.tbxSoyadGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoyadGüncelleme.Name = "tbxSoyadGüncelleme";
            this.tbxSoyadGüncelleme.Size = new System.Drawing.Size(168, 23);
            this.tbxSoyadGüncelleme.TabIndex = 2;
            this.tbxSoyadGüncelleme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSoyadGüncelleme_KeyPress);
            // 
            // lblSoyadGüncelleme
            // 
            this.lblSoyadGüncelleme.AutoSize = true;
            this.lblSoyadGüncelleme.Location = new System.Drawing.Point(13, 82);
            this.lblSoyadGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyadGüncelleme.Name = "lblSoyadGüncelleme";
            this.lblSoyadGüncelleme.Size = new System.Drawing.Size(51, 17);
            this.lblSoyadGüncelleme.TabIndex = 4;
            this.lblSoyadGüncelleme.Text = "Soyad :";
            // 
            // tbxAdGüncelleme
            // 
            this.tbxAdGüncelleme.Location = new System.Drawing.Point(78, 34);
            this.tbxAdGüncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAdGüncelleme.Name = "tbxAdGüncelleme";
            this.tbxAdGüncelleme.Size = new System.Drawing.Size(168, 23);
            this.tbxAdGüncelleme.TabIndex = 1;
            this.tbxAdGüncelleme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAdGüncelleme_KeyPress);
            // 
            // lblAdGüncelleme
            // 
            this.lblAdGüncelleme.AutoSize = true;
            this.lblAdGüncelleme.Location = new System.Drawing.Point(33, 37);
            this.lblAdGüncelleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdGüncelleme.Name = "lblAdGüncelleme";
            this.lblAdGüncelleme.Size = new System.Drawing.Size(31, 17);
            this.lblAdGüncelleme.TabIndex = 2;
            this.lblAdGüncelleme.Text = "Ad :";
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1129, 750);
            this.Controls.Add(this.gbxGüncelleme);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxGiriş);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1_Load";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxGiriş.ResumeLayout(false);
            this.gbxGiriş.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVTDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbxGüncelleme.ResumeLayout(false);
            this.gbxGüncelleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGiriş;
        private System.Windows.Forms.ComboBox cmbSehır;
        private System.Windows.Forms.TextBox tbxMeslek;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblSehır;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblCınsıyet;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwWorkers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox mtbMaas;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbCınsıyet;
        private System.Windows.Forms.GroupBox gbxGüncelleme;
        private System.Windows.Forms.ComboBox cmbDurumGüncelleme;
        private System.Windows.Forms.ComboBox cmbCınsıyetGüncelleme;
        private System.Windows.Forms.MaskedTextBox mtbMaasGüncelleme;
        private System.Windows.Forms.ComboBox cmbSehırGüncelleme;
        private System.Windows.Forms.TextBox tbxMeslekGüncelleme;
        private System.Windows.Forms.Label lblMeslekGüncelleme;
        private System.Windows.Forms.Label lblTelNoGüncelleme;
        private System.Windows.Forms.Label lblMaasGüncelleme;
        private System.Windows.Forms.Label lblSehırGüncelleme;
        private System.Windows.Forms.Label lblDurumGüncelleme;
        private System.Windows.Forms.Label lblCınsıyetGüncelleme;
        private System.Windows.Forms.TextBox tbxSoyadGüncelleme;
        private System.Windows.Forms.Label lblSoyadGüncelleme;
        private System.Windows.Forms.TextBox tbxAdGüncelleme;
        private System.Windows.Forms.Label lblAdGüncelleme;
        private System.Windows.Forms.MaskedTextBox mtbTelNo;
        private System.Windows.Forms.MaskedTextBox mtbTelNoGüncelleme;
        private PersonelVTDataSet personelVTDataSet;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private PersonelVTDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private System.Windows.Forms.TextBox txtSehirDiger;
        private System.Windows.Forms.TextBox txtSehirDigerGüncelleme;
    }
}

