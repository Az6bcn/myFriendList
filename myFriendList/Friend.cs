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
    //inherits Person's attribute and also as its own
    class Friend : Person
    {
        private string address;
        private string hobbies;

        //get and set ---> Encapsulate
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

        //override add method in parent class
        public override void add()
        {
            base.add();
            //connect to DB
            connectDB();
            //to add new friend--> means we want to create a new Row in the BD
            //row object 
            DataRow fila;
            //create new fila(row) in the dataTable inside our dataset
            fila = dataset.Tables[0].NewRow();
            //use the column heading to add data into each column of the new ROW
            //firstName lastName emaill---- > Colunm heading
            //    x       x2 x3   ----------------------> Row value for each Column heading


            //Row[Column] = value =====> Row[firstName] = x
            fila["firstName"] = FirstName;
            fila["lastName"] = LastName;
            fila["email"] = Email;
            fila["address"] = Address;
            fila["hobbies"] = Hobbies;
            //now add this as a new Row to our dataset dataTable
            dataset.Tables["Friends"].Rows.Add(fila);
            //actualize the dataset Data to the DB using the DataAdapter UPDATE();
            adapter.Update(dataset, "Friends");
        }

      
    }
}
