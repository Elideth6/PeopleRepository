using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using People.Models;


namespace People.Models
{
    public class PersonRepositoryCRUD
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PersonRepositoryCRUD(string dbPath)
        {
            //Creamos la conexión.
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();

        }
        public void CreatePerson(Person newPerson)
        {


            int result;
            result = conn.Insert(newPerson);
            if (result == 1)
            {
                StatusMessage =
                    $"{result} registro agregado [Nombre:" +
                    $"{newPerson.Name}, ID: {newPerson.Id}";
                //"1 registro agregado [Nombre: Juan, ID:1]
            }
            else
            {
                StatusMessage =
                    "¡Registro no insertado!";
            }
        }

        public List<Person> GetAllPeople()
        {
            return conn.Table<Person>().ToList();
        }
    }
}

    
        

 

