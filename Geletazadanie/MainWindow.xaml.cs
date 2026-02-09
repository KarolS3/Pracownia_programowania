using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pesel = _pesel.Text;

            int peselint;
            if (!Int32.TryParse(pesel, out peselint))
            {
                _test.Content = "Zły format peselu";
                return;
            }
           

            string haslo = _haslo.Password;
            using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.175.85;Initial Catalog=szkola;User ID=admin2;Password=123;Connect Timeout=30"))
            {
                conn.Open();
                string query = "SELECT * FROM dbo.uczen WHERE PESEL=" + peselint.ToString();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                try {
                    int x = (int)reader["PESEL"];
                    _test.Content = x.ToString();

                }
                catch
                {
                    _test.Content = "nie ma użytkownika z podanym peselem";
                    return;
                }
                string y = (string)reader["haslo"];
                if (y == haslo)
                {
                    string j = (string)reader["imie"];
                    string g = (string)reader["nazwisko"];
                    _test.Content = "Witaj "+j+" "+ g;
                }
                else
                {
                    _test.Content = "zle haslo";
                }


            }

        }
    }
}
