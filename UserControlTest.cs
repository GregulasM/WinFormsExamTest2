namespace WinFormsExamTest2;

public partial class UserControlTest : UserControl
{
    public UserControlTest()
    {
        InitializeComponent();
    }

    public string ИмяФорма
    {
        get => label_fname_usercon.Text;
        set => label_fname_usercon.Text = value;
    }
    
    public string ФамилияФорма
    {
        get => label_lname_usercon.Text;
        set => label_lname_usercon.Text = value;
    }
    
    public string ВозрастФорма
    {
        get => label_age_usercon.Text;
        set => label_age_usercon.Text = value;
    }

    private void UserControlTest_Load(object sender, EventArgs e)
    {
    }
}