Voici un fichier CSV
attention il est encodé en UTF-16
attention il y a des caractères spéciaux qui rendent la lecture difficile pour toi

Je veux pour chaque ligne de ce tableau tu fasses la procédure suivante :
tu vas créer un fichier .cs que tu va appeler Token_BALISENOM.cs
Tâche1 : Tu dois remplacer BALISENOM par le texte de la colonne "fonetik" auquel tu rajoutes un nombre aléatoire entre 1 et 99.

Tâche2 : Ensuite dans chaque fichier tu vas écrire le code suivant :
"
namespace tocaki.a4_Dictionnary.a2;

public class Token_BALISEFONETIK : LexicalToken
{
    public override string Phonetics { get => "BALISEFONETIK"; }
    public override string DefinitionInTocaki { get => "BALISETOCAKI"; }
    public override string DefinitionInFrench { get => "BALISEFRANCAIS"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
"
- à la place de BALISEFONETIK tu écris la valeur qui se trouve dans la colonne "fonetik" mais sans le nombre aléatoire cette fois (attention cette action est différente de la Tâche1)
- à la place de BALISETOCAKI tu écris la valeur qui se trouve dans la colonne "definisyM"
- à la place de BALISEFRANCAIS tu écris la valeur qui se trouve dans la colonne "Explication, exemple"
- pour le code C# "get => [];" je veux que tu le laisses exactement comme ça

Fais ce travail pour les 20 premières lignes de mon fichier et donne moi un lien pour les télécharger