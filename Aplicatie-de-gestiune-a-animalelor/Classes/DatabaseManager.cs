using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
namespace Aplicatie_de_gestiune_a_animalelor.Classes
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;
        public string dataBaseFile = "animalsDB";
        string conString;

        public static DatabaseManager GetInstance()
        {
            if (instance == null)
                instance = new DatabaseManager();
            return instance;
        }
        /// <summary>
        /// Initialize DB file and tables
        /// </summary>
        private DatabaseManager()
        {
            //DeleteDatabase(); //REMOVE LATER!!!!!!!!!!!!!
            CreateDatabase(dataBaseFile);
            conString = GetConnectionString(dataBaseFile);
            string queryAnimals = "CREATE TABLE Animale ( IDAnimal INTEGER PRIMARY KEY AUTOINCREMENT, Specie TEXT, Rasa TEXT, Nume TEXT, Varsta INTEGER, Sex TEXT, Greutate REAL, Vaccinat TEXT, Sterilizat TEXT, PathPoza TEXT);";
            string queryAppointments = "CREATE TABLE Programari (IDProgramare INTEGER PRIMARY KEY AUTOINCREMENT, IDAnimal INTEGER, DataProgramarii DATETIME, Detalii TEXT, FOREIGN KEY (IDAnimal) REFERENCES Animale(IDAnimal) ON DELETE CASCADE);";
            string querySupplier = "CREATE TABLE Furnizori (IDFurnizor INTEGER PRIMARY KEY AUTOINCREMENT, NumeFurnizor TEXT, CUI TEXT, Adresa TEXT, NumarTelefon TEXT, Email TEXT)";
            string queryOrders = "CREATE TABLE Comenzi (IDComanda INTEGER PRIMARY KEY AUTOINCREMENT, NumarComanda TEXT, Produse TEXT, ValoareCuTVA REAL, FOREIGN KEY (IDFurnizor) REFERENCES Furnizori(IDFurnizor)";
            string queryInvoices = "CREATE TABLE Facturi (IDFactura INTEGER PRIMARY KEY AUTOINCREMENT, NumarFactura TEXT, FOREIGN KEY (IDComanda) REFERENCES Comenzi(IDComanda), FOREIGN KEY (IDFurnizor) REFERENCES Furnizori(IDFurnizor))";
            
            using (SQLiteConnection con = new SQLiteConnection(conString))
            using (SQLiteCommand command = new SQLiteCommand(queryAnimals, con))
            using (SQLiteCommand appointmentsCommand = new SQLiteCommand(queryAppointments, con))
            using (SQLiteCommand supplierCommand = new SQLiteCommand(querySupplier, con))
            using (SQLiteCommand ordersCommand = new SQLiteCommand(queryOrders, con))
            using (SQLiteCommand invoicesCommand = new SQLiteCommand(queryInvoices, con))
            {
                con.Open();
                if (!CheckForTable("Animale", con))
                    command.ExecuteNonQuery();
                if (!CheckForTable("Programari", con))
                    appointmentsCommand.ExecuteNonQuery();
                if (!CheckForTable("Furnizori", con))
                    supplierCommand.ExecuteNonQuery();
                if (!CheckForTable("Comenzi", con))
                    ordersCommand.ExecuteNonQuery();
                if (!CheckForTable("Facturi", con))
                    invoicesCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Checks if table exists in DB
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        public bool CheckForTable(string tableName, SQLiteConnection con)
        {
            string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            object result = cmd.ExecuteScalar();
            if (result != null && result.ToString() == tableName)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Creates DB file if it doesn't exist
        /// </summary>
        /// <param name="db"></param>
        public void CreateDatabase(string db)
        {
            Debug.WriteLine(Directory.GetCurrentDirectory());
            if (!File.Exists(db))
            {
                Debug.WriteLine($"Created database: {db}");
                SQLiteConnection.CreateFile(db);
            }
        }
        /// <summary>
        /// Gets string for creating connection with SQLiteConnection
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public string GetConnectionString(string db)
        {
            string con;
            return con = "Data Source=" + db + ";Version=3;";
        }
        /// <summary>
        /// Gets SQLiteConnection type object
        /// </summary>
        /// <returns></returns>
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(conString);
            return connection;
        }

        public void DeleteDatabase()
        {
            try
            {
                if (File.Exists(dataBaseFile))
                {
                    File.Delete(dataBaseFile);
                }
            }
            catch (Exception)
            {
                //doesn't exist
            }
        }
    }
}
