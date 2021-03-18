namespace OlapleshMonitoring
{
    partial class MinQuery
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDEmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olapleshMonitoringDS = new OlapleshMonitoring.OlapleshMonitoringDS();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourceTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.SourceTableAdapter();
            this.emissionTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.EmissionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmissionDataGridViewTextBoxColumn,
            this.iDSourceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emissionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDEmissionDataGridViewTextBoxColumn
            // 
            this.iDEmissionDataGridViewTextBoxColumn.DataPropertyName = "ID_Emission";
            this.iDEmissionDataGridViewTextBoxColumn.HeaderText = "ID_Emission";
            this.iDEmissionDataGridViewTextBoxColumn.Name = "iDEmissionDataGridViewTextBoxColumn";
            this.iDEmissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSourceDataGridViewTextBoxColumn
            // 
            this.iDSourceDataGridViewTextBoxColumn.DataPropertyName = "ID_Source";
            this.iDSourceDataGridViewTextBoxColumn.HeaderText = "ID_Source";
            this.iDSourceDataGridViewTextBoxColumn.Name = "iDSourceDataGridViewTextBoxColumn";
            this.iDSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Хорошо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // emissionTableAdapter
            // 
            this.emissionTableAdapter.ClearBeforeFill = true;
            // 
            // MinQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MinQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Минимальные выбросы";
            this.Load += new System.EventHandler(this.MinQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private OlapleshMonitoringDS olapleshMonitoringDS;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private OlapleshMonitoringDSTableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.BindingSource emissionBindingSource;
        private OlapleshMonitoringDSTableAdapters.EmissionTableAdapter emissionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}