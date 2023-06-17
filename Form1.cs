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
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtTitle.Clear();
			txtNote.Clear();
		}
	}
}