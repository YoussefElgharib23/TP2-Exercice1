using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TP2_Exercice1
{
    public partial class Form1 : Form
    {
        // INITIALISER LA CONNECTION VERS LA BASE DE DONNEES
        static string connectionString = @"Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security=True;User ID=Youssef;Password=Youssef@2310";
        SqlConnection connection = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void formLoadEvent(object sender, EventArgs e)
        {
            connection.Open();
            textBoxNum.ReadOnly = true;
            actualiserListBoxStagiaires();
        }

        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void afficherMessageErreur(string message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void incrementerNumStagiaire()
        {
            string commandText = "SELECT * FROM Stagiaire";
            SqlCommand command = new SqlCommand(commandText, connection);
            command.CommandText = "SELECT COUNT(*) FROM Stagiaire";
            int num = (int)command.ExecuteScalar();
            if ( num == 0 )
            {
                textBoxNumModifier.Enabled = false;
                textBoxNumSup.Enabled = false;
                textBoxTelModifier.Enabled = false;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                textBoxNumModifier.Enabled = true;
                textBoxNumSup.Enabled = true;
                textBoxTelModifier.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
            num++;
            textBoxNum.Text = num.ToString();
        }

        private void actualiserListBoxStagiaires()
        {

            string commandText = "SELECT * FROM Stagiaire";
            SqlCommand command = new SqlCommand(commandText, connection);
            SqlDataReader reader = command.ExecuteReader();
            listBoxStagiaires.Items.Clear();
            if (!reader.HasRows)
            {
                afficherMessageErreur("Aucun enregistrement dans la base de donnees !");
            }
            else
            {
                while (reader.Read())
                {
                    listBoxStagiaires.Items.Add(string.Format("{0} : {1} {2}, {3}", reader[0], reader[1], reader[2], reader[3]));
                }
            }
            reader.Close();
            incrementerNumStagiaire();
        }

        private void btnAjouterClickEvent(object sender, EventArgs e)
        {
            string nom       = textBoxNom.Text,
                   prenom    = textBoxPrenom.Text,
                   telephone = textBoxTel.Text,
                   numero    = textBoxNum.Text;

            if ( nom == "" || prenom == "" || telephone == "" )
            {
                afficherMessageErreur("Un ou plusieur champs sont vides !");
                return;
            }

            if ( !Regex.IsMatch(telephone, @"^\d{10}$") )
            {
                afficherMessageErreur("Desole ! le format du numero du telephone est incorrect !");
                return;
            }

            try
            {
                string commandText = string.Format("INSERT INTO Stagiaire VALUES ({0},'{1}','{2}','{3}')", numero, nom, prenom, telephone);
                SqlCommand command = new SqlCommand(commandText, connection);
                if ( command.ExecuteNonQuery() > 0 )
                {
                    MessageBox.Show("Votre stagiaire est bient enregistree !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualiserListBoxStagiaires();
                    textBoxNom.Text = textBoxPrenom.Text = textBoxTel.Text = "";
                }
            }
            catch ( Exception exception )
            {
                afficherMessageErreur(exception.Message);
            }
        }

        private void btnModifierClickEvent(object sender, EventArgs e)
        {
            try
            {
                string telephone = textBoxTelModifier.Text,
                       numero = textBoxNumModifier.Text;
                if (telephone == "" || numero == "")
                {
                    afficherMessageErreur("Un champs ou plusieur sont vides !");
                    return;
                }
                else if ( Regex.IsMatch(telephone, @"^\d{10}$") )
                {
                    afficherMessageErreur("Desole ! Le format du telephone est incorrect !");
                    return;
                }

                int num = int.Parse(numero);

                string commandText = "SELECT COUNT(*) Stagiaire";
                SqlCommand command = new SqlCommand(commandText, connection);
                int countStagiaire = (int)command.ExecuteScalar();

                if (num < -1 || num > countStagiaire)
                {
                    afficherMessageErreur("Le numero de stagiaire est introuvable !");
                }

                command.CommandText = string.Format("UPDATE Stagiaire SET tel = '{0}' WHERE num = {1}", telephone, num);
                if ( command.ExecuteNonQuery() > 0 )
                {
                    actualiserListBoxStagiaires();
                    MessageBox.Show("Votre stagiaire est bien modifiee !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( FormatException )
            {
                afficherMessageErreur("Le numero de stagiaire est invalid !");
            }
            catch ( Exception exception )
            {
                afficherMessageErreur(exception.Message);
            }
        }

        private void btnSupprimerClickEvent (object sender, EventArgs e)
        {
            string numero = textBoxNumSup.Text;
            try
            {
                int num = int.Parse(numero);
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Stagiaire", connection);
                int countStagiaire = (int)command.ExecuteScalar();

                if ( countStagiaire == 0 ) 
                {
                    afficherMessageErreur("Aucun stagiaire enregistree !");
                    return;
                }
                command.CommandText = string.Format("SELECT * FROM Stagiaire WHERE num = {0}", num);
                SqlDataReader reader = command.ExecuteReader();
                if ( !reader.HasRows )
                {
                    afficherMessageErreur("Le stagiaire est introuvable !");
                    reader.Close();
                    return;
                }

                reader.Close();
                command.CommandText = string.Format("DELETE Stagiaire WHERE num = {0}", num);
                if ( command.ExecuteNonQuery() > 0 )
                {
                    MessageBox.Show("Votre stagiaire est bien supprimee !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNumSup.Text = "";
                }
                actualiserListBoxStagiaires();
            }
            catch ( FormatException )
            {
                afficherMessageErreur("Le format du numero de stagiaire est invalid ");
            }
            catch ( Exception exception )
            {
                afficherMessageErreur(exception.Message);
            }
        }
    }
}
