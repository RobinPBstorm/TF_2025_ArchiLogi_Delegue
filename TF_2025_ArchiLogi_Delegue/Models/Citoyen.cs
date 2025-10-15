using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_2025_ArchiLogi_Delegue.Models
{
    public class Citoyen : IContactable
    {
        public string Nom { get; set; }

        public Citoyen(string nom)
        {
            Nom = nom;
        }

        public void SurAlerteRecue(string message)
        {
            Console.WriteLine($"{Nom} a reçu un sms disant : {message}");
        }
    }
}
