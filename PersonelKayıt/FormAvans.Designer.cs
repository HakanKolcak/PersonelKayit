namespace PersonelKayıt
{
    partial class FormAvans
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
            this.gbxAvans = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblIlkAvansMiktari = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblIlkAvans = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new PersonelKayıt.PersonelVTDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwAvans = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxAvans.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvans)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAvans
            // 
            this.gbxAvans.Controls.Add(this.button1);
            this.gbxAvans.Controls.Add(this.maskedTextBox2);
            this.gbxAvans.Controls.Add(this.lblIlkAvansMiktari);
            this.gbxAvans.Controls.Add(this.maskedTextBox1);
            this.gbxAvans.Controls.Add(this.lblIlkAvans);
            this.gbxAvans.Location = new System.Drawing.Point(15, 42);
            this.gbxAvans.Name = "gbxAvans";
            this.gbxAvans.Size = new System.Drawing.Size(388, 228);
            this.gbxAvans.TabIndex = 0;
            this.gbxAvans.TabStop = false;
            this.gbxAvans.Text = "Avans";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(145, 92);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(205, 20);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // lblIlkAvansMiktari
            // 
            this.lblIlkAvansMiktari.AutoSize = true;
            this.lblIlkAvansMiktari.Location = new System.Drawing.Point(32, 95);
            this.lblIlkAvansMiktari.Name = "lblIlkAvansMiktari";
            this.lblIlkAvansMiktari.Size = new System.Drawing.Size(91, 13);
            this.lblIlkAvansMiktari.TabIndex = 1;
            this.lblIlkAvansMiktari.Text = "İlk Avans Miktarı :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(145, 50);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(205, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // lblIlkAvans
            // 
            this.lblIlkAvans.AutoSize = true;
            this.lblIlkAvans.Location = new System.Drawing.Point(32, 53);
            this.lblIlkAvans.Name = "lblIlkAvans";
            this.lblIlkAvans.Size = new System.Drawing.Size(57, 13);
            this.lblIlkAvans.TabIndex = 0;
            this.lblIlkAvans.Text = "İlk Avans :";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.SehirlerTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PersonelKayıt.PersonelVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwAvans);
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1137, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avans Kayıtları";
            // 
            // dgwAvans
            // 
            this.dgwAvans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAvans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwAvans.Location = new System.Drawing.Point(3, 16);
            this.dgwAvans.Name = "dgwAvans";
            this.dgwAvans.Size = new System.Drawing.Size(1131, 220);
            this.dgwAvans.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAvans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1161, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxAvans);
            this.Name = "FormAvans";
            this.Text = "FormAvans";
            this.gbxAvans.ResumeLayout(false);
            this.gbxAvans.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAvans;
        private PersonelVTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblIlkAvansMiktari;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblIlkAvans;
        private System.Windows.Forms.DataGridView dgwAvans;
        private System.Windows.Forms.Button button1;
    }
}