using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//import ADO.NET providers
using System.Data;
using System.Data.SqlClient;

namespace myFriendList
{
   
    class Connect
    {
        //ADO Objects
        SqlConnection con;
       public SqlDataAdapter adapter;
       public DataSet dataset;

        public void connectDB()
        {
            //instatiate con object
            con = new SqlConnection();
            //pass connectionstring to our con
            con.ConnectionString = "Data Source =  AZEEZOLUSEGUN; Database= myAgenda; integrated Security = true";
            //open connection
            con.Open();
            //get all our database using dataAdapter
            string query = "Select * from Friends";
            adapter = new SqlDataAdapter(query, con);
            //SqlCommand Builder --> executes all the command that Dataadapter accepts, in our case we passing it the adapter with the SelectCommand: 
            //SelectCommand, InsertCommand, DeleteCommand and UpdateCommand
            SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(adapter);
            //*****dataset[dataTable] -->dataTable[DataRow n dataColumn] ****
            //put the retrieved data by the adapter in the dataset
            dataset = new DataSet();
            //fill the dataset with adapter datas
            adapter.Fill(dataset, "Friends");
            //close connection
            con.Close();

        }

    }

    
}
