namespace OlapleshMonitoring
{
    partial class InsertEmissionFrm
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
            this.cbxIDSource = new System.Windows.Forms.ComboBox();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olapleshMonitoringDS = new OlapleshMonitoring.OlapleshMonitoringDS();
            this.sourceTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.SourceTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIDSource
            // 
            this.cbxIDSource.DataSource = this.sourceBindingSource;
            this.cbxIDSource.DisplayMember = "Name";
            this.cbxIDSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDSource.FormattingEnabled = true;
            this.cbxIDSource.Location = new System.Drawing.Point(12, 38);
            this.cbxIDSource.Name = "cbxIDSource";
            this.cbxIDSource.Size = new System.Drawing.Size(202, 21);
            this.cbxIDSource.TabIndex = 0;
            this.cbxIDSource.ValueMember = "ID_Source";
            // 
            // sourceBindingSource
            // 
            this.sourceBindingSource.DataMember = "Source";
            this.sourceBindingSource.DataSource = this.olapleshMonitoringDS;
            // 
            // olapleshMonitoringDS
            // 
            this.olapleshMonitoringDS.DataSetName = "OlapleshMonitoringDS";
            this.olapleshMonitoringDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sourceTableAdapter
            // 
            this.sourceTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество выбросов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Комментарий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата";
            // 
            // mtbxDate
            // 
            this.mtbxDate.Location = new System.Drawing.Point(12, 171);
            this.mtbxDate.Mask = "00/00/0000";
            this.mtbxDate.Name = "mtbxDate";
            this.mtbxDate.Size = new System.Drawing.Size(202, 20);
            this.mtbxDate.TabIndex = 5;
            this.mtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(12, 83);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(202, 20);
            this.tbxCount.TabIndex = 6;
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(12, 127);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(202, 20);
            this.tbxText.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertEmissionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.mtbxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxIDSource);
            this.Name = "InsertEmissionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить выбросы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertEmissionFrm_FormClosing);
            this.Load += new System.EventHandler(this.InsertEmissionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIDSource;
        private OlapleshMonitoringDS olapleshMonitoringDS;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private OlapleshMonitoringDSTableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbxDate;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}