namespace biblioclasse
{
    /// <summary>
    /// Crée un etudiant
    /// </summary>
    public class Etudiant
    {
        private string _nom;
        private string _prenom;
        private bool _diplome;

        /// <summary>
        /// Cronstruit l'etudiant
        /// </summary>
        /// <param name="nom">nom de famille de l'etudiant</param>
        /// <param name="prenom">prenom de l'etudiant</param>
        public Etudiant(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Diplome = false;
        }

        /// <summary>
        /// Diplome un élève
        /// </summary>
        /// <returns>si il est diplomer ou non</returns>
        public bool Diplomer()
        {
            _diplome = true;
            return true;
        }

        /// <summary>
        /// accesseur du nom
        /// </summary>
        public string Nom 
        {
            get { return _nom; }
            private set { _nom = value; }
        }
        /// <summary>
        /// accesseur du prenom
        /// </summary>
        public string Prenom 
        {
            get { return _prenom; }
            private set { _prenom = value; }
        }
        /// <summary>
        /// accesseur du diplome
        /// </summary>
        public bool Diplome 
        {
            get { return _diplome; }
            private set { _diplome = value; }
        }
    }
}
