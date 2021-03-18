namespace OlapleshMonitoring
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaxQuery = new System.Windows.Forms.Button();
            this.btnAvgQuery = new System.Windows.Forms.Button();
            this.btnMinQuery = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olapleshMonitoringDS = new OlapleshMonitoring.OlapleshMonitoringDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDEmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSourceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSourceEmissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditSource = new System.Windows.Forms.Button();
            this.btnDelSource = new System.Windows.Forms.Button();
            this.btnAddSource = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelEmission = new System.Windows.Forms.Button();
            this.btnAddEmission = new System.Windows.Forms.Button();
            this.btnEditEmission = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.источникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средниеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.SourceTableAdapter();
            this.emissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emissionTableAdapter = new OlapleshMonitoring.OlapleshMonitoringDSTableAdapters.EmissionTableAdapter();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSourceEmissionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMaxQuery);
            this.panel1.Controls.Add(this.btnAvgQuery);
            this.panel1.Controls.Add(this.btnMinQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnMaxQuery
            // 
            this.btnMaxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaxQuery.Location = new System.Drawing.Point(445, 20);
            this.btnMaxQuery.Name = "btnMaxQuery";
            this.btnMaxQuery.Size = new System.Drawing.Size(152, 23);
            this.btnMaxQuery.TabIndex = 2;
            this.btnMaxQuery.Text = "Максимальные выбросы";
            this.btnMaxQuery.UseVisualStyleBackColor = true;
            this.btnMaxQuery.Click += new System.EventHandler(this.btnMaxQuery_Click);
            // 
            // btnAvgQuery
            // 
            this.btnAvgQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAvgQuery.Location = new System.Drawing.Point(230, 20);
            this.btnAvgQuery.Name = "btnAvgQuery";
            this.btnAvgQuery.Size = new System.Drawing.Size(152, 23);
            this.btnAvgQuery.TabIndex = 1;
            this.btnAvgQuery.Text = "Средние выбросы";
            this.btnAvgQuery.UseVisualStyleBackColor = true;
            this.btnAvgQuery.Click += new System.EventHandler(this.btnAvgQuery_Click);
            // 
            // btnMinQuery
            // 
            this.btnMinQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinQuery.Location = new System.Drawing.Point(13, 20);
            this.btnMinQuery.Name = "btnMinQuery";
            this.btnMinQuery.Size = new System.Drawing.Size(152, 23);
            this.btnMinQuery.TabIndex = 0;
            this.btnMinQuery.Text = "Минимальные выбросы";
            this.btnMinQuery.UseVisualStyleBackColor = true;
            this.btnMinQuery.Click += new System.EventHandler(this.btnMinQuery_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 367);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Источник выбросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбросы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSourceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sourceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 159);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDSourceDataGridViewTextBoxColumn
            // 
            this.iDSourceDataGridViewTextBoxColumn.DataPropertyName = "ID_Source";
            this.iDSourceDataGridViewTextBoxColumn.HeaderText = "ID_Source";
            this.iDSourceDataGridViewTextBoxColumn.Name = "iDSourceDataGridViewTextBoxColumn";
            this.iDSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmissionDataGridViewTextBoxColumn,
            this.iDSourceDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKSourceEmissionBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 204);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(594, 160);
            this.dataGridView2.TabIndex = 3;
            // 
            // iDEmissionDataGridViewTextBoxColumn
            // 
            this.iDEmissionDataGridViewTextBoxColumn.DataPropertyName = "ID_Emission";
            this.iDEmissionDataGridViewTextBoxColumn.HeaderText = "ID_Emission";
            this.iDEmissionDataGridViewTextBoxColumn.Name = "iDEmissionDataGridViewTextBoxColumn";
            this.iDEmissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSourceDataGridViewTextBoxColumn1
            // 
            this.iDSourceDataGridViewTextBoxColumn1.DataPropertyName = "ID_Source";
            this.iDSourceDataGridViewTextBoxColumn1.HeaderText = "ID_Source";
            this.iDSourceDataGridViewTextBoxColumn1.Name = "iDSourceDataGridViewTextBoxColumn1";
            this.iDSourceDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // fKSourceEmissionBindingSource
            // 
            this.fKSourceEmissionBindingSource.DataMember = "FK_Source_Emission";
            this.fKSourceEmissionBindingSource.DataSource = this.sourceBindingSource;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditSource);
            this.panel2.Controls.Add(this.btnDelSource);
            this.panel2.Controls.Add(this.btnAddSource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(603, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 159);
            this.panel2.TabIndex = 4;
            // 
            // btnEditSource
            // 
            this.btnEditSource.Location = new System.Drawing.Point(15, 68);
            this.btnEditSource.Name = "btnEditSource";
            this.btnEditSource.Size = new System.Drawing.Size(169, 23);
            this.btnEditSource.TabIndex = 2;
            this.btnEditSource.Text = "Редактировать источник";
            this.btnEditSource.UseVisualStyleBackColor = true;
            this.btnEditSource.Click += new System.EventHandler(this.btnEditSource_Click);
            // 
            // btnDelSource
            // 
            this.btnDelSource.Location = new System.Drawing.Point(15, 38);
            this.btnDelSource.Name = "btnDelSource";
            this.btnDelSource.Size = new System.Drawing.Size(169, 23);
            this.btnDelSource.TabIndex = 1;
            this.btnDelSource.Text = "Удалить источник";
            this.btnDelSource.UseVisualStyleBackColor = true;
            this.btnDelSource.Click += new System.EventHandler(this.btnDelSource_Click);
            // 
            // btnAddSource
            // 
            this.btnAddSource.Location = new System.Drawing.Point(15, 8);
            this.btnAddSource.Name = "btnAddSource";
            this.btnAddSource.Size = new System.Drawing.Size(169, 23);
            this.btnAddSource.TabIndex = 0;
            this.btnAddSource.Text = "Добавить источник";
            this.btnAddSource.UseVisualStyleBackColor = true;
            this.btnAddSource.Click += new System.EventHandler(this.btnAddSource_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelEmission);
            this.panel3.Controls.Add(this.btnAddEmission);
            this.panel3.Controls.Add(this.btnEditEmission);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(603, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 160);
            this.panel3.TabIndex = 5;
            // 
            // btnDelEmission
            // 
            this.btnDelEmission.Location = new System.Drawing.Point(15, 38);
            this.btnDelEmission.Name = "btnDelEmission";
            this.btnDelEmission.Size = new System.Drawing.Size(169, 23);
            this.btnDelEmission.TabIndex = 2;
            this.btnDelEmission.Text = "Удалить выбросы";
            this.btnDelEmission.UseVisualStyleBackColor = true;
            this.btnDelEmission.Click += new System.EventHandler(this.btnDelEmission_Click);
            // 
            // btnAddEmission
            // 
            this.btnAddEmission.Location = new System.Drawing.Point(15, 9);
            this.btnAddEmission.Name = "btnAddEmission";
            this.btnAddEmission.Size = new System.Drawing.Size(169, 23);
            this.btnAddEmission.TabIndex = 1;
            this.btnAddEmission.Text = "Добавить выбросы";
            this.btnAddEmission.UseVisualStyleBackColor = true;
            this.btnAddEmission.Click += new System.EventHandler(this.btnAddEmission_Click);
            // 
            // btnEditEmission
            // 
            this.btnEditEmission.Location = new System.Drawing.Point(15, 67);
            this.btnEditEmission.Name = "btnEditEmission";
            this.btnEditEmission.Size = new System.Drawing.Size(169, 23);
            this.btnEditEmission.TabIndex = 0;
            this.btnEditEmission.Text = "Редактировать выбросы";
            this.btnEditEmission.UseVisualStyleBackColor = true;
            this.btnEditEmission.Click += new System.EventHandler(this.btnEditEmission_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.источникToolStripMenuItem,
            this.выбросыToolStripMenuItem,
            this.расчётыToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // источникToolStripMenuItem
            // 
            this.источникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.источникToolStripMenuItem.Name = "источникToolStripMenuItem";
            this.источникToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.источникToolStripMenuItem.Text = "Источник";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // выбросыToolStripMenuItem
            // 
            this.выбросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1});
            this.выбросыToolStripMenuItem.Name = "выбросыToolStripMenuItem";
            this.выбросыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.выбросыToolStripMenuItem.Text = "Выбросы";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // расчётыToolStripMenuItem
            // 
            this.расчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.минимальныеВыбросыToolStripMenuItem,
            this.средниеВыбросыToolStripMenuItem,
            this.максимальныеВыбросыToolStripMenuItem});
            this.расчётыToolStripMenuItem.Name = "расчётыToolStripMenuItem";
            this.расчётыToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.расчётыToolStripMenuItem.Text = "Расчёт";
            // 
            // минимальныеВыбросыToolStripMenuItem
            // 
            this.минимальныеВыбросыToolStripMenuItem.Name = "минимальныеВыбросыToolStripMenuItem";
            this.минимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.минимальныеВыбросыToolStripMenuItem.Text = "Минимальные выбросы";
            this.минимальныеВыбросыToolStripMenuItem.Click += new System.EventHandler(this.минимальныеВыбросыToolStripMenuItem_Click);
            // 
            // средниеВыбросыToolStripMenuItem
            // 
            this.средниеВыбросыToolStripMenuItem.Name = "средниеВыбросыToolStripMenuItem";
            this.средниеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.средниеВыбросыToolStripMenuItem.Text = "Средние выбросы";
            this.средниеВыбросыToolStripMenuItem.Click += new System.EventHandler(this.средниеВыбросыToolStripMenuItem_Click);
            // 
            // максимальныеВыбросыToolStripMenuItem
            // 
            this.максимальныеВыбросыToolStripMenuItem.Name = "максимальныеВыбросыToolStripMenuItem";
            this.максимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.максимальныеВыбросыToolStripMenuItem.Text = "Максимальные выбросы";
            this.максимальныеВыбросыToolStripMenuItem.Click += new System.EventHandler(this.максимальныеВыбросыToolStripMenuItem_Click);
            // 
            // sourceTableAdapter
            // 
            this.sourceTableAdapter.ClearBeforeFill = true;
            // 
            // emissionBindingSource
            // 
            this.emissionBindingSource.DataMember = "Emission";
            this.emissionBindingSource.DataSource = this.olapleshMonitoringDS;
            // 
            // emissionTableAdapter
            // 
            this.emissionTableAdapter.ClearBeforeFill = true;
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem1});
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.обновитьToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OlapleshMonitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olapleshMonitoringDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSourceEmissionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem источникToolStripMenuItem;
        private OlapleshMonitoringDS olapleshMonitoringDS;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private OlapleshMonitoringDSTableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emissionBindingSource;
        private OlapleshMonitoringDSTableAdapters.EmissionTableAdapter emissionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSourceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKSourceEmissionBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditEmission;
        private System.Windows.Forms.Button btnMaxQuery;
        private System.Windows.Forms.Button btnAvgQuery;
        private System.Windows.Forms.Button btnMinQuery;
        private System.Windows.Forms.Button btnEditSource;
        private System.Windows.Forms.Button btnDelSource;
        private System.Windows.Forms.Button btnAddSource;
        private System.Windows.Forms.Button btnDelEmission;
        private System.Windows.Forms.Button btnAddEmission;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средниеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
    }
}

