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
    public partial class EditEmissionFrm : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public EditEmissionFrm(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;
        }

        private void EditEmissionFrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Source". При необходимости она может быть перемещена или удалена.
            this.sourceTableAdapter.Fill(this.olapleshMonitoringDS.Source);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "olapleshMonitoringDS.Emission". При необходимости она может быть перемещена или удалена.
            this.emissionTableAdapter.Fill(this.olapleshMonitoringDS.Emission);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OlapleshMonitoring.Properties.Settings.OlapleshMonitoringConnectionString"].ConnectionString);
            sqlConnection.Open();

            tbxCount.DataBindings.Add(new Binding("Text", emissionBindingSource, "count", true));
            tbx_Text.DataBindings.Add(new Binding("Text", emissionBindingSource, "Text", true));
            mtbxDate.DataBindings.Add(new Binding("Text", emissionBindingSource, "date", true));
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlEdit = new SqlCommand("UPDATE Emission SET count = @count, Text = @Text, date = @date WHERE ID_Emission = @Id", sqlConnection);
                sqlEdit.Parameters.AddWithValue("count", Convert.ToDouble(tbxCount.Text));//float.Parse(tbxCount.Text)
                sqlEdit.Parameters.AddWithValue("Text", tbx_Text.Text);
                sqlEdit.Parameters.AddWithValue("date", Convert.ToDateTime(mtbxDate.Text));
                sqlEdit.Parameters.AddWithValue("Id", cbxIDEmission.SelectedValue);
                sqlEdit.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void EditEmissionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshEmissionDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
