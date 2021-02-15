public void Update_data()
{
    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dotnet data;";
    // Update the properties of the row with ID 1
    string query = "UPDATE `user` SET `Company Name`='s pvt.ltd',`CEO Name`='Wonka',`Yearly Income`='10' WHERE Company Name = Company Name";

    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
    commandDatabase.CommandTimeout = 60;
    MySqlDataReader reader;

    try
    {
        databaseConnection.Open();
        reader = commandDatabase.ExecuteReader();
        
        // Succesfully updated

        databaseConnection.Close();
    }
    catch (Exception ex)
    {
        // Ops, maybe the id doesn't exists ?
        MessageBox.Show(ex.Message);
    }
}