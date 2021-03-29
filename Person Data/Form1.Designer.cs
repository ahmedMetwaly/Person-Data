namespace Person_Data
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.showall = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectPhoto = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(170, 150);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(310, 49);
            this.id.TabIndex = 3;
            this.toolTip1.SetToolTip(this.id, "Enter The pesone\'s Id");
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(170, 223);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(310, 49);
            this.name.TabIndex = 4;
            this.toolTip1.SetToolTip(this.name, "Enter The pesone\'s Name");
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(170, 294);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(310, 49);
            this.address.TabIndex = 5;
            this.toolTip1.SetToolTip(this.address, "Enter The person\'s Address");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // add
            // 
            this.add.AllowDrop = true;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Location = new System.Drawing.Point(101, 415);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(155, 56);
            this.add.TabIndex = 7;
            this.add.Text = "ADD";
            this.toolTip1.SetToolTip(this.add, "First Enter Data And Press Here To ADD ");
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // find
            // 
            this.find.AllowDrop = true;
            this.find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find.Location = new System.Drawing.Point(262, 415);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(155, 56);
            this.find.TabIndex = 8;
            this.find.Text = "Find";
            this.toolTip1.SetToolTip(this.find, "Enter The ID First And press Here To show his data");
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // showall
            // 
            this.showall.AllowDrop = true;
            this.showall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.showall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showall.Location = new System.Drawing.Point(423, 415);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(155, 56);
            this.showall.TabIndex = 9;
            this.showall.Text = "Show All";
            this.showall.UseVisualStyleBackColor = false;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(584, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(155, 56);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.exit, "press Here To Exit");
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Jokerman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 88);
            this.label5.TabIndex = 11;
            this.label5.Text = "Person Data";
            this.toolTip1.SetToolTip(this.label5, "Apllication\'s Name");
            // 
            // selectPhoto
            // 
            this.selectPhoto.AllowDrop = true;
            this.selectPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectPhoto.Font = new System.Drawing.Font("Monotype Corsiva", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPhoto.Location = new System.Drawing.Point(575, 302);
            this.selectPhoto.Name = "selectPhoto";
            this.selectPhoto.Size = new System.Drawing.Size(187, 41);
            this.selectPhoto.TabIndex = 13;
            this.selectPhoto.Text = "Select Photo";
            this.toolTip1.SetToolTip(this.selectPhoto, "Select Photo");
            this.selectPhoto.UseVisualStyleBackColor = false;
            this.selectPhoto.Click += new System.EventHandler(this.selectPhoto_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(575, 132);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(187, 164);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 12;
            this.pic.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.selectPhoto);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.find);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button selectPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

