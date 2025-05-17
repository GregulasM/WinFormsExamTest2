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
	}
}
