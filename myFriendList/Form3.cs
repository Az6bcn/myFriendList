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
    public partial class OptionsForm : Form
    {
        //ADO Objects
        SqlConnection con;
        public SqlDataAdapter adapter;
        public DataSet dataset;

        //Attributes to edit
        private string firstname;
        private string lastname;
        private string email;
        private string address;
        private string hobbies;


        //get the id  of the selected Row through int id
        private int rowId;
        private string aaa;
        
        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Hobbies
        {
            get
            {
                return hobbies;
            }

            set
            {
                hobbies = value;
            }
        }

        public OptionsForm(int id)
        
        {
            
            rowId = id;
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
                //Yes/No dialog to confirm Edit action 
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit row with id " + rowId, "Edit " + rowId, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //hide former options form
                //this.Hide();
                //Shoe the editGroupBox
                editGroupBox.Show();
                //populate the selected Row's data in the editGroupBox Textboxes for edition
                firstnameTextBox.Text = Firstname;
                lastnameTextBox.Text = Lastname;
                emailTextBox.Text = Email;
                addressTextBox.Text = Address;
                hobbiesTextBox.Text = hobbies;

                 
            }
            else if (dialogResult == DialogResult.No)
            {
                //close former Options form and the dialogForm
                this.Hide();
                this.Close();
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            //hide editGroupBox
            editGroupBox.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            //Yes/No dialog to confirm Delete action 
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete row with id " + rowId, "Delete " + rowId, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            //hide former options form
                this.Hide();
                //search the row with the id in the dataset and delete it

                //connect to the DB
                connect(); //---> we now have the data in the dataset, access it 
                //count the row we have in our dataset (dataTable)..... count-1 xq empieza en zero
                int numRowCount = dataset.Tables["Friends"].Rows.Count;

                //itereate the rows to find the one with the id of the selected and delete it
                for (int i = 0; i < numRowCount; i++)
                {
                    //define Row (fila) to use iterate the Rows[i] 
                    DataRow fila;
                    fila = dataset.Tables["Friends"].Rows[i];
                    //Check if the "id" column of each row (fila) is == id
                    if (Convert.ToInt32(fila["id"]) == rowId)
                    {
                        //row found
                        //delete row
                        fila.Delete();
                        //actualise dataset dataTable ---> adapter Update()
                        adapter.Update(dataset, "Friends");
                            //refresh list View
                            MainForm2 f2 = new MainForm2();
                            
                         MessageBox.Show("Friend data Deleted!, refreshed");
                            f2.refreshdata();
                        }
                }
                 

            }
            else if (dialogResult == DialogResult.No)
            {
            //close former Options form and the dialogForm
                this.Hide();
                this.Close();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void connect()
        {
            
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
            dataset = new DataSet();
            //fill the dataset with adapter's data and give a name for your table
            adapter.Fill(dataset, "Friends");
            //close connection
            con.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Unblock the Update button
            UpdateButton.Enabled = true;
            //get the updated datas and send to database 
                       
            //connect to the DB
            connect(); //---> we now have the data in the dataset, access it 
                       //count the row we have in our dataset (dataTable)
            int numRowCount = dataset.Tables["Friends"].Rows.Count;

            //itereate the rows to find the one with the id of the selected and delete it
            for (int i = 0; i < numRowCount; i++)
            {
                //define a new Row (fila)  instance
                DataRow fila;
                fila = dataset.Tables["Friends"].Rows[i];
                //Check if the "id" column of each row (fila) is == id
                try
                {

                
                if (Convert.ToInt32(fila["id"]) == rowId)
                {
                    //row found
                    //Update ny replacing each of the Colunms Row's data
                    fila["firstName"] = firstnameTextBox.Text.ToString();
                    fila["lastName"] =  lastnameTextBox.Text.ToString();
                    fila["email"] =  emailTextBox.Text.ToString();
                    fila["address"] =  addressTextBox.Text.ToString();
                    fila["hobbies"] =  hobbiesTextBox.Text.ToString();
                    //actualise dataset dataTable ---> adapter Update()
                    adapter.Update(dataset, "Friends");

                        MessageBox.Show("Friend data Updated!, refresh the list view");

                        //clear textbox
                        firstnameTextBox.Text = "";
                        lastnameTextBox.Text = "";
                        emailTextBox.Text = "";
                        addressTextBox.Text = "";
                        hobbiesTextBox.Text = "";

                        //block the Update button
                        UpdateButton.Enabled = false;
                    }
                }
                catch (Exception ex )
                {

                    MessageBox.Show(ex.Message);
                }
            }


        }
    }
}
