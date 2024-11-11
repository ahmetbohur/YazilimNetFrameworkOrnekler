using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimNetFrameworkOrnekler.Ornekler;
using YazilimNetFrameworkOrnekler.VeriTabanlari.SQLite;

namespace YazilimNetFrameworkOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SQLiteExample sQLiteExample = new SQLiteExample();
            sQLiteExample.CheckConnectionDatabase();
            sQLiteExample.CreateTable();
            sQLiteExample.CreateAccount("Urhoba", "Ahmet", "Bohur", "123Password123321");
            sQLiteExample.CreateAccount("Urhobaa", "Eren", "Bohur", "32123123asdasd");
            Console.ReadLine();
        }

    }
}
