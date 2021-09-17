using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

public class Database
{
    private readonly SQLiteConnection Connection;
    private SQLiteTransaction Transaction;

    public Database()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        Connection = new SQLiteConnection("Data Source=" + currentDirectory + "/database/sqlite.db");
        Connection.Open();
    }


    public void BeginTransaction()
    {
        Transaction = Connection.BeginTransaction();
    }
    
    
    public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
    {
        if (string.IsNullOrEmpty(query.Trim()))
            return new DataTable();
        
        var data = new DataTable();
        using (var statement = new SQLiteCommand(query, Connection))
        {
            foreach (var (field, value) in parameters)
            {
                statement.Parameters.AddWithValue(field, value);
            }
            
            using (var adapter = new SQLiteDataAdapter(statement))
            {
                adapter.Fill(data);
            }
        }
        return data;
    }


    public void Commit()
    {
        Transaction.Commit();
        Connection.Close();
    }
    
    
    public void Rollback()
    {
        Transaction.Rollback();
        Connection.Close();
    }
}