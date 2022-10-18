using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAdoNet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string sql = "SELECT * FROM Users";
            var usersTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                //connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=UserDatabase;Trusted_Connection=True;");
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionLocalDb"].ToString());


                SqlCommand command = new SqlCommand(sql, connection);
                var adapter = new SqlDataAdapter(command);

                //установка команды на добавление для вызова хранимой процедуры
                //adapter.InsertCommand = new SqlCommand("sp_InsertUsers", connection);
                //adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                //adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 10, "name"));
                //adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 10, "age"));

                //SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "id");
                //parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(usersTable);
                grid1.ItemsSource = usersTable.DefaultView;  // Заметь, что не DataSource, а ItemSource, чтобы Binding работал в xaml
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }









        }
    }
}
