namespace WinFormsExamTest2
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new System.Windows.Forms.Button();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			button_add = new System.Windows.Forms.Button();
			button_add_office = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(246, 277);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(329, 161);
			button1.TabIndex = 0;
			button1.Text = "Показать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.Location = new System.Drawing.Point(208, 27);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new System.Drawing.Size(405, 239);
			dataGridView1.TabIndex = 1;
			// 
			// button_add
			// 
			button_add.Location = new System.Drawing.Point(581, 277);
			button_add.Name = "button_add";
			button_add.Size = new System.Drawing.Size(82, 160);
			button_add.TabIndex = 2;
			button_add.Text = "Добавить";
			button_add.UseVisualStyleBackColor = true;
			button_add.Click += button_add_Click;
			// 
			// button_add_office
			// 
			button_add_office.Location = new System.Drawing.Point(155, 278);
			button_add_office.Name = "button_add_office";
			button_add_office.Size = new System.Drawing.Size(85, 160);
			button_add_office.TabIndex = 3;
			button_add_office.Text = "Добавить офис";
			button_add_office.UseVisualStyleBackColor = true;
			button_add_office.Click += button_add_office_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(button_add_office);
			Controls.Add(button_add);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		private System.Windows.Forms.Button button_add_office;

		private System.Windows.Forms.Button button_add;

		private System.Windows.Forms.DataGridView dataGridView1;

		private System.Windows.Forms.Button button1;

		#endregion
	}
}
