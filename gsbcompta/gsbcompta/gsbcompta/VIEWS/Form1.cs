using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta
{
    public partial class Form1 : Form
    {
  
        ListeFiches form;
        UserController uController;
        List<User> uList;
        public Form1()
        {
            InitializeComponent();
            uController = new UserController();
            uList = uController.getUsers();
            

            
        }

         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String login = this.textBoxLogin.Text;
            String password = this.textBoxPassword.Text;
            Boolean logged = false;
            foreach(User u in uList)
            {
                if(u.Login == login && u.checkPassword(password))
                {
                    logged = true;
                }
            }
            if(logged)
            {
                form = new ListeFiches();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login or Passwor");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
