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
    public partial class MinQuery : Form
    {
        private SqlConnection sqlConnection = null;

        public MinQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinQuery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Source". При необходимости она может быть перемещена или удалена.
            this.sourceTableAdapter.Fill(this.olapleshMonitoringDS.Source);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Emission". При необходимости она может быть перемещена или удалена.
            this.emissionTableAdapter.Fill(this.olapleshMonitoringDS.Emission);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Emission WHERE count = (SELECT MIN(count) FROM Emission)", sqlConnection);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
