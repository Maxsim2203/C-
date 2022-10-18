using System.Configuration;
using System.Data;
using System;
using System.Data.SqlClient;

namespace WinFormsAdoNet
{
    public partial class MainWindow : Form
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
                dataGridView1.DataSource = usersTable.DefaultView;
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