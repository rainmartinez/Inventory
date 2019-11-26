namespace Inventory
{
    partial class Additem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Addthing = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Itemname = new System.Windows.Forms.TextBox();
            this.Quant = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // Addthing
            // 
            this.Addthing.Location = new System.Drawing.Point(55, 190);
            this.Addthing.Name = "Addthing";
            this.Addthing.Size = new System.Drawing.Size(75, 23);
            this.Addthing.TabIndex = 4;
            this.Addthing.Text = "Add item";
            this.Addthing.UseVisualStyleBackColor = true;
            this.Addthing.Click += new System.EventHandler(this.Addthing_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(136, 190);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(136, 219);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 6;
            this.menu.Text = "Main menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(135, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(121, 23);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Itemname
            // 
            this.Itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemname.Location = new System.Drawing.Point(135, 85);
            this.Itemname.Name = "Itemname";
            this.Itemname.Size = new System.Drawing.Size(121, 23);
            this.Itemname.TabIndex = 8;
            this.Itemname.TextChanged += new System.EventHandler(this.Itemname_TextChanged);
            // 
            // Quant
            // 
            this.Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(135, 114);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(121, 23);
            this.Quant.TabIndex = 9;
            this.Quant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quant_KeyPress);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(135, 142);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(121, 23);
            this.Price.TabIndex = 10;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.Itemname);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Addthing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Additem";
            this.Text = "Additem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addthing;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Itemname;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button button1;
    }
}