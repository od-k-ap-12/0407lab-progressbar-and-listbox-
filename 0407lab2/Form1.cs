using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _0407lab2
{
    public partial class Form1 : Form
    {
        List<User> Users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            User NewUser=new User(FirstName.Text,LastName.Text,Email.Text,PhoneNumber.Text);
            if (this.UsersList.Items.Contains(NewUser.ToString()))
            {
                MessageBox.Show("List already contains this user");
            }
            else
            {
                this.UsersList.Items.Add(NewUser.ToString());
                Users.Add(NewUser);
            }
        }

        private void TxtImport_Click(object sender, EventArgs e)
        {
            UsersList.Items.Clear();
            List<User> Users = new List<User>();
            StreamReader reader = new StreamReader("users.txt", Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                User NewUser = new User();
                NewUser.Code = Convert.ToInt32(reader.ReadLine());
                NewUser.FirstName = reader.ReadLine();
                NewUser.LastName = reader.ReadLine();
                NewUser.Email = reader.ReadLine();
                NewUser.PhoneNumber = reader.ReadLine();
                Users.Add(NewUser);
                UsersList.Items.Add(NewUser.ToString());
            }
            reader.Close();

        }

        private void TxtExport_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("users.txt", true);
            foreach (User User in Users)
            {
                writer.WriteLine(User.Code);
                writer.WriteLine(User.FirstName);
                writer.WriteLine(User.LastName);
                writer.WriteLine(User.Email);
                writer.WriteLine(User.PhoneNumber);
            }
            writer.Close();

        }

        private void XmlImport_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("../../users.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
            Users = (List<User>)serializer.Deserialize(stream);
            stream.Close();
        }

        private void XmlExport_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("users.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
            serializer.Serialize(stream, Users);
            stream.Close();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.UsersList.SelectedItems.Count != 0)
            {
                for(int i = 0; i < this.UsersList.SelectedItems.Count; i++)
                {
                    this.UsersList.Items.Remove(this.UsersList.SelectedItems[i]);
                    string[] UserSplit = this.UsersList.SelectedItem.ToString().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach(User FindUser in Users)
                    {
                        if (Convert.ToString(FindUser.Code) == UserSplit[0])
                        {
                            Users.Remove(FindUser);
                        }
                    }

                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (this.UsersList.SelectedItems.Count == 1)
            {
                string[] UserSplit=this.UsersList.SelectedItem.ToString().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                this.UsersList.Items.Remove(this.UsersList.SelectedItem);
                foreach (User FindUser in Users)
                {
                    if (Convert.ToString(FindUser.Code) == UserSplit[0])
                    {
                        Users.Remove(FindUser);
                    }
                }
                FirstName.Text = UserSplit[1];
                LastName.Text = UserSplit[2];
                Email.Text = UserSplit[3];
                PhoneNumber.Text = UserSplit[4];
            }
        }
    }
}
