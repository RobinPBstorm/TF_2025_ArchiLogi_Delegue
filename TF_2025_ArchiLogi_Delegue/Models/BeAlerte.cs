using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_2025_ArchiLogi_Delegue.Models
{
    public class BeAlerte
    {
        public List<IContactable> Abonnes { get; set; }

        public BeAlerte()
        {
            Abonnes = new List<IContactable>();
        }

        public void Ajouter(IContactable contactable)
        {
            Abonnes.Add(contactable);
        }
        public void Retirer(IContactable contactable)
        {
            Abonnes.Remove(contactable);
        }

        public void EnvoyerAlerte(string message)
        {
            foreach(IContactable contactable in Abonnes)
            {
                contactable.SurAlerteRecue(message);
            }
        }

    }
}
