using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creating an SQL Connection.
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            // Setup our SQL String
            string connectionString = ConfigurationManager.ConnectionStrings["WPF_ZooManager.Properties.Settings.CSharpTutorialsDBConnectionString"].ConnectionString;
            
            // Initializing SQL Connection
            sqlConnection = new SqlConnection(connectionString);

            // This method will show all the zoos in our listbox.
            ShowZoos();
            ShowAnimals();
        }

        /// <summary>
        /// This method will show all the zoos in the "ZooList" ListBox
        /// </summary>
        private void ShowZoos()
        {
            try
            {
                string query = "SELECT * FROM ZOO";
                // This SQL Data adapter will run our query into our sqlConnection which is connecting to our database.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                // Using our sqlDataAdapter
                using (sqlDataAdapter)
                {
                    // We want to create a data table for the zoos.
                    DataTable zooTable = new DataTable();

                    // Fill method fills the zoo table with the data returned from the query.
                    sqlDataAdapter.Fill(zooTable);

                    // Using our "zooList" ListBox
                    // Which information of the Table in the DataTable should be shown in our ListBox.
                    ZooList.DisplayMemberPath = "Location";
                    // Which value should be delivered when an Item from our ListBox is selected.
                    ZooList.SelectedValuePath = "Id";
                    // The reference to the Data the ListBox should populate.
                    ZooList.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                //MessageBox.Show("Something happened while Showing Zoos");
            }
        }

        /// <summary>
        /// Shows associated animals whenever a zoo is clicked in the "ZooList" Listbox
        /// </summary>
        private void ShowAssociatedAnimals()
        {
            try
            {
                //MessageBox.Show("ZooID: " + ZooList.SelectedValue.ToString());
                string query = "SELECT * FROM Animal a INNER JOIN ZooAnimal za on a.Id = za.AnimalId WHERE za.ZooId = @ZooId";


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // This SQL Data adapter will run our query into our sqlConnection which is connecting to our database.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Using our sqlDataAdapter
                using (sqlDataAdapter)
                {
                    // Adding the ZooId as a parameter in the sql command and assigning the Id of the
                    // Selected value in the ListBox.
                    sqlCommand.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);

                    

                    // We want to create a data table for the animals in specific zoos.
                    DataTable associatedAnimalTable = new DataTable();

                    // Fill method fills the zoo table with the data returned from the query.
                    sqlDataAdapter.Fill(associatedAnimalTable);

                    // Using our "zooList" ListBox
                    // Which information of the Table in the DataTable should be shown in our ListBox.
                    Zoo_AnimalList.DisplayMemberPath = "Name";
                    // Which value should be delivered when an Item from our ListBox is selected.
                    Zoo_AnimalList.SelectedValuePath = "Id";
                    // The reference to the Data the ListBox should populate.
                    Zoo_AnimalList.ItemsSource = associatedAnimalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                //MessageBox.Show("Something happened while Showing Associated Animals");
            }
        }

        /// <summary>
        /// Shows all animals in the "AnimalList" ListBox
        /// </summary>
        private void ShowAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                // Using our sqlDataAdapter
                using (sqlDataAdapter)
                {
                    // We want to create a data table for the zoos.
                    DataTable animalTable = new DataTable();

                    // Fill method fills the zoo table with the data returned from the query.
                    sqlDataAdapter.Fill(animalTable);

                    // Using our "zooList" ListBox
                    // Which information of the Table in the DataTable should be shown in our ListBox.
                    AnimalList.DisplayMemberPath = "Name";
                    // Which value should be delivered when an Item from our ListBox is selected.
                    AnimalList.SelectedValuePath = "Id";
                    // The reference to the Data the ListBox should populate.
                    AnimalList.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                //MessageBox.Show("Something happened while Showing Animals");
            }
        }

        /// <summary>
        /// Whenever we click on a ZooList item, this method is executed.
        /// It executes the ShowAssociatedAnimals Method to Populate the Associated animals ListBox.
        /// It also executes the ShowSelectedZooInTextBox method to populate the InputTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void ZooList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }

        /// <summary>
        /// Method runs when Delete Zoo Btn is clicked. This method deletes the specified Zoo from the Zoo ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Delete query
                string query = "DELETE FROM Zoo WHERE id = @ZooId";

                // Creating SQL Command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // Open SQL Connection
                sqlConnection.Open();
                // Add the Parameters @ZooId for the query.
                sqlCommand.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                // Executes query and returns first row in the result set returned by the query.
                sqlCommand.ExecuteScalar();
                

                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something happened in the DeleteZoo Click");
            } finally
            {
                // Once the zoo is deleted, modify the Zoo ListBox by showing zoos again.
                ShowZoos();
                // Also Clear Associated Animals, Which should show an empty Associated Animals ListBox.
                DataTable associatedAnimalTable = new DataTable();
                Zoo_AnimalList.ItemsSource = associatedAnimalTable.DefaultView;

                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Add Zoo Btn is clicked. Adds the Specified Zoo into the Zoo ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (InputTxtBox.Text == "")
                {
                    MessageBox.Show("Zoo Location cannot be Empty. Please enter a Zoo and try again.");
                }
                else
                {
                    // Insert query. Inserting new Zoo Location into the Zoo ListBox
                    string query = "INSERT INTO Zoo VALUES (@Location)";

                    // Creating SQL Command
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    // Open SQL Connection
                    sqlConnection.Open();
                    // Add the Parameters @Location for the query.
                    sqlCommand.Parameters.AddWithValue("@Location", InputTxtBox.Text);
                    // Executes query and returns first row in the result set returned by the query.
                    sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something happened in the AddZoo Click");
            }
            finally
            {
                // Once the zoo is added, modify the Zoo ListBox by showing zoos again.
                ShowZoos();
                // Delete textBox Text once the Zoo is added.
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Update Zoo Btn is clicked. Updates the Specified Zoo in the Zoo ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (InputTxtBox.Text == "")
                {
                    MessageBox.Show("Zoo Location cannot be Empty. Please enter a Zoo and try again.");
                }
                else
                {
                    // Update query. Updating Zoo Location with new Location in the Zoo ListBox
                    string query = "UPDATE Zoo SET Location = (@Location) WHERE Id = @ZooId";

                    // Creating SQL Command
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    // Open SQL Connection
                    sqlConnection.Open();
                    // Add the Parameters @Location for the query.
                    sqlCommand.Parameters.AddWithValue("@Location", InputTxtBox.Text);
                    // Add the Parameters @ZooId for the query.
                    sqlCommand.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                    // Executes query and returns first row in the result set returned by the query.
                    sqlCommand.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something happened in the AddZoo Click");
            }
            finally
            {
                // Once the zoo is updated, modify the Zoo ListBox by showing zoos again.
                ShowZoos();
                // Delete textBox Text once the Zoo is added.
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Add Animal to Zoo Btn is clicked. Adds the Specified Animal Into the Specified Zoo and
        /// shows it in the Associated Animals ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAnimalFromZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Delete query. (Deleting Zoo Id and Animal Id from ZooAnimal join table and Associated Animal ListBox).
                string query = "DELETE FROM ZooAnimal WHERE ZooId = @ZooId AND AnimalId = @AnimalId";
                // Creating SQL Command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // Open SQL Connection
                sqlConnection.Open();
                // Add the Parameters @ZooId for the query.
                sqlCommand.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", Zoo_AnimalList.SelectedValue);
                // Executes query and returns first row in the result set returned by the query.
                sqlCommand.ExecuteScalar();


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Show Associated Animals
                ShowAssociatedAnimals();
                // Delete textBox Text once the Zoo is added.
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Add Zoo Btn is clicked. Adds the Specified Zoo into the Zoo ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(InputTxtBox.Text == "")
                {
                    MessageBox.Show("Animal Name cannot be Empty. Please enter an Animal and try again.");
                } else
                {
                    // Insert query. Inserting new Animal into the Animal ListBox
                    string query = "INSERT INTO Animal VALUES (@Name)";

                    // Creating SQL Command
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    // Open SQL Connection
                    sqlConnection.Open();
                    // Add the Parameters @Name for the query.
                    sqlCommand.Parameters.AddWithValue("@Name", InputTxtBox.Text);
                    // Executes query and returns first row in the result set returned by the query.
                    sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something happened in the AddZoo Click");
            }
            finally
            {
                // Once the Animal is added, modify the Animal ListBox by showing Animals again.
                ShowAnimals();
                // Delete textBox Text once the Zoo is added.
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Update Zoo Btn is clicked. Updates the Specified Zoo in the Zoo ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (InputTxtBox.Text == "")
                {
                    MessageBox.Show("Animal Name cannot be Empty. Please select the animal you want to update and try again.");
                }
                else
                {
                    // Update query. Updating Zoo Location with new Location in the Zoo ListBox
                    string query = "UPDATE Animal SET Name = (@Name) WHERE Id = @Id";

                    // Creating SQL Command
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    // Open SQL Connection
                    sqlConnection.Open();
                    // Add the Parameters @Name for the query.
                    sqlCommand.Parameters.AddWithValue("@Name", InputTxtBox.Text);
                    // Add the Parameters @Id for the query.
                    sqlCommand.Parameters.AddWithValue("@Id", AnimalList.SelectedValue);
                    // Executes query and returns first row in the result set returned by the query.
                    sqlCommand.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something happened in the AddZoo Click");
            }
            finally
            {
                // Once the Animal is updated, modify the Animal ListBox by showing Animals again.
                ShowAnimals();
                // Clear InputTxtBox Text once the Animal is Updated.
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Add Animal to Zoo Btn is clicked. Adds the Specified Animal Into the Specified Zoo and
        /// shows it in the Associated Animals ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Insert query. (Inserting Zoo Id and Animal Id to ZooAnimal join table and Associated Animal ListBox).
                string query = "INSERT INTO ZooAnimal VALUES (@ZooId, @AnimalId)";
                // Creating SQL Command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // Open SQL Connection
                sqlConnection.Open();
                // Add the Parameters @ZooId for the query.
                sqlCommand.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                // Add the Parameters @AnimalId for the query.
                sqlCommand.Parameters.AddWithValue("@AnimalId", AnimalList.SelectedValue);
                // Executes query and returns first row in the result set returned by the query.
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Show Associated Animals
                ShowAssociatedAnimals();
                // Delete InputTxtBox Text once the Zoo is added.
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method runs when Delete Zoo Btn is clicked. This method deletes the specified Zoo from the Zoo ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Delete query.
                string query = "DELETE FROM Animal WHERE id = @AnimalId";

                // Creating SQL Command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // Open SQL Connection
                sqlConnection.Open();
                // Add the Parameters @ZooId for the query.
                sqlCommand.Parameters.AddWithValue("@AnimalId", AnimalList.SelectedValue);
                // Executes query and returns first row in the result set returned by the query.
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something happened in the DeleteZoo Click");
            }
            finally
            {
                // Once the Animal is deleted, modify the Animal ListBox by showing Animals again.
                ShowAnimals();
                ShowAssociatedAnimals();
                InputTxtBox.Text = "";
                // Close the sqlConnection.
                sqlConnection.Close();
            }
        }
        
        /// <summary>
        /// Populates InputTxtBox Text with selected Zoo
        /// </summary>
        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string query = "SELECT Location FROM Zoo WHERE Id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined as an interface to make Tables usable by C#-Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);

                    DataTable zooDataTable = new DataTable();

                    sqlDataAdapter.Fill(zooDataTable);

                    InputTxtBox.Text = zooDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.ToString());
            }

        }

        /// <summary>
        /// Populates InputTxtBox Text with selected Animal
        /// </summary>
        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string query = "SELECT Name FROM Animal WHERE Id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined as an interface to make Tables usable by C#-Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", AnimalList.SelectedValue);

                    DataTable zooDataTable = new DataTable();

                    sqlDataAdapter.Fill(zooDataTable);

                    InputTxtBox.Text = zooDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.ToString());
            }

        }

        /// <summary>
        /// Populates InputTxtBox Text with selected Animal
        /// </summary>
        private void ShowSelectedAssociatedAnimalInTextBox()
        {
            try
            {
                string query = "SELECT Name FROM Animal WHERE Id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined as an interface to make Tables usable by C#-Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", Zoo_AnimalList.SelectedValue);

                    DataTable zooDataTable = new DataTable();

                    sqlDataAdapter.Fill(zooDataTable);

                    InputTxtBox.Text = zooDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.ToString());
            }

        }
        /// <summary>
        /// Whenever we click on a Zoo_AnimalList item, this method is executed.
        /// It executes the ShowSelectedAssociatedAnimalInTextBox Method to Populate the Input TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zoo_AnimalList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAssociatedAnimalInTextBox();
        }

        /// <summary>
        /// Whenever we click on a AnimalList item, this method is executed.
        /// It executes the ShowSelectedAnimalInTextBox Method to Populate the Input TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimalList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
    }
}
