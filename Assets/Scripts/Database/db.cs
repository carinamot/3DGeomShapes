﻿using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class db : MonoBehaviour
{

    private void Start()
    {
        string conn = "URI=file:" + Application.dataPath + "/Pluggins/Users.s3db";//Path to database
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open();//Open connection to the database
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * " + "FROM UsersInfo";
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
