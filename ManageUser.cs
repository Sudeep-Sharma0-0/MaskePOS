using MaskeyPOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskePOS
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string password = passBox.Text;
            string id = idBox.Text;

            User user = new User(id, username, password);

            dbUsers.AddUser(user);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idBox.Text);
            dbUsers.DeleteUser(id);
        }
    }
}
