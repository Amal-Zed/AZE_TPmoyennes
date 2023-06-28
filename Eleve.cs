using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AZE_TPmoyennes
{
    class Eleve
    {
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public List<Note> notes { get; private set; }

        public Eleve(string NomEleve, string PrenomEleve)
        {
            nom = NomEleve;
            prenom = PrenomEleve;
            notes = new List<Note>();
        }

        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }

        // La moyenne d'un élève dans une matière
        public double Moyenne(int matiere)
        {
            double moymatiere = 0;
            
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].matiere == matiere)
                {
                    moymatiere = moymatiere + notes[i].note;
                }
            }

            moymatiere = Math.Truncate((moymatiere / 5) * 100) / 100;
            return moymatiere ;
        }

        // La moyenne générale du même élève
        public double Moyenne()
        {
            double moygenerale = 0;
            int NumMat = 0;
            double MoyMati = Moyenne(NumMat);

            while (MoyMati != 0) 
            {
                MoyMati = Moyenne(NumMat);
                moygenerale = moygenerale + MoyMati;
                NumMat++;
            } 

            moygenerale = Math.Truncate((moygenerale / NumMat) * 100) / 100;
            return moygenerale;
  
        }

    }
}
