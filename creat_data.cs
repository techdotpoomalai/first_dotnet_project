public void Creat_data()
{
    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
    string query = "INSERT INTO user('Company Name', 'CEO Name', 'Yearly Income') VALUES ('"+textBox0.Text+ "', '" + textBox1.Text + "', '" + textBox2.Text + "')";
    // Which could be translated manually to :
    // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')
    
    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
    commandDatabase.CommandTimeout = 60;
    
    try
    {
        databaseConnection.Open();
        MySqlDataReader myReader = commandDatabase.ExecuteReader();
        
        MessageBox.Show("Creat data succesfully ");
   
        databaseConnection.Close();
    }
    catch (Exception ex)
    {
        // Show any error message.
        MessageBox.Show(ex.Message);
    }
}