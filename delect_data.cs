public void delete_data()
{
    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dotnet data;";
    // Delete the item with ID 1
    string query = "DELETE FROM `user` WHERE Company Name= Company Name";

    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
    commandDatabase.CommandTimeout = 60;
    MySqlDataReader reader;

    try
    {
        databaseConnection.Open();
        reader = commandDatabase.ExecuteReader();
        
        // Succesfully deleted

        databaseConnection.Close();
    }
    catch (Exception ex)
    {
        // Ops, maybe the id doesn't exists ?
        MessageBox.Show(ex.Message);
    }
}