using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFriendList
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            //load text to the texbox about the Application

            label.Text = @"This Application is just a mini FRIENDLIST program to manage 
                           your friend list. You can ADD, EDIT, UPDATE AND DELETE";
        }
    }
}
