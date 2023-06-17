using System.Data;

namespace NoteTakingApp
{
	public partial class Form1 : Form
	{
		DataTable dataTable;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataTable = new DataTable();
			dataTable.Columns.Add("Title", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));

			dGVNotes.DataSource = dataTable;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtTitle.Clear();
			txtNote.Clear();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			dataTable.Rows.Add(txtTitle.Text, txtNote.Text);

			txtTitle.Clear();
			txtNote.Clear();
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			int index = dGVNotes.CurrentCell.RowIndex;

			if (index > -1)
			{
				txtTitle.Text = dataTable.Rows[index].ItemArray[0].ToString();
				txtNote.Text = dataTable.Rows[index].ItemArray[1].ToString();
			}
		}
	}
}