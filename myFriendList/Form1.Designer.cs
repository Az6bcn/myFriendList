namespace myFriendList
{
    partial class myFriendList
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Enterbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(815, 440);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Enterbutton
            // 
            this.Enterbutton.Location = new System.Drawing.Point(881, 173);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Size = new System.Drawing.Size(75, 23);
            this.Enterbutton.TabIndex = 1;
            this.Enterbutton.Text = "Go";
            this.Enterbutton.UseVisualStyleBackColor = true;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter your Name:";
            // 
            // nomtextBox
            // 
            this.nomtextBox.Location = new System.Drawing.Point(881, 128);
            this.nomtextBox.Name = "nomtextBox";
            this.nomtextBox.Size = new System.Drawing.Size(119, 20);
            this.nomtextBox.TabIndex = 3;
            // 
            // myFriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 439);
            this.Controls.Add(this.nomtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enterbutton);
            this.Controls.Add(this.pictureBox);
            this.Name = "myFriendList";
            this.Text = "WelcomepageForm";
            this.Load += new System.EventHandler(this.myFriendList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Enterbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomtextBox;
    }
}

