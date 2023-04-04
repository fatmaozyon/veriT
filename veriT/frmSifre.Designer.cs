
namespace veriT
{
    partial class frmSifre
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
            this.tableDoktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odev1DataSet3 = new veriT.Odev1DataSet3();
            this.odev1DataSet = new veriT.Odev1DataSet();
            this.odev1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDoktorTableAdapter = new veriT.Odev1DataSet3TableAdapters.TableDoktorTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tctxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.parolattxt = new System.Windows.Forms.TextBox();
            this.parolatxt = new System.Windows.Forms.TextBox();
            this.KullanıcıAdıtxt = new System.Windows.Forms.TextBox();
            this.Soyadtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BolumIdtxt = new System.Windows.Forms.TextBox();
            this.Adtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableDoktorBindingSource
            // 
            this.tableDoktorBindingSource.DataMember = "TableDoktor";
            this.tableDoktorBindingSource.DataSource = this.odev1DataSet3;
            // 
            // odev1DataSet3
            // 
            this.odev1DataSet3.DataSetName = "Odev1DataSet3";
            this.odev1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odev1DataSet
            // 
            this.odev1DataSet.DataSetName = "Odev1DataSet";
            this.odev1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odev1DataSetBindingSource
            // 
            this.odev1DataSetBindingSource.DataSource = this.odev1DataSet;
            this.odev1DataSetBindingSource.Position = 0;
            // 
            // tableDoktorTableAdapter
            // 
            this.tableDoktorTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tctxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.parolattxt);
            this.groupBox2.Controls.Add(this.parolatxt);
            this.groupBox2.Controls.Add(this.KullanıcıAdıtxt);
            this.groupBox2.Controls.Add(this.Soyadtxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.BolumIdtxt);
            this.groupBox2.Controls.Add(this.Adtxt);
            this.groupBox2.Location = new System.Drawing.Point(196, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 355);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Güncelleme";
            // 
            // tctxt
            // 
            this.tctxt.Location = new System.Drawing.Point(175, 281);
            this.tctxt.Name = "tctxt";
            this.tctxt.Size = new System.Drawing.Size(114, 22);
            this.tctxt.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(26, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "TC";
            // 
            // parolattxt
            // 
            this.parolattxt.Location = new System.Drawing.Point(175, 233);
            this.parolattxt.Name = "parolattxt";
            this.parolattxt.PasswordChar = '*';
            this.parolattxt.Size = new System.Drawing.Size(114, 22);
            this.parolattxt.TabIndex = 17;
            // 
            // parolatxt
            // 
            this.parolatxt.Location = new System.Drawing.Point(175, 193);
            this.parolatxt.Name = "parolatxt";
            this.parolatxt.PasswordChar = '*';
            this.parolatxt.Size = new System.Drawing.Size(114, 22);
            this.parolatxt.TabIndex = 16;
            // 
            // KullanıcıAdıtxt
            // 
            this.KullanıcıAdıtxt.Location = new System.Drawing.Point(175, 144);
            this.KullanıcıAdıtxt.Name = "KullanıcıAdıtxt";
            this.KullanıcıAdıtxt.Size = new System.Drawing.Size(114, 22);
            this.KullanıcıAdıtxt.TabIndex = 15;
            // 
            // Soyadtxt
            // 
            this.Soyadtxt.Location = new System.Drawing.Point(175, 104);
            this.Soyadtxt.Name = "Soyadtxt";
            this.Soyadtxt.Size = new System.Drawing.Size(114, 22);
            this.Soyadtxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(26, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Parola Tekrar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(26, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Parola";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(26, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(26, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bölüm ıd";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Location = new System.Drawing.Point(128, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BolumIdtxt
            // 
            this.BolumIdtxt.Location = new System.Drawing.Point(175, 27);
            this.BolumIdtxt.Name = "BolumIdtxt";
            this.BolumIdtxt.Size = new System.Drawing.Size(114, 22);
            this.BolumIdtxt.TabIndex = 6;
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(175, 66);
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(114, 22);
            this.Adtxt.TabIndex = 7;
            // 
            // frmSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSifre";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource odev1DataSetBindingSource;
        private Odev1DataSet odev1DataSet;
        private Odev1DataSet3 odev1DataSet3;
        private System.Windows.Forms.BindingSource tableDoktorBindingSource;
        private Odev1DataSet3TableAdapters.TableDoktorTableAdapter tableDoktorTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tctxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox parolattxt;
        private System.Windows.Forms.TextBox parolatxt;
        private System.Windows.Forms.TextBox KullanıcıAdıtxt;
        private System.Windows.Forms.TextBox Soyadtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox BolumIdtxt;
        private System.Windows.Forms.TextBox Adtxt;
    }
}