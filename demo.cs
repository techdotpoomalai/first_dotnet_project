private void listUsers()
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";    // Select all
        string query = "SELECT * FROM user";

        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        MySqlDataReader reader;

        try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();        // Success, now list 

                // If there are available rows
                if (reader.HasRows)
                    {
                        while (reader.Read())
                            {
                                            ID                              First name                  Last Name                    Address
                                Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                                // Example to save in the listView1 :
                                //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                                //var listViewItem = new ListViewItem(row);
                                //listView1.Items.Add(listViewItem);
                            }
                    }
                else
                    {   
                        Console.WriteLine("No rows found.");
                    }
                databaseConnection.Close();
            }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }