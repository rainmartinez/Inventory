namespace Inventory
{
    partial class Signin
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Buttonsi = new System.Windows.Forms.Button();
            this.Buttonsu = new System.Windows.Forms.Button();
            this.usernamesi = new System.Windows.Forms.TextBox();
            this.Passwordsi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(79, 93);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 17);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(83, 144);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 17);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // Buttonsi
            // 
            this.Buttonsi.Location = new System.Drawing.Point(97, 200);
            this.Buttonsi.Name = "Buttonsi";
            this.Buttonsi.Size = new System.Drawing.Size(75, 23);
            this.Buttonsi.TabIndex = 5;
            this.Buttonsi.Text = "Sign in";
            this.Buttonsi.UseVisualStyleBackColor = true;
            this.Buttonsi.Click += new System.EventHandler(this.Buttonsi_Click);
            // 
            // Buttonsu
            // 
            this.Buttonsu.Location = new System.Drawing.Point(208, 200);
            this.Buttonsu.Name = "Buttonsu";
            this.Buttonsu.Size = new System.Drawing.Size(75, 23);
            this.Buttonsu.TabIndex = 6;
            this.Buttonsu.Text = "Sign up";
            this.Buttonsu.UseVisualStyleBackColor = true;
            this.Buttonsu.Click += new System.EventHandler(this.Buttonsu_Click);
            // 
            // usernamesi
            // 
            this.usernamesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamesi.Location = new System.Drawing.Point(162, 93);
            this.usernamesi.Name = "usernamesi";
            this.usernamesi.Size = new System.Drawing.Size(121, 23);
            this.usernamesi.TabIndex = 7;
            this.usernamesi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Passwordsi
            // 
            this.Passwordsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordsi.Location = new System.Drawing.Point(162, 138);
            this.Passwordsi.Name = "Passwordsi";
            this.Passwordsi.PasswordChar = '*';
            this.Passwordsi.Size = new System.Drawing.Size(121, 23);
            this.Passwordsi.TabIndex = 8;
            this.Passwordsi.TextChanged += new System.EventHandler(this.Passwordsi_TextChanged);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 338);
            this.Controls.Add(this.Passwordsi);
            this.Controls.Add(this.usernamesi);
            this.Controls.Add(this.Buttonsu);
            this.Controls.Add(this.Buttonsi);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Signin";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Buttonsi;
        private System.Windows.Forms.Button Buttonsu;
        private System.Windows.Forms.TextBox usernamesi;
        private System.Windows.Forms.TextBox Passwordsi;
    }
}

