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
    public partial class AvgQuery : Form
    {
        private SqlConnection sqlConnection = null;

        public AvgQuery()
        {
            InitializeComponent();
        }

        private void AvgQuery_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT AVG(count) FROM Emission", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[1]);

                data[data.Count - 1][0] = reader[0].ToString();
            }
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
