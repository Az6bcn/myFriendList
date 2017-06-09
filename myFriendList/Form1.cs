using System;
using System.Windows.Forms;
using System.Drawing;

namespace myFriendList
{
    public partial class myFriendList : Form
    {
        public string nom;
        public myFriendList()
        {
            InitializeComponent();
        }

        private void myFriendList_Load(object sender, EventArgs e)
        {
            // Set the ImageLocation property to a file on the disk.
            // ... Set the size mode so that the image is correctly sized.
            pictureBox.ImageLocation = @"c:\users\azeez olusegun\documents\visual studio 2015\Projects\myFriendList\myFriendList\images\friends.jpg";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Enterbutton_Click(object sender, EventArgs e)
        {
            if (nomtextBox.Text.ToString() == "")
            {
                MessageBox.Show("Please, Enter your name");
            }
            else
            {
                //hide first form when this button is clicked
                this.Hide();
                //get username
                nom = nomtextBox.Text;
                //instantiate new for (form2--->Mainpage)
                //form2 f2 = new form2(); form2--> Mainpage
                MainForm2 f2 = new MainForm2();
                //assign the user name to the username attribute in form 2
                f2.username = nom;
                //open new form 
                f2.ShowDialog();
            }
            
        }
    }
}
