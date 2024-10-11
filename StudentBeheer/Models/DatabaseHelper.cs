using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace StudentBeheer.Models
{
    internal class DatabaseHelper
    {

        private const string databaseFileName = "studenten.db";
        private const string connectionString = "Data Source=studenten.db;Version=3;";

        // Initialiseer de database door deze te maken als die niet bestaat en de Student-tabel aan te maken
        public static void InitializeDatabase()
        {
            // Controleer of het databasebestand al bestaat
            if (!File.Exists(databaseFileName))
            {
                // Maak de database aan door verbinding te maken (SQLite maakt het bestand automatisch)
                SQLiteConnection.CreateFile(databaseFileName);
            }

            // Open verbinding en creëer de tabel als deze nog niet bestaat
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Student (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Age INTEGER NOT NULL,
                StudentClass TEXT NOT NULL,
                StudentNumber Text NOT NULL
            );";

                SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                command.ExecuteNonQuery();
            }
        }

        public static void AddStudent(string name, int age, string studentclass, string studentnumber)
        {
            // add student to database
        }

        public static List<Student> GetStudents()
        {
            // get students from database
            //....
            // dummy data, verwijder deze regels en gebruik de database als je de echte data wilt gebruiken
            var list = new List<Student>();
            list.Add(new Student("John Doe", 18, "1A", "123456"));
            list.Add(new Student("Jane Doe", 17, "1B", "123457"));
            return list;
            
        }

        public static Student GetStudentById(int id)
        {
            // get student from database
            return new Student("John Doe", 18, "1A", "123456"); // dummy data
        }   

        public static void DeleteStudent(Student student)
        {
            // delete student from database
        }

        public static void UpdateStudent(Student student)
        {
            // update student in database
        }
    }
}
