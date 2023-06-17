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
			btnSubmit = new Button();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			button3 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
			// btnSubmit
			// 
			btnSubmit.Location = new Point(67, 234);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(110, 23);
			btnSubmit.TabIndex = 4;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(330, 20);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(226, 208);
			dataGridView1.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new Point(330, 234);
			button1.Name = "button1";
			button1.Size = new Size(110, 23);
			button1.TabIndex = 6;
			button1.Text = "Read";
			button1.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(446, 234);
			button3.Name = "button3";
			button3.Size = new Size(110, 23);
			button3.TabIndex = 8;
			button3.Text = "Delete";
			button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(183, 234);
			button2.Name = "button2";
			button2.Size = new Size(110, 23);
			button2.TabIndex = 9;
			button2.Text = "Submit";
			button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(572, 269);
			Controls.Add(button2);
			Controls.Add(button3);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(btnSubmit);
			Controls.Add(txtNote);
			Controls.Add(txtTitle);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtTitle;
		private TextBox txtNote;
		private Button btnSubmit;
		private DataGridView dataGridView1;
		private Button button1;
		private Button button3;
		private Button button2;
	}
}