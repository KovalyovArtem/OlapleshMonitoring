using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OlapleshMonitoring
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Source". При необходимости она может быть перемещена или удалена.
            this.sourceTableAdapter.Fill(this.olapleshMonitoringDS.Source);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Emission". При необходимости она может быть перемещена или удалена.
            this.emissionTableAdapter.Fill(this.olapleshMonitoringDS.Emission);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        public void RefreshSourceDGV()
        {
            olapleshMonitoringDS.EnforceConstraints = false;
            this.sourceTableAdapter.Fill(this.olapleshMonitoringDS.Source);
            olapleshMonitoringDS.EnforceConstraints = true;
        }

        public void RefreshEmissionDGV()
        {
            this.emissionTableAdapter.Fill(this.olapleshMonitoringDS.Emission);
        }

        #region Кнопки Выбросов
        private void btnEditEmission_Click(object sender, EventArgs e)
        {
            EditEmissionFrm editEmissionFrm = new EditEmissionFrm(this);
            editEmissionFrm.Show();
        }

        private void btnDelEmission_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView2.SelectedRows[0].Index;

                    int rowID = int.Parse(dataGridView2[0, selectedIndex].Value.ToString());
                    SqlCommand sqlDel = new SqlCommand("DELETE FROM Emission WHERE ID_Emission = @id", sqlConnection);
                    sqlDel.Parameters.AddWithValue("id", rowID);
                    sqlDel.ExecuteNonQuery();
                    RefreshEmissionDGV();
                }
            }
        }

        private void btnAddEmission_Click(object sender, EventArgs e)
        {
            InsertEmissionFrm insertEmissionFrm = new InsertEmissionFrm(this);
            insertEmissionFrm.Show();
        }
        #endregion
        #region Кнопки Источников
        private void btnAddSource_Click(object sender, EventArgs e)
        {
            InsertSourceFrm insertSourceFrm = new InsertSourceFrm(this);
            insertSourceFrm.Show();
        }

        private void btnDelSource_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                    SqlCommand sqlDel = new SqlCommand("DELETE FROM Emission WHERE ID_Source = @id;" +
                    "DELETE FROM Source WHERE ID_Source = @id", sqlConnection);
                    sqlDel.Parameters.AddWithValue("id", rowID);
                    sqlDel.ExecuteNonQuery();
                    RefreshSourceDGV();
                }
            }
        }

        private void btnEditSource_Click(object sender, EventArgs e)
        {
            EditSourceFrm editSourceFrm = new EditSourceFrm(this);
            editSourceFrm.Show();
        }
        #endregion
        #region Кнопки запросов    
        private void btnMinQuery_Click(object sender, EventArgs e)
        {
            MinQuery minQuery = new MinQuery();
            minQuery.Show();
        }

        private void btnAvgQuery_Click(object sender, EventArgs e)
        {
            AvgQuery avgQuery = new AvgQuery();
            avgQuery.Show();
        }

        private void btnMaxQuery_Click(object sender, EventArgs e)
        {
            MaxQuery maxQuery = new MaxQuery();
            maxQuery.Show();
        }
        #endregion

        #region Кнопки меню Источник
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddSource_Click(sender, e);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelSource_Click(sender, e);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditSource_Click(sender, e);
        }
        #endregion
        #region Кнопки меню Выбросы
        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnAddEmission_Click(sender, e);
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDelEmission_Click(sender, e);
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnEditEmission_Click(sender, e);
        }
        #endregion
        #region Кнопки меню Расчёт
        private void минимальныеВыбросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMinQuery_Click(sender, e);
        }

        private void средниеВыбросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAvgQuery_Click(sender, e);
        }

        private void максимальныеВыбросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMaxQuery_Click(sender, e);
        }
        #endregion

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshEmissionDGV();
            RefreshSourceDGV();
        }
    }
}
