namespace WinFormsExamTest2
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (AppContext db = new AppContext())
			{
				var выгрузка = db.Клиенты.ToList();
				dataGridView1.DataSource = выгрузка;

				ShowClients();

			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			using (AppContext db = new AppContext())
			{
				var офис = db.Офисы.FirstOrDefault(o => o.Город == "Таллин");
				var новый_клиент = new Клиент{Имя = "Валера", Возраст = 25, Фамилия = "Валер", ОфисId = офис.Id,};
				db.Клиенты.Add(новый_клиент);
				db.SaveChanges();
			}
		}

		private void button_add_office_Click(object sender, EventArgs e)
		{
			using (AppContext db = new AppContext())
			{
				var новый_офис = new Офис { Название = "Иголки", Город = "Таллин"};
				db.Add(новый_офис);
				db.SaveChanges();
			}
			
		}

		private void ShowClients()
		{
			panel1.Controls.Clear();
			int y = 10;
			int spacing = 10;

			using (AppContext db = new AppContext())
			{

				var clients = db.Клиенты.ToList();

				foreach (var client in clients)
				{
					var card = new UserControlTest();
					card.ИмяФорма = client.Имя;
					card.ФамилияФорма = client.Фамилия;
					card.ВозрастФорма = client.Возраст.ToString();

					card.Left = 10;
					card.Top = y;
					card.Width = panel1.Width - 40;

					panel1.Controls.Add(card);

					y += card.Height + spacing;
				}
			}
		}

	}
}
