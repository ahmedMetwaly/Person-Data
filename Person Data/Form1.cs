using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Person_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("G:\\C#\\the beginning\\Person Data\\Person Data\\data");
            StreamWriter streamWriter = new StreamWriter("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\Person data.txt", true);
            streamWriter.Close();
            add.Focus();
            add.Select();

           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string Str = id.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (id.Text.Trim() != "" || name.Text.Trim() != "" || address.Text.Trim() != "")
            {
                if (isNum)
                {
                    StreamReader reader = new StreamReader("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\Person data.txt");
                    string r = reader.ReadToEnd();
                    reader.Close();
                    if (r.Contains(id.Text + ";"))
                    {
                        MessageBox.Show("This Id Exists , Please Change It Then ADD The Person");
                        id.Focus();
                        id.SelectAll();

                    }

                    else
                    {
                        if (pic.Image == null)
                        {
                            openFileDialog.Title = "Select A Photo";
                            openFileDialog.Filter = "IMAGE|*.jpg;*.png;*gif";
                          
                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                pic.Image = Image.FromFile(openFileDialog.FileName);
                                if (!Directory.Exists("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\img"))
                                    Directory.CreateDirectory("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\img");
                            }

                            else
                            {
                                MessageBox.Show("You must choose a picture");
                                return;
                            }
                        } 
                        if ( name.Text.Trim() != "" && address.Text.Trim() != "")
                        {
                            StreamWriter streamWriter = new StreamWriter("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\Person data.txt", true);
                            string data = id.Text.Trim() + ";" + name.Text.Trim() + ";" + address.Text.Trim() + ";";
                            streamWriter.WriteLine(data);
                            streamWriter.Close();
                            pic.Image.Save("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\img\\" + id.Text + ".jpg");


                            MessageBox.Show("Person is Added");
                            foreach (Control c in this.Controls)
                                if (c is TextBox)
                                {
                                    c.Text = "";
                                    
                                }
                            pic.Image = new PictureBox().Image;
                            id.Focus();
                            add.Focus();
                            add.Select();
                        }
                        else
                        {
                            MessageBox.Show("You Must Add All Data");
                        /*    if (id.Text.Trim() == "")
                                idl.Visible=true;
                            else if (name.Text.Trim() == "")
                                namel.Visible = true;
                            else if (address.Text.Trim() == "")
                                addressl.Visible = true;
                            else if (id.Text.Trim() != "")
                                idl.Visible = false;
                            else if (name.Text.Trim() != "")
                                namel.Visible = false;
                            else if (address.Text.Trim() != "")
                                addressl.Visible = false;
                                */
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sorry The Id it must be a number");
                    id.Focus();
                    id.SelectAll();
                }
            }
            else
                MessageBox.Show("Please Enter All Data");
        }

        private void find_Click(object sender, EventArgs e)
        {
            
            string Str = id.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            bool flag = false;
            if (isNum)
            {
                StreamReader reader = new StreamReader("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\Person data.txt");
                string line = "";

                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        string[] arr = line.Split(';');
                        if (id.Text.Trim() == arr[0])
                        {
                            id.Text = arr[0];
                            name.Text = arr[1];
                            address.Text = arr[2];
                            pic.Image = Image.FromFile("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\img\\" + id.Text.Trim() + ".jpg");

                            flag = true;
                            
                            break;

                        }

                    }

                } while (line != null);
                reader.Close();

                if (flag == false)
                {
                    MessageBox.Show("This Not Found");
                    foreach (Control c in this.Controls)
                        if (c is TextBox)
                            c.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Please Id Must Be A Number");
                foreach (Control c in this.Controls)
                    if (c is TextBox)
                        c.Text = "";
            }
           
        }

        private void showall_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            StreamReader streamReader = new StreamReader("G:\\C#\\the beginning\\Person Data\\Person Data\\data\\person data.txt");
            string line = "";
            int mytop = 10;
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.AutoScroll = true;
            form2.Font = this.Font;
            form2.Size = this.Size;
            form2.Icon = this.Icon;
            form2.Height +=100 ;
            do
            {
                line = streamReader.ReadLine();
                if (line != null)
                {
                    Label labelid = new Label();
                    Label labelname = new Label();
                    Label labeladdress = new Label();
                    PictureBox pictureBox = new PictureBox();

                    labelid.Size = new Size(300,50);
                    labelid.Top = mytop;
                    labelid.Text = "ID : "+line.Split(';')[0];
                    

                    
                    labelname.Size = new Size(300, 50);
                    labelname.Top = mytop + 50;
                    labelname.Text = "Name : " + line.Split(';')[1];

                    
                    labeladdress.Size = new Size(300, 50);
                    labeladdress.Top = mytop +100;
                    labeladdress.Text = "Address : " + line.Split(';')[2];

                    pictureBox.Left = 305;
                    pictureBox.Top = mytop;
                    pictureBox.Size = new Size(150, 150);
                    pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    string img = "G:\\C#\\the beginning\\Person Data\\Person Data\\data\\img\\" + line.Split(';')[0] + ".jpg";
                    if(File.Exists(img))
                      pictureBox.Image = Image.FromFile(img);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    mytop += 180;
                    form2.Controls.Add(labelid);
                    form2.Controls.Add(labelname);
                    form2.Controls.Add(labeladdress);
                    form2.Controls.Add(pictureBox);

                }
            } while (line != null);
            streamReader.Close();
            form2.ShowDialog();

        }

        private void selectPhoto_Click(object sender, EventArgs e)
        {
           
            openFileDialog.Filter = "Images|*.png;*.jpg;*.gif";
            openFileDialog.Title = "Select A Photo";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pic.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("You Don't Choosed Picture");
            }
          
        }

       
    }
}
