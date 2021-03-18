namespace OlapleshMonitoring
{
    partial class EditSourceFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxIDSource = new System.Windows.Forms.ComboBox();
            this.olapleshMonitoringDS = new OlapleshMonitoring.OlapleshMonitoringDS();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourceTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.SourceTableAdapter();
            this.tbxNameSource = new System.Windows.Forms.TextBox();
            this.tbxAdresSource = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес";
            // 
            // cbxIDSource
            // 
            this.cbxIDSource.DataSource = this.sourceBindingSource;
            this.cbxIDSource.DisplayMember = "ID_Source";
            this.cbxIDSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDSource.FormattingEnabled = true;
            this.cbxIDSource.Location = new System.Drawing.Point(13, 30);
            this.cbxIDSource.Name = "cbxIDSource";
            this.cbxIDSource.Size = new System.Drawing.Size(203, 21);
            this.cbxIDSource.TabIndex = 3;
            this.cbxIDSource.ValueMember = "ID_Source";
            // 
            // olapleshMonitoringDS
            // 
            this.olapleshMonitoringDS.DataSetName = "OlapleshMonitoringDS";
            this.olapleshMonitoringDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sourceBindingSource
            // 
            this.sourceBindingSource.DataMember = "Source";
            this.sourceBindingSource.DataSource = this.olapleshMonitoringDS;
            // 
            // sourceTableAdapter
            // 
            this.sourceTableAdapter.ClearBeforeFill = true;
            // 
            // tbxNameSource
            // 
            this.tbxNameSource.Location = new System.Drawing.Point(13, 83);
            this.tbxNameSource.Name = "tbxNameSource";
            this.tbxNameSource.Size = new System.Drawing.Size(203, 20);
            this.tbxNameSource.TabIndex = 4;
            // 
            // tbxAdresSource
            // 
            this.tbxAdresSource.Location = new System.Drawing.Point(13, 131);
            this.tbxAdresSource.Name = "tbxAdresSource";
            this.tbxAdresSource.Size = new System.Drawing.Size(203, 20);
            this.tbxAdresSource.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 157);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(119, 157);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(97, 23);
            this.btnDis.TabIndex = 7;
            this.btnDis.Text = "Отмена";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // EditSourceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 197);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxAdresSource);
            this.Controls.Add(this.tbxNameSource);
            this.Controls.Add(this.cbxIDSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSourceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать источник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSourceFrm_FormClosing);
            this.Load += new System.EventHandler(this.EditSourceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxIDSource;
        private OlapleshMonitoringDS olapleshMonitoringDS;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private OlapleshMonitoringDSTableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.TextBox tbxNameSource;
        private System.Windows.Forms.TextBox tbxAdresSource;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDis;
    }
}