using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta.VIEWS
{
    public partial class AddUser : Form
    {
        String ID;
        String Nom;
        String Prenom;
        String Login;
        String Password;
        String Adresse;
        String CP;
        String Ville;
        String DateEmbauche;
        UserController uController;
        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(string id, string nom, string prenom, string login, string password, string adresse, string cp, string ville, string date)
        {
            this.ID = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.Password = password;
            this.Adresse = adresse;
            this.CP = cp;
            this.Ville = ville;
            this.DateEmbauche = date;
            this.textBoxID.Text = this.ID;
            this.textBoxNom.Text = this.Nom;
            this.textBoxPrenom.Text = this.Prenom;
            this.textBoxLogin.Text = this.Login;
            this.textBoxPassword.Text = this.Password;
            this.textBoxAdresse.Text = this.Adresse;
            this.textBoxCP.Text = this.CP;
            this.textBoxVille.Text = this.Ville;
            this.dateTimePickerDate.Text = this.DateEmbauche;

            uController = new UserController();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            uController = new UserController();

            DateTime dateValue = Convert.ToDateTime(this.dateTimePickerDate.Value);
            string date = dateValue.ToString("yyyy-MM-dd");

            string id = this.textBoxID.Text;
            string nom = this.textBoxNom.Text;
            string prenom = this.textBoxPrenom.Text;
            string login = this.textBoxLogin.Text;
            string password = this.textBoxPassword.Text;
            string adresse = this.textBoxAdresse.Text;
            string cp = this.textBoxCP.Text;
            string ville = this.textBoxVille.Text;
            uController.AddUser(id, nom, prenom, login, password, adresse, cp, ville, date);
            this.Close();

        }
    
    }
}
