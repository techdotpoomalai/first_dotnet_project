using MySql.Data.MySqlClient;

// Change the username, password and database according to your needs
// You can ignore the database option if you want to access all of them.
// 127.0.0.1 stands for localhost and the default port to connect.
string connet_String = "datasource=127.0.0.1;port=3306;username=root;password=;database=dotnet data;";   // Your query,
string query = "SELECT * FROM company datas";
// Prepare the connection
MySqlConnection databaseConnection = new MySqlConnection(connet_String);
MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
commandDatabase.CommandTimeout = 60;
MySqlDataReader reader;
 
// Let's do it !
try
    {
        databaseConnection.Open();  // Open the database
        reader = commandDatabase.ExecuteReader();   // Execute the query
        // All succesfully executed, now do something

        // IMPORTANT : 
        // If your query returns result, use the following processor :    
        if (reader.HasRows)
            {
                while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    }
            }
        else
            {
                Console.WriteLine("No rows found.");
            }
            databaseConnection.Close();     // Finally close the connection
    }
catch (Exception ex)
    {
        MessageBox.Show(ex.Message);    // Show any error message.
    }