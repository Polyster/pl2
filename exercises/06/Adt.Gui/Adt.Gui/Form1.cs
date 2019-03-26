using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adt.Gui
{
	public partial class Form1 : Form
	{
		private const string TableName = "Student";
		private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=pl2;Trusted_Connection=True;";

		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'studentDS.Student' table. You can move, or remove it, as needed.
			//this.studentTableAdapter.Fill(this.studentDS.Student);
		}

		private void LoadButtton_Click(object sender, EventArgs e)
		{
			bool parsed = int.TryParse(countTxtBox.Text, out int count);
			if (parsed)
			{
				string sqlStatement = $"SELECT TOP {count} * FROM Student";
				var dataTable = new DataTable();
				if (tabControl.SelectedIndex == 0)
				{
					var connection = new SqlConnection(ConnectionString);
					var dataAdapter = new SqlDataAdapter(sqlStatement, connection);
					
					var dataSet = new DataSet();
					dataAdapter.Fill(dataSet, TableName);

					dataTable = dataSet.Tables[dataSet.Tables.IndexOf(TableName)]; // dataSet.Tables[0]
					disconnectedGridView.DataSource = dataTable;
				}
				else if (tabControl.SelectedIndex == 1)
				{
					var connection = new SqlConnection(ConnectionString);
					connection.Open();
					var command = new SqlCommand(sqlStatement, connection);
					var reader = command.ExecuteReader();

					// while(reader.Read()){ reader... }

					dataTable.Load(reader);
					connectedGridView.DataSource = dataTable;
					reader.Close();
					connection.Close();
				}
			}
		}
	}
}