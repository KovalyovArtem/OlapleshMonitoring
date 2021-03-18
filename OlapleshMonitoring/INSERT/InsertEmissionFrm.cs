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
    public partial class InsertEmissionFrm : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public InsertEmissionFrm(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;
        }

        private void InsertEmissionFrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Source". При необходимости она может быть перемещена или удалена.
            this.sourceTableAdapter.Fill(this.olapleshMonitoringDS.Source);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void InsertEmissionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshEmissionDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlAdd = new SqlCommand("INSERT INTO Emission (ID_Source, count, Text, date) VALUES (@ID_Source, @count, @Text, @date)", sqlConnection);
                sqlAdd.Parameters.AddWithValue("ID_Source", cbxIDSource.SelectedValue);
                sqlAdd.Parameters.AddWithValue("count", Convert.ToDouble(tbxCount.Text));
                sqlAdd.Parameters.AddWithValue("Text", tbxText.Text);
                sqlAdd.Parameters.AddWithValue("date", mtbxDate.Text);
                sqlAdd.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
