using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myFriendList
{
    //we make Person inherit connect so we can access it in th friend class(child for Person)
    class Person : Connect
    {
        private string firstName;
        private string lastName;
        private string email;

        //get and set ---> Encapsulate
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
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

        //we would override this clase to add friend in friend class
        public virtual void add()
        {

        }

    }
}
