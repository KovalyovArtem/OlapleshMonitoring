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
    public partial class InsertSourceFrm : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public InsertSourceFrm(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertSourceFrm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void InsertSourceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshSourceDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlAdd = new SqlCommand("INSERT INTO Source (Name, Adress) VALUES (@Name, @Adress)", sqlConnection);
                sqlAdd.Parameters.AddWithValue("Name", tbxNameSource.Text);
                sqlAdd.Parameters.AddWithValue("Adress", tbxAdresSource.Text);
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
