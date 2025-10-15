
using AutreLangage = TF_2025_ArchiLogi_Delegue.Models;
using CSharp = TF_2025_ArchiLogi_Delegue.ModelsPourVraiDelegue;

Console.WriteLine("Observable classique");
#region Observable dans les autres langages
AutreLangage.BeAlerte beAlerte = new AutreLangage.BeAlerte();

AutreLangage.Citoyen citoyen1 = new AutreLangage.Citoyen("Natalie");
AutreLangage.Citoyen citoyen2 = new AutreLangage.Citoyen("Simon");

beAlerte.Ajouter(citoyen1);
beAlerte.Ajouter(citoyen2);
beAlerte.EnvoyerAlerte("Réduction de -50% sur les shampoings");

#endregion

Console.WriteLine();
Console.WriteLine("Utilisation de délégué");
#region Délégués en C#
CSharp.BeAlerte beAlerte2 = new CSharp.BeAlerte();

CSharp.Citoyen citoyen3 = new CSharp.Citoyen("Patrick");
CSharp.Citoyen citoyen4 = new CSharp.Citoyen("Laurie");

// On ajoute la méthode qui sera stocké dans le délégué
beAlerte2.Ajouter(citoyen3.RecevoirEmail);
beAlerte2.Ajouter(citoyen3.ContaterParPigeon);
//beAlerte2.Retirer(citoyen3.ContaterParPigeon);

beAlerte2.Ajouter(citoyen4.RecevoirEmail);
// /!\ un délégué stocke l'espace mémoire où se trouve
// la méthode à employer
// => le délgué ignorera l'accessibilité de cette méthode
citoyen4.AjouterNoteAlertePriveeABeAlerte(beAlerte2);

// Envoi un message via toutes les méthodes stockées
beAlerte2.EnvoyerAlerte("Pénurie de pattate");
//beAlerte2.del("Message d'un pirate");

#endregion




