using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoursDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColoursDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePrimaryTable();
        }

        private void PopulatePrimaryTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ColorType", connection))
            {
                DataTable primaryTable = new DataTable();
                adapter.Fill(primaryTable);

                listPrimary.DisplayMember = "PrimaryColorName";
                listPrimary.ValueMember = "Id";
                listPrimary.DataSource = primaryTable;
            }
        }

        private void listPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShadeTable();
        }

        private void PopulateShadeTable()
        {
            string query = "SELECT Shades.ShadesName FROM ColorType " +
                "INNER JOIN Shades ON Shades.PrimaryColorId = ColorType.Id " +
                "WHERE ColorType.Id = @PrimaryColorId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryColorId", listPrimary.SelectedValue);
                DataTable shadesTable = new DataTable();
                adapter.Fill(shadesTable);

                listShade.DisplayMember = "ShadesName";
                listShade.ValueMember = "Id";
                listShade.DataSource = shadesTable;
            }

        }
    }
}
