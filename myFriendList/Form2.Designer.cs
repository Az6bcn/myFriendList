namespace myFriendList
{
    partial class MainForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFriendGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.hobbiesTextBox = new System.Windows.Forms.TextBox();
            this.addressTtextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.friendListdataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.AddFriendGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(786, 13);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.UsernameLabel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.addToolStripMenuItem,
            this.friendListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Menu";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // friendListToolStripMenuItem
            // 
            this.friendListToolStripMenuItem.Name = "friendListToolStripMenuItem";
            this.friendListToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.friendListToolStripMenuItem.Text = "Friend list";
            this.friendListToolStripMenuItem.Click += new System.EventHandler(this.friendListToolStripMenuItem_Click);
            // 
            // AddFriendGroupBox
            // 
            this.AddFriendGroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddFriendGroupBox.Controls.Add(this.statusLabel);
            this.AddFriendGroupBox.Controls.Add(this.addButton);
            this.AddFriendGroupBox.Controls.Add(this.hobbiesTextBox);
            this.AddFriendGroupBox.Controls.Add(this.addressTtextBox);
            this.AddFriendGroupBox.Controls.Add(this.emailTextBox);
            this.AddFriendGroupBox.Controls.Add(this.lastNameTextBox);
            this.AddFriendGroupBox.Controls.Add(this.firstNameTextBox);
            this.AddFriendGroupBox.Controls.Add(this.hobbiesLabel);
            this.AddFriendGroupBox.Controls.Add(this.addressLabel);
            this.AddFriendGroupBox.Controls.Add(this.emailLabel);
            this.AddFriendGroupBox.Controls.Add(this.lastNameLabel);
            this.AddFriendGroupBox.Controls.Add(this.firstNameLabel);
            this.AddFriendGroupBox.Location = new System.Drawing.Point(12, 44);
            this.AddFriendGroupBox.Name = "AddFriendGroupBox";
            this.AddFriendGroupBox.Size = new System.Drawing.Size(266, 265);
            this.AddFriendGroupBox.TabIndex = 2;
            this.AddFriendGroupBox.TabStop = false;
            this.AddFriendGroupBox.Text = "Add Friend";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(23, 215);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(150, 215);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // hobbiesTextBox
            // 
            this.hobbiesTextBox.Location = new System.Drawing.Point(137, 165);
            this.hobbiesTextBox.Name = "hobbiesTextBox";
            this.hobbiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.hobbiesTextBox.TabIndex = 9;
            // 
            // addressTtextBox
            // 
            this.addressTtextBox.Location = new System.Drawing.Point(137, 137);
            this.addressTtextBox.Name = "addressTtextBox";
            this.addressTtextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTtextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(137, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(137, 66);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(137, 31);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.Location = new System.Drawing.Point(20, 168);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(46, 13);
            this.hobbiesLabel.TabIndex = 4;
            this.hobbiesLabel.Text = "Hobbies";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 140);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(20, 66);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(53, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Lastname";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(52, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Firstname";
            // 
            // friendListdataGridView
            // 
            this.friendListdataGridView.AllowUserToAddRows = false;
            this.friendListdataGridView.AllowUserToDeleteRows = false;
            this.friendListdataGridView.AllowUserToOrderColumns = true;
            this.friendListdataGridView.AllowUserToResizeColumns = false;
            this.friendListdataGridView.AllowUserToResizeRows = false;
            this.friendListdataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.friendListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendListdataGridView.Location = new System.Drawing.Point(407, 44);
            this.friendListdataGridView.Name = "friendListdataGridView";
            this.friendListdataGridView.ReadOnly = true;
            this.friendListdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.friendListdataGridView.Size = new System.Drawing.Size(518, 257);
            this.friendListdataGridView.TabIndex = 3;
            this.friendListdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.friendListdataGridView_CellContentClick);
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 333);
            this.Controls.Add(this.friendListdataGridView);
            this.Controls.Add(this.AddFriendGroupBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddFriendGroupBox.ResumeLayout(false);
            this.AddFriendGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendListToolStripMenuItem;
        private System.Windows.Forms.GroupBox AddFriendGroupBox;
        private System.Windows.Forms.TextBox hobbiesTextBox;
        private System.Windows.Forms.TextBox addressTtextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridView friendListdataGridView;
    }
}