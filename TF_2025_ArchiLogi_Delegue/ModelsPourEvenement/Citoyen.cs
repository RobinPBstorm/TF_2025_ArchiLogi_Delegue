using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_2025_ArchiLogi_Delegue.ModelsPourEvenement
{
    public class Citoyen
    {
        public string Nom { get; set; }

        public Citoyen(string nom)
        {
            Nom = nom;
        }

        public void AjouterNoteAlertePriveeABeAlerte(BeAlerte beAlerte)
        {
            beAlerte.Ajouter(NoteAlertePrivee);
        }

        public void ContaterParPigeon(string message)
        {

            throw new Exception("Plus de pigeon à envoyer");
            Console.WriteLine($"{Nom} a reçu un pigeon voyageur disant : {message}");
        }
        public void RecevoirEmail(string message)
        {
            Console.WriteLine($"{Nom} a reçu un mail disant : {message}");
        }
        private void NoteAlertePrivee(string message)
        {
            Console.WriteLine($"{Nom} a noté l'alerte : {message}");
        }
    }
}
