using System;
using System.Collections.Generic;
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

namespace Vegetables_Fruits
{

    public partial class MainWindow : Window
    {
        static SqlConnection conn = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Vegetables; Integrated Security=SSPI;");
                conn.Open();
                Label.Background = new SolidColorBrush(Colors.Green);
                Label.Content = "База данных подключена";
            }
            catch
            {
                Label.Background = new SolidColorBrush(Colors.Red);
                Label.Content = "База данных неподключена";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Close();
                Label.Background = new SolidColorBrush(Colors.Red);
                Label.Content = "База данных отключена";
            }
            catch {
                Label.Background = new SolidColorBrush(Colors.Red);
                Label.Content = "Проблемки";
            }
        }

        private void All_Table_Click(object sender, RoutedEventArgs e)
        {
            Wiwod.Text = "";
            string insertString = @"select * from OORF;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertString;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Wiwod.Text += reader[i] + "\t";
                }
                Wiwod.Text += "\n";
            }
            reader.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Wiwod.Text = "";
            string insertString = @"select Title from OORF";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertString;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Wiwod.Text += reader[i] + "\t";
                }
                Wiwod.Text += "\n";
            }
            reader.Close();
        }

        private void Button_Colors(object sender, RoutedEventArgs e)
        {
            Wiwod.Text = "";
            string insertString = @"select Color from OORF";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertString;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Wiwod.Text += reader[i] + "\t";
                }
                Wiwod.Text += "\n";
            }
            reader.Close();
        }

        private void Button_Max(object sender, RoutedEventArgs e)
        {
            Wiwod.Text = "";
            string insertString = @"select MAX(Calorie) from OORF";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertString;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Wiwod.Text += reader[i] + "\t";
                }
                Wiwod.Text += "\n";
            }
            reader.Close();
        }

        private void Button_Min_Click(RoutedEventArgs e)
        {

        }

        private void Button_Min_Click(object sender, RoutedEventArgs e)
        {
            Wiwod.Text = "";
            string insertString = @"select MIN(Calorie) from OORF";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertString;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Wiwod.Text += reader[i] + "\t";
                }
                Wiwod.Text += "\n";
            }
            reader.Close();
        }

        private void Button_Cr_Click(object sender, RoutedEventArgs e)
        {
            Wiwod.Text = "";
            string insertString = @"select avg(Calorie) from OORF";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertString;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Wiwod.Text += reader[i] + "\t";
                }
                Wiwod.Text += "\n";
            }
            reader.Close();
        }
    }
}
