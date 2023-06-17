namespace NoteTakingApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			txtTitle = new TextBox();
			txtNote = new TextBox();
			btnClear = new Button();
			dGVNotes = new DataGridView();
			btnRead = new Button();
			btnDelete = new Button();
			btnSubmit = new Button();
			((System.ComponentModel.ISupportInitialize)dGVNotes).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 23);
			label1.Name = "label1";
			label1.Size = new Size(32, 15);
			label1.TabIndex = 0;
			label1.Text = "Title:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(8, 60);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 1;
			label2.Text = "Note:";
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(67, 20);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(226, 23);
			txtTitle.TabIndex = 2;
			// 
			// txtNote
			// 
			txtNote.Location = new Point(67, 60);
			txtNote.Multiline = true;
			txtNote.Name = "txtNote";
			txtNote.Size = new Size(226, 168);
			txtNote.TabIndex = 3;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(67, 234);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(110, 23);
			btnClear.TabIndex = 4;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// dGVNotes
			// 
			dGVNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dGVNotes.Location = new Point(330, 20);
			dGVNotes.Name = "dGVNotes";
			dGVNotes.RowTemplate.Height = 25;
			dGVNotes.Size = new Size(279, 208);
			dGVNotes.TabIndex = 5;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(330, 234);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(110, 23);
			btnRead.TabIndex = 6;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(499, 234);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(110, 23);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			btnSubmit.Location = new Point(183, 234);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(110, 23);
			btnSubmit.TabIndex = 9;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = true;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(621, 269);
			Controls.Add(btnSubmit);
			Controls.Add(btnDelete);
			Controls.Add(btnRead);
			Controls.Add(dGVNotes);
			Controls.Add(btnClear);
			Controls.Add(txtNote);
			Controls.Add(txtTitle);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dGVNotes).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtTitle;
		private TextBox txtNote;
		private Button btnClear;
		private DataGridView dGVNotes;
		private Button btnRead;
		private Button btnDelete;
		private Button btnSubmit;
	}
}