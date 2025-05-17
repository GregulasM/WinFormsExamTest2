namespace WinFormsExamTest2;

public class Офис
{
    public int Id { get; set; }
    public string Название { get; set; }
    public string Город { get; set; }
    
    public List<Клиент> Клиенты { get; set; }
    public List<Товар> Товары { get; set; }
}