using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OlapleshMonitoring
{
    public partial class EditSourceFrm : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public EditSourceFrm(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;
        }

        private void EditSourceFrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Source". При необходимости она может быть перемещена или удалена.
            this.sourceTableAdapter.Fill(this.olapleshMonitoringDS.Source);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();

            tbxNameSource.DataBindings.Add(new Binding("Text", sourceBindingSource, "Name", true));
            tbxAdresSource.DataBindings.Add(new Binding("Text", sourceBindingSource, "Adress", true));
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSourceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshSourceDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlEdit = new SqlCommand("UPDATE Source SET Name = @Name, Adress = @Adress WHERE ID_Source = @Id", sqlConnection);
                sqlEdit.Parameters.AddWithValue("Name", tbxNameSource.Text);
                sqlEdit.Parameters.AddWithValue("Adress", tbxAdresSource.Text);
                sqlEdit.Parameters.AddWithValue("Id", cbxIDSource.SelectedValue);
                sqlEdit.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
