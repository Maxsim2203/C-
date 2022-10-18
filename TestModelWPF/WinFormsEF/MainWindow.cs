using TestModelWPF.Models;

namespace WinFormsEF
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            using(UserContext db = new UserContext())
            {
                dataGridView1.DataSource = db.Users.ToList();
            }

        }
    }
}