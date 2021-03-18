namespace OlapleshMonitoring
{
    partial class EditEmissionFrm
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.cbxIDEmission = new System.Windows.Forms.ComboBox();
            this.emissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olapleshMonitoringDS = new OlapleshMonitoring.OlapleshMonitoringDS();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.tbx_Text = new System.Windows.Forms.TextBox();
            this.mtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.emissionTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.EmissionTableAdapter();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourceTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.SourceTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(13, 199);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(89, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Изменить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbxIDEmission
            // 
            this.cbxIDEmission.DataSource = this.emissionBindingSource;
            this.cbxIDEmission.DisplayMember = "ID_Emission";
            this.cbxIDEmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDEmission.FormattingEnabled = true;
            this.cbxIDEmission.Location = new System.Drawing.Point(13, 28);
            this.cbxIDEmission.Name = "cbxIDEmission";
            this.cbxIDEmission.Size = new System.Drawing.Size(194, 21);
            this.cbxIDEmission.TabIndex = 1;
            this.cbxIDEmission.ValueMember = "ID_Emission";
            // 
            // emissionBindingSource
            // 
            this.emissionBindingSource.DataMember = "Emission";
            this.emissionBindingSource.DataSource = this.olapleshMonitoringDS;
            // 
            // olapleshMonitoringDS
            // 
            this.olapleshMonitoringDS.DataSetName = "OlapleshMonitoringDS";
            this.olapleshMonitoringDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(13, 71);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(194, 20);
            this.tbxCount.TabIndex = 2;
            // 
            // tbx_Text
            // 
            this.tbx_Text.Location = new System.Drawing.Point(13, 112);
            this.tbx_Text.Name = "tbx_Text";
            this.tbx_Text.Size = new System.Drawing.Size(194, 20);
            this.tbx_Text.TabIndex = 3;
            // 
            // mtbxDate
            // 
            this.mtbxDate.Location = new System.Drawing.Point(13, 158);
            this.mtbxDate.Mask = "00/00/0000";
            this.mtbxDate.Name = "mtbxDate";
            this.mtbxDate.Size = new System.Drawing.Size(194, 20);
            this.mtbxDate.TabIndex = 4;
            this.mtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // emissionTableAdapter
            // 
            this.emissionTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер выброса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество выбросов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Объяснение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditEmissionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbxDate);
            this.Controls.Add(this.tbx_Text);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.cbxIDEmission);
            this.Controls.Add(this.btnAccept);
            this.Name = "EditEmissionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать выбросы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditEmissionFrm_FormClosing);
            this.Load += new System.EventHandler(this.EditEmissionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbxIDEmission;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.TextBox tbx_Text;
        private System.Windows.Forms.MaskedTextBox mtbxDate;
        private OlapleshMonitoringDS olapleshMonitoringDS;
        private System.Windows.Forms.BindingSource emissionBindingSource;
        private OlapleshMonitoringDSTableAdapters.EmissionTableAdapter emissionTableAdapter;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private OlapleshMonitoringDSTableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}