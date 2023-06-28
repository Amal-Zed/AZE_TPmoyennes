using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AZE_TPmoyennes
{
    class Classe
    {
        public string nomClasse { get; private set; }
        public List<Eleve> eleves { get; private set; }
        public List<string> matieres { get; private set; }

        public Classe(string NomClasse)
        {
            nomClasse = NomClasse;
            eleves = new List<Eleve>();
            matieres = new List<string>();
        }

        public void ajouterEleve(string prenom, string nom)
        {
            Eleve eleveclass = new Eleve(prenom, nom);
            eleves.Add(eleveclass);
        }

        public void ajouterMatiere(string matiere)
        {
            matieres.Add(matiere);
        }

        // La moyenne de la classe dans une matière
        public double Moyenne(int matiere)
        {
            double moymatclass = 0;
            for (int i = 0; i < eleves.Count; i++)
            {
                    double moymateleve = eleves[i].Moyenne(matiere);
                    moymatclass = moymatclass + moymateleve;
            }

            moymatclass = Math.Truncate((moymatclass / eleves.Count) * 100) / 100;
            return moymatclass ;
        }

        // La moyenne générale de la classe
        public double Moyenne()
        {
            double moygeneclass = 0;
            for (int j = 0; j < matieres.Count; j++)
            {
                double moymatgene = Moyenne(j);
                moygeneclass = moygeneclass + moymatgene;
            }

            moygeneclass = Math.Truncate((moygeneclass / matieres.Count) * 100) / 100;
            return moygeneclass;
        }

    }
}
