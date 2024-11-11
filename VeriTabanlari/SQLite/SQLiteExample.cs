using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace YazilimNetFrameworkOrnekler.VeriTabanlari.SQLite
{
    internal class SQLiteExample
    {
        private string databaseName = "ExampleSQLiteDatabase.sqlite";
        private string connectionString;

        internal SQLiteExample()
        {
            connectionString = $"Data Source={databaseName};Version=3;";
            CreateDatabase();
        }


        private void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(databaseName);
                Console.WriteLine("Veri Tabanı Başarı ile Oluşturuldu.");
            } catch (Exception e)
            {
                Console.WriteLine("Veri Tabanı Oluşturulamadı!");
                Console.WriteLine(e.Message);
                Console.WriteLine("Veri Tabanı Oluşturulamadı!");
            }
        }


        internal void CheckConnectionDatabase()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                Console.WriteLine("SQLite veritabanına başarıyla bağlanıldı.");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Veri Tabanı Bağlantısı Kurulamadı!");
                Console.WriteLine(e.Message);
                Console.WriteLine("Veri Tabanı Bağlantısı Kurulamadı!");
            }
        }

        internal void CreateTable()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = "CREATE TABLE IF NOT EXISTS Accounts (Id INTEGER PRIMARY KEY, Username TEXT, Name TEXT, Surname TEXT, Password TEXT)";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();

                        Console.WriteLine("Tablo Başarıyla Oluşturuldu.");
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Tablo Oluşturulamadı!");
                Console.WriteLine(e.Message);
                Console.WriteLine("Tablo Oluşturulamadı!");
            }
        }

        internal void CreateAccount(string username, string name, string surname, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Accounts (Username, Name, Surname, Password) VALUES (@username, @name, @surname, @password)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();

                        Console.WriteLine("Kullanıcı Başarıyla Eklendi.");
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Hesap Oluşturulamadı!");
                Console.WriteLine(e.Message);
                Console.WriteLine("Hesap Oluşturulamadı!");
            }
        }
          
    }
}
