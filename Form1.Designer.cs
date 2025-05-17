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
			button1 = new Button();
			dataGridView1 = new DataGridView();
			button_add = new Button();
			button_add_office = new Button();
			panel1 = new Panel();
			userControlTest1 = new UserControlTest();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(246, 277);
			button1.Name = "button1";
			button1.Size = new Size(329, 161);
			button1.TabIndex = 0;
			button1.Text = "Показать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.Location = new Point(12, 32);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(228, 239);
			dataGridView1.TabIndex = 1;
			// 
			// button_add
			// 
			button_add.Location = new Point(581, 277);
			button_add.Name = "button_add";
			button_add.Size = new Size(82, 160);
			button_add.TabIndex = 2;
			button_add.Text = "Добавить";
			button_add.UseVisualStyleBackColor = true;
			button_add.Click += button_add_Click;
			// 
			// button_add_office
			// 
			button_add_office.Location = new Point(155, 278);
			button_add_office.Name = "button_add_office";
			button_add_office.Size = new Size(85, 160);
			button_add_office.TabIndex = 3;
			button_add_office.Text = "Добавить офис";
			button_add_office.UseVisualStyleBackColor = true;
			button_add_office.Click += button_add_office_Click;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Controls.Add(userControlTest1);
			panel1.Location = new Point(246, 32);
			panel1.Name = "panel1";
			panel1.Size = new Size(508, 239);
			panel1.TabIndex = 4;
			// 
			// userControlTest1
			// 
			userControlTest1.BorderStyle = BorderStyle.FixedSingle;
			userControlTest1.Location = new Point(3, 3);
			userControlTest1.Name = "userControlTest1";
			userControlTest1.Size = new Size(502, 148);
			userControlTest1.TabIndex = 0;
			userControlTest1.ВозрастФорма = "Возраст";
			userControlTest1.ИмяФорма = "Имя";
			userControlTest1.ФамилияФорма = "Фамилия";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Controls.Add(button_add_office);
			Controls.Add(button_add);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		private System.Windows.Forms.Button button_add_office;

		private System.Windows.Forms.Button button_add;

		private System.Windows.Forms.DataGridView dataGridView1;

		private System.Windows.Forms.Button button1;

		#endregion

		private Panel panel1;
		private UserControlTest userControlTest1;
	}
}
