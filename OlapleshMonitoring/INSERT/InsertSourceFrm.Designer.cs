namespace OlapleshMonitoring
{
    partial class InsertSourceFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNameSource = new System.Windows.Forms.TextBox();
            this.tbxAdresSource = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес источника";
            // 
            // tbxNameSource
            // 
            this.tbxNameSource.Location = new System.Drawing.Point(13, 30);
            this.tbxNameSource.Name = "tbxNameSource";
            this.tbxNameSource.Size = new System.Drawing.Size(281, 20);
            this.tbxNameSource.TabIndex = 2;
            // 
            // tbxAdresSource
            // 
            this.tbxAdresSource.Location = new System.Drawing.Point(13, 76);
            this.tbxAdresSource.Name = "tbxAdresSource";
            this.tbxAdresSource.Size = new System.Drawing.Size(281, 20);
            this.tbxAdresSource.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(191, 114);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(103, 23);
            this.btnDis.TabIndex = 5;
            this.btnDis.Text = "Отмена";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // InsertSourceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 154);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxAdresSource);
            this.Controls.Add(this.tbxNameSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertSourceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить источник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertSourceFrm_FormClosing);
            this.Load += new System.EventHandler(this.InsertSourceFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNameSource;
        private System.Windows.Forms.TextBox tbxAdresSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDis;
    }
}