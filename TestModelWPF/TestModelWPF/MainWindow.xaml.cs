using System;
using System.Collections.Generic;
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
using TestModelWPF.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics;

namespace TestModelWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Проверка подключения базы данных EF

            using (UserContext db = new UserContext())
            {

                /* Создание пользователей
                
                User user1 = new User() { Name = "user2", Age = 11 };
                User user2 = new User() { Name = "user3", Age = 12 };
                db.Users.AddRange(user1,user2);
                db.SaveChanges();
                */

                phonesGrid.ItemsSource = db.Users.ToList();
            }



        }
    }
}
