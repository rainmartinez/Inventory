namespace Inventory
{
    partial class Signup
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
            this.Email = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.TextBox();
            this.Last = new System.Windows.Forms.TextBox();
            this.eadd = new System.Windows.Forms.TextBox();
            this.su = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(52, 192);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(102, 17);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email Address:";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.Location = new System.Drawing.Point(79, 164);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(74, 17);
            this.Lastname.TabIndex = 6;
            this.Lastname.Text = "Lastname:";
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.Location = new System.Drawing.Point(79, 134);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(74, 17);
            this.Firstname.TabIndex = 5;
            this.Firstname.Text = "Firstname:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(77, 74);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 17);
            this.Username.TabIndex = 8;
            this.Username.Text = "Username:";
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(159, 68);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(122, 23);
            this.User.TabIndex = 10;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Pass
            // 
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(159, 97);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(122, 23);
            this.Pass.TabIndex = 11;
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // First
            // 
            this.First.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(159, 128);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(122, 23);
            this.First.TabIndex = 12;
            this.First.TextChanged += new System.EventHandler(this.First_TextChanged);
            // 
            // Last
            // 
            this.Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last.Location = new System.Drawing.Point(160, 158);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(122, 23);
            this.Last.TabIndex = 13;
            this.Last.TextChanged += new System.EventHandler(this.Last_TextChanged);
            // 
            // eadd
            // 
            this.eadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eadd.Location = new System.Drawing.Point(160, 186);
            this.eadd.Name = "eadd";
            this.eadd.Size = new System.Drawing.Size(122, 23);
            this.eadd.TabIndex = 14;
            this.eadd.TextChanged += new System.EventHandler(this.eadd_TextChanged);
            // 
            // su
            // 
            this.su.Location = new System.Drawing.Point(174, 231);
            this.su.Name = "su";
            this.su.Size = new System.Drawing.Size(75, 23);
            this.su.TabIndex = 15;
            this.su.Text = "Sign up";
            this.su.UseVisualStyleBackColor = true;
            this.su.Click += new System.EventHandler(this.su_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.su);
            this.Controls.Add(this.eadd);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.First);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox First;
        private System.Windows.Forms.TextBox Last;
        private System.Windows.Forms.TextBox eadd;
        private System.Windows.Forms.Button su;
        private System.Windows.Forms.Label label1;
    }
}