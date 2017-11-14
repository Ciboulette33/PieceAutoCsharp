using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;



namespace Gestionnaire_Employe
{
    class Bdd
    {

        private MySqlConnection connection;

        // Constructeur
        public Bdd()
        {
            this.InitConnexion();
        }
        ///

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=gestionatorx666; UID=root; PASSWORD=;";
            this.connection = new MySqlConnection(connectionString);
        }


        /// <summary>
        /// méthode pour afficher information BDD
        /// </summary>
        public DataTable GetDataEmploye()
        {
           try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM personnel", this.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    this.connection.Clone();
                }
            }



        }


        // Méthode pour ajouter un contact
        public void AddEmploye(Employe employe)
        {
            //création de la commande Mysql (objet cmd)
            MySqlCommand cmdCountId = connection.CreateCommand();
            //Commande Mysql count - pour connaitre le nombre d'entré
            cmdCountId.CommandText = "SELECT count(*) FROM personnel";

            //declaration variable count
            int count;

            //OPEN CON AND EXEC insert
            try
            {
                //ouverture connexion BDD
                connection.Open();

                //convertion en entier sur 32 bits
                count = Convert.ToInt32(cmdCountId.ExecuteScalar());
                count = count + 1;
                //création de la commande Mysql (objet cmd)
                MySqlCommand myCommand = connection.CreateCommand();
                //Commande Mysql
                myCommand.CommandText = "INSERT INTO personnel (pers_id,pers_nom,pers_prenom,pers_ddn,pers_adl1,pers_adl2,pers_cp,pers_ville,pers_tel,pers_NoSecu,pers_civ) VALUES (@id, @nom, @prenom, @ddn, @adl1, @adl2, @cp, @ville, @tel, @NoSecu, @civ)";
                myCommand.Parameters.AddWithValue("@id", count );
                myCommand.Parameters.AddWithValue("@nom", employe._nom);
                myCommand.Parameters.AddWithValue("@prenom", employe._prenom);
                myCommand.Parameters.AddWithValue("@ddn", employe._ddn);
                myCommand.Parameters.AddWithValue("@adl1", employe._adl1);
                myCommand.Parameters.AddWithValue("@adl2", employe._adl2);
                myCommand.Parameters.AddWithValue("@cp", employe._cp);
                myCommand.Parameters.AddWithValue("@ville", employe._ville);
                myCommand.Parameters.AddWithValue("@tel", employe._tel);
                myCommand.Parameters.AddWithValue("@NoSecu", employe._NoSecu);
                myCommand.Parameters.AddWithValue("@civ", employe._civ);
              /*  myCommand.Parameters.AddWithValue("@SitFam", employe._SitFam);
                myCommand.Parameters.AddWithValue("@cont", employe._cont);
                myCommand.Parameters.AddWithValue("@serv", employe._serv);
                myCommand.Parameters.AddWithValue("@rib", employe._rib);
            */
                //execution commande INSERT INTO
                myCommand.ExecuteNonQuery();

                //Message affiche information insertion
                MessageBox.Show("Personne ajouté \n id : " + count + "\n Nom :" + employe._nom + "\n prenom :" + employe._prenom, "OK");
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }


        }

        /// <summary>
        /// méthode modifier employe
        /// </summary>
        /// <returns></returns>
        //Methode Update BDD
        public void UpdateDataEmploye(int id, string nom, string prenom, DateTime ddn, string adl1, string adl2, string cp, string ville, string tel, string noSecu, int civ)
        {
            // création de la commande Mysql(objet cmd)
            MySqlCommand cmd = connection.CreateCommand();
            //SQL STMT
            string sql = "UPDATE personnel SET pers_nom='" + nom + "',pers_prenom='" + prenom + "',pers_ddn='" +ddn+ "',pers_adl1='" + adl1 + "',pers_adl2='" + adl2 + "',pers_cp='" + cp + "',pers_ville='" + ville + "', pers_tel='" + tel + "',pers_NoSecu='" + noSecu + "',pers_civ='" + civ + "' WHERE pers_id=" + id + "";
            cmd = new MySqlCommand(sql, connection);

            //OPEN CON,UPDATE,RETRIEVE DGVIEW
            try
            {
                connection.Open();
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                adap.UpdateCommand = connection.CreateCommand();
                adap.UpdateCommand.CommandText = sql;

                if (adap.UpdateCommand.ExecuteNonQuery() > 0)
                {
                   // clearTxts();
                    MessageBox.Show("Modification Réuissie");
                }
                
                connection.Close();

                //GetDataBDD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }


        }


        //métode afficher civilite comboBox
        public DataTable DisplayCivCombo()
        {

            MySqlDataAdapter sqlgender = new MySqlDataAdapter("Select * from civilite", this.connection);

            DataTable dtciv = new DataTable();

            sqlgender.Fill(dtciv);

            return dtciv;


        }

    }
}
