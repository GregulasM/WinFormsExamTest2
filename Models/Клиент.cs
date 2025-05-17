namespace WinFormsExamTest2;

public class Клиент
{
    public int Id { get; set; }
    public string Имя { get; set; }
    public string Фамилия { get; set; }
    public int Возраст { get; set; }
    
    public int ОфисId { get; set; }
    public Офис Офис { get; set; }
}