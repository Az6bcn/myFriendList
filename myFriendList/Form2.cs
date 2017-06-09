using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import ADO.NET providers
using System.Data.SqlClient;

namespace myFriendList
{
    public partial class MainForm2 : Form
    {
        //ADO Objects
        SqlConnection con;
        public SqlDataAdapter adapter;
        public DataSet datasetTable;
        public DataSet data;
        public string username;
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            //when form loads get and show username in the UsernameLabel
            UsernameLabel.Text = "Welcome " + username;

            //hide the ADDGroupBox  and friendListdataGridView
            AddFriendGroupBox.Hide();
            friendListdataGridView.Hide();

            //*********** setDataGridView SelectionMode --> FullMode in other to get 
            //the complete dataGridView Rwwhen the user clicks a cell of that Row

            friendListdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show grupBox of labels and textboxes to Add friend
            //unhide the ADDGroupBox 
            AddFriendGroupBox.Show();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            //pop up form about the application 
            About aboutform = new About();
            aboutform.ShowDialog();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //if any camp is null ---don¡t allow 
            if ((firstNameTextBox.Text == "") || (lastNameTextBox.Text == "")
             || (emailTextBox.Text == "") || (addressTtextBox.Text == "")
            ||  (hobbiesTextBox.Text == ""))
            {
                MessageBox.Show("You have to complete all the Camps");

            }
            else { 
            try
            {
                //instantiate the friend class
                Friend newfrnd = new Friend();
            //retrive the friend details assign to friends attribute and send to BD
            newfrnd.FirstName = firstNameTextBox.Text;
            newfrnd.LastName = lastNameTextBox.Text;
            newfrnd.Email = emailTextBox.Text;
            newfrnd.Address = addressTtextBox.Text;
            newfrnd.Hobbies = hobbiesTextBox.Text;

            //call method to send to BD
            newfrnd.add();
            ////hide the ADDGroupBox 
            //AddFriendGroupBox.Hide();
                    //clear textBoxes
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    emailTextBox.Text = "";
                    addressTtextBox.Text = "";
                    hobbiesTextBox.Text = "";

                }
            catch (Exception ex)
            {
                //show exception in the StatusLabel
                statusLabel.Text = ex.Message;
            }

            //show added if now error in statusLabel
            statusLabel.Text = "User Added to data base";
            //refresh dataBase
            refreshdata();
            }
        }

        private void friendListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            refreshdata();
        }

        public void refreshdata()
        {
            //SqlConnection con = new SqlConnection(@"Data Source =  AZEEZOLUSEGUN; Database= myAgenda; integrated Security = true");
            //SqlCommand cmd = new SqlCommand("select * from Friends", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable ds = new DataTable();
            //sda.Fill(ds);
            //friendListdataGridView.DataSource = ds;

            //instatiate con object
            con = new SqlConnection();
            //pass connectionstring to our con
            con.ConnectionString = "Data Source =  AZEEZOLUSEGUN; Database= myAgenda; integrated Security = true";
            //open connection
            con.Open();
            //get all our database using dataAdapter
            string query = "Select * from Friends";
            //SqlCommand cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(adapter);
            //put the retrieved data by the adapter in the dataset
            //DataTable data = new DataTable();
            datasetTable = new DataSet();
            //fill the dataset with adapter's data and give a name for your table
            adapter.Fill(datasetTable, "Friends");
            //populate data in DataGrid View and indicate the table you want to show among the tables in the dataset
            friendListdataGridView.DataSource = datasetTable.Tables["Friends"];// ó --->datasetTable.Tables[0];
            //friendListdataGridView.DataBind(); ---> DataBind only needed in webForms

            friendListdataGridView.Show();

            //close connection
            con.Close();
        }

        private void friendListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*********** setDataGridView SelectionMode --> FullMode in other to get 
            //the complete dataGridView Rwwhen the user clicks a cell of that Row

            //get selected dataGridView role data
       
            if (friendListdataGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow fila = this.friendListdataGridView.SelectedRows[0];
                //get the ID of the selected row
                int rowId =  Convert.ToInt32(fila.Cells["id"].Value.ToString());
                //get the data column of the selected row
                string firstname = fila.Cells["firstName"].Value.ToString();
                string lastname = fila.Cells["lastName"].Value.ToString();
                string email = fila.Cells["email"].Value.ToString();
                string address = fila.Cells["address"].Value.ToString();
                string hobbies= fila.Cells["hobbies"].Value.ToString();
                //MessageBox.Show(fila.Cells["id"].Value.ToString());
                //call the Options form
                optionForm(rowId, firstname, lastname, email, address, hobbies);
            }
        }

        public void optionForm(int id, string a, string b, string c, string d, string e)
        {
            
            //ask if wants to change/delete/cancel ---> load edit_del_cancel FORM
            OptionsForm opfm = new OptionsForm(id);
            //set the attributes for editing
            opfm.Firstname = a;
            opfm.Lastname = b;
            opfm.Email = c;
            opfm.Address = d;
            opfm.Hobbies =e;
            opfm.Show();

        }
    }
}
