using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Insert : MonoBehaviour
{
    
    string conn, sqlQuery;
    IDbCommand dbcmd;
    IDbConnection dbconn;
    void Start()
    {
       conn = "URI=file:" + Application.dataPath + "/Pluggins/Users.s3db";
        InsertValue();
        //UpdateValues();
        // DeleteValue(4);
         readers();
        Debug.Log("sss");
    }

    private void InsertValue()
    {
        using(dbconn=new SqliteConnection(conn))
        {
            dbconn.Open();
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("insert into UsersInfo( Name, Email) values('yaaas', 'daa@yahoo.com')");
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }

    private void UpdateValues()
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open();
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("UPDATE UsersInfo SET Name='daa', Email='daa@yahoo.com' WHERE Id=3");
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }

    private void DeleteValue(int id)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open();
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("DELETE FROM UsersInfo WHERE Id=\"{0}\"",id);
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }

    private void readers()
    {

        
        //IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open();//Open connection to the database
        dbcmd = dbconn.CreateCommand();
        sqlQuery = "SELECT * " + "FROM UsersInfo";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            string Email = reader.GetString(2);

            Debug.Log("value= " + id + "name= " + name + "Email= " + Email);
        }

        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;  
    }
}
