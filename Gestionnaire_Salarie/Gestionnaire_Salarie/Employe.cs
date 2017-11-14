using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_Employe
{
    class Employe
    {
        // Création de 3 propriétés identifiant, nom et téléphone
        public int _id { get; set; }
        public string _nom { get; set; }
        public string _prenom { get; set; }
        public DateTime _ddn { get; set; }
        public string _adl1 { get; set; }
        public string _adl2 { get; set; }
        public string _cp { get; set; }
        public string _ville { get; set; }
        public string _tel { get; set; }
        public string _NoSecu { get; set; }
        public int _civ { get; set; }
     /*   public string _SitFam { get; set; }
        public string _cont { get; set; }
        public string _serv { get; set; }
        public string _rib { get; set; }
     */

        // Constructeur
        public Employe()
        {
        }
    }
}
