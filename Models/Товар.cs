namespace WinFormsExamTest2;

public class Товар
{
    public int Id { get; set; }
    public string Название { get; set; }
    public string Кодификатор { get; set; }
    
    public List<Офис> Офисы { get; set; }
}