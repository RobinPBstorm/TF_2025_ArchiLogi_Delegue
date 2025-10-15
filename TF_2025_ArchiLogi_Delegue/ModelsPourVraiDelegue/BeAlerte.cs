using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_2025_ArchiLogi_Delegue.ModelsPourVraiDelegue
{
    public delegate void SurAlerteRecue(string message);
    public class BeAlerte
    {
        // Stocke l'ensemble des méthodes qui seront appelé plus tard
        public SurAlerteRecue del = null;

        public void Ajouter(SurAlerteRecue methodePourContacter)
        {
            // ajoute la méthode dans "la liste" des fonctions
            del += methodePourContacter;
        }
        public void Retirer(SurAlerteRecue methodePourContacter)
        {
            // retire la méthode dans "la liste" des fonctions
            del -= methodePourContacter;
        }

        public void EnvoyerAlerte(string message)
        {
            if (del is not null)
            {
                // l'invocation de toutes méthodes stocker dans le délégué
                del(message);

                foreach(Delegate method in del.GetInvocationList())
                {
                    try
                    {
                        ((SurAlerteRecue)method)(message);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
            
            
        }
    }
}
