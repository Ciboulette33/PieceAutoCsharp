using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestionnaire_Employe
{
    public partial class GestionEmploye : Form
    {
        public GestionEmploye()
        {
            InitializeComponent();


            //appelle méthode afficher civilité combobox
            DisplayCivCombo();

            //appelle méthode affichier table personnel de la BDD
            GetDataBDDEmploye();

        }

        //Combo
        private void DisplayCivCombo()
        {
            Bdd bdd = new Bdd();
            
            //même chose
            /*
            DataTable dtciv = bdd.DisplayCivCombo();
            comboBoxCiv.DataSource = dtciv;
            comboBoxCiv.ValueMember = dtciv.Columns[0].ColumnName;
            comboBoxCiv.DisplayMember = dtciv.Columns[1].ColumnName;
            */

            comboBoxCiv.DataSource = bdd.DisplayCivCombo();
            comboBoxCiv.DisplayMember = "civ_lib";
            comboBoxCiv.ValueMember = "civ_id";



        }



        //méthode récuperer information BDD (serveur MySQL)
        private void GetDataBDDEmploye()
        {
            //on met à null le data source avant d'exécuter la requête - sous entendu qu'on remet à zéro le tableau avant de le réinitialiser
            dataGridView1.DataSource = null;


            Bdd bdd = new Bdd();
            DataTable table = bdd.GetDataEmploye();
            
          

            dataGridView1.DataSource = table;
            
            string[] nomColumnsPersonnel = new string[] { "Id", "Nom", "Prénom","Date de Naissance","Adresse L1","Adresse L2","Code Postal","Ville", "Tel","Num. Secu.", "Civilité" };

            for (int i = 0; i < nomColumnsPersonnel.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = nomColumnsPersonnel[i];
            }
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPrenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            textBoxAdl1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxAdl2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxCP.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBoxVille.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBoxTel.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBoxNoSecu.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            int idCiv = (int)dataGridView1.SelectedRows[0].Cells[10].Value;
            comboBoxCiv.SelectedValue = idCiv;

            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());

        }

        //Bouton RAFRAICHIR
        private void btn_rafraichir_Click(object sender, EventArgs e)
        {
            GetDataBDDEmploye();
        }

        //Bouton Ajouter - appelle la méthode AddEmploye
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            DateTime myTime = this.dateTimePicker1.Value;
            

            //MessageBox.Show(myDay + "-" + myMonth + "-" + myYear, "OK");


            Employe employe = new Employe();
            employe._nom = textBoxNom.Text;
            employe._prenom = textBoxPrenom.Text;
            employe._ddn = myTime;
            employe._adl1 = textBoxAdl1.Text;
            employe._adl2 = textBoxAdl2.Text;
            employe._cp = textBoxCP.Text;
            employe._ville = textBoxVille.Text;
            employe._tel = textBoxTel.Text;
            employe._NoSecu = textBoxNoSecu.Text;
            employe._civ = (int)comboBoxCiv.SelectedValue;

            Bdd bdd = new Bdd();
            bdd.AddEmploye(employe);
        }
      
        //Bouton Modifier - appelle de la méthode  updateDataEmploye
        private void button_update_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            String selectedRow = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selectedRow);
            
           // DateTime myTime = Convert.ToDateTime(this.dateTimePicker1.Value.ToShortDateString());
            DateTime myTime = this.dateTimePicker1.Value;

            int civ_id = (int)comboBoxCiv.SelectedValue;

            bdd.UpdateDataEmploye(id, textBoxNom.Text, textBoxPrenom.Text, myTime, textBoxAdl1.Text, textBoxAdl2.Text, textBoxCP.Text, textBoxVille.Text, textBoxTel.Text, textBoxNoSecu.Text, civ_id);

            GetDataBDDEmploye();

        }
    }
}
